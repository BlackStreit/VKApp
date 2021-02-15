using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        async void FetchUserInfo()
        {
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/users.get?user_ids={txtUserId.Text}&access_token={ACCESS_TOKEN}&v={Version}");
            txtRespone.Text = await response.Content.ReadAsStringAsync();
        }

        private void btnMakeRequests_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
            txtRespone.Text = "Гружу p_q";
        }
    }
}
