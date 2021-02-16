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
        private String ACCESS_TOKEN = "4cbaad1a4cbaad1a4cbaad1aee4cccc2f644cba4cbaad1a2c937e0c573a2f87599251bd";
        private String Version = "5.130";
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
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/groups.getById?group_id={txtUserId.Text}&access_token={ACCESS_TOKEN}&v={Version}");
            var content = await response.Content.ReadAsStringAsync();

            var VKresponse = JsonSerializer.Deserialize<VKResponse<VKGroup>>(content);


            txtRespone.Text = VKresponse.ToString();
        }

        private void btnMakeRequests_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
            txtRespone.Text = "Гружу p_q";
        }
    }
}
