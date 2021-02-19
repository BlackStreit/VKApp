using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Encodings;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using VKapp.vk;
using System.Reflection;
using System.IO;

namespace VKapp
{
    public partial class Form1 : Form
    {
        readonly HttpClient client;
        private String ACCESS_TOKEN;
        private String Version = "5.130";

        BindingList<VKUser> vKUsers = new BindingList<VKUser>();

        private VKGroup _group;

        public Task<HttpResponseMessage> VKGet(String method, Dictionary<String, String> param)
        {
            var builder = new UriBuilder($"https://api.vk.com/method/{method}");
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["access_token"] = ACCESS_TOKEN;
            query["v"] = Version;
            foreach (var key in param.Keys)
            {
                query[key] = param[key];
            }
            builder.Query = query.ToString();
            String url = builder.ToString();
            return client.GetAsync(url);
        }

        private VKGroup group
        {
            get { return _group; }
            set { 
                _group = value;
                picAvatar.Load(_group.photo_100);
                if (_group.cover != null)
                {
                    picCover.Load(_group.cover.images.Last().url);
                }
                lblGroupName.Text = _group.name;

            }
        }

        private VKUserInfoResponse _VKUser;

        private VKUserInfoResponse VkUser
        {
            get { return _VKUser; }
            set { 
                _VKUser = value;
                lblName.Text = $"Имя: {VkUser.first_name}";
                lblSureName.Text = $"Фамилия: {VkUser.last_name}";
                picUserAvatar.Load(VkUser.photo_max);
            }
        }


        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            grdUsers.DataSource = vKUsers;
            StreamReader sr = new StreamReader("TOCEN.txt");
            ACCESS_TOKEN = sr.ReadLine();
        }

        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        async void FetchGroupInfo()
        {
            HttpResponseMessage response = await VKGet("groups.getById", new Dictionary<string, string> {
                ["group_id"] = txtUserId.Text,
                ["fields"] = "cover"

            }
                );
            var content = await response.Content.ReadAsStringAsync();

            var VKresponse = JsonSerializer.Deserialize<VKListResponse<VKGroup>>(content);

            group = VKresponse.response[0];

            //txtRespone.Text = PrettyJson(content);
        }

        async void FetchMembersInfo()
        {
            HttpResponseMessage response = await VKGet("groups.getMembers", new Dictionary<string, string>
            {
                ["group_id"] = txtUserId.Text,
                ["fields"] = "photo_100",
                ["count"] = "10",
                ["lang"] = "ru"

            }
                ) ;
            var content = await response.Content.ReadAsStringAsync();

            var itemsResponse = JsonSerializer.Deserialize<VKDictResponse<VKItemsResponce<VKUser>>>(content);

            vKUsers.Clear();
            vKUsers.AddRange(itemsResponse.response.items);
            txtRespone.Text = PrettyJson(content);
        }

        async void FetchUserInfo(String id)
        {
            HttpResponseMessage response = await VKGet("users.get", new Dictionary<string, string>
            {
                ["user_ids"] = id,
                ["fields"] = "photo_max,counters",
                ["lang"] = "ru"

            });
            var content = await response.Content.ReadAsStringAsync();

            var itemsResponse = JsonSerializer.Deserialize<VKUserResponse<VKUserInfoResponse>>(content);

            pnUserInfo.Visible = true;

            VkUser = itemsResponse.response[0];
            txtRespone.Text = PrettyJson(content);
        }

        private void btnMakeRequests_Click(object sender, EventArgs e)
        {
            FetchGroupInfo();
            FetchMembersInfo();
            txtRespone.Text = "Гружу p_q";
        }


        private void btnVisible_Click(object sender, EventArgs e)
        {
            pnUserInfo.Visible = false;
        }

        private void grdUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = grdUsers.CurrentCell.OwningRow.DataBoundItem as VKUser;
            txtRespone.Clear();
            FetchUserInfo(user.id.ToString());
            pnUserInfo.Visible = true;
        }
    }
}
