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

namespace VKapp
{
    public partial class Form1 : Form
    {
        readonly HttpClient client;
        private String ACCESS_TOKEN = "0d570a4f0d570a4f0d570a4feb0d21700f00d570d570a4f6d7bfe6adfc48084dfcd1c36";
        private String Version = "5.130";


        private VKGroup _group;

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

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
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

        async void FetchUserInfo()
        {
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/groups.getById?group_id={txtUserId.Text}&fields=cover&access_token={ACCESS_TOKEN}&v={Version}");
            var content = await response.Content.ReadAsStringAsync();

            var VKresponse = JsonSerializer.Deserialize<VKResponse<VKGroup>>(content);

            group = VKresponse.response[0];

            txtRespone.Text = PrettyJson(content);
        }

        private void btnMakeRequests_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
            txtRespone.Text = "Гружу p_q";
        }
    }
}
