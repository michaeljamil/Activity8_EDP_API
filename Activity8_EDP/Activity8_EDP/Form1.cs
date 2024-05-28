using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Activity8_EDP
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize settings if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if necessary
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            await GetUsersAndPosts();
        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            await PostUserAndPost();
        }

        private async Task GetUsersAndPosts()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost/my_api/index.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<UserPost>>(responseBody);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task PostUserAndPost()
        {
            var userPost = new
            {
                name = nameTxtbox.Text,
                email = emailTxtbox.Text,
                title = titleTxtbox.Text,
                content = contentTxtbox.Text
            };

            try
            {
                var json = JsonConvert.SerializeObject(userPost);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost/my_api/index.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                MessageBox.Show("POST Response: " + responseBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void nameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contentTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class UserPost
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}
