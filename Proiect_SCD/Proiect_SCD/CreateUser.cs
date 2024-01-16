using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_SCD
{
    public partial class CreateUser : Form
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public CreateUser()
        {
            InitializeComponent();
            createConnection();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {   
                var user = new { name = textBox1.Text, username = textBox2.Text, password = textBox3.Text };
                var response = await client.PostAsJsonAsync("http://localhost:8080/api/user/create", user);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Account created successfully!");
                }
                else MessageBox.Show("Account could not be created!");
           
        }

        private void charPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '\0';
            textBox3.UseSystemPasswordChar = false;
        }

        private void charPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox3.UseSystemPasswordChar = true;
        }
    }
}
