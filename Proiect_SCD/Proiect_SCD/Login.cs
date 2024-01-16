using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Proiect_SCD
{
    public partial class Login : Form
    {
        //UserService userService;
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public Login()
        {
            InitializeComponent();
            //userService = new UserService();
            //userService.createConnection();
            createConnection();
        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {
            var loginData = new { username = usernameTextBox.Text, password = passswordTextBox.Text };
            var response = await client.PostAsJsonAsync("http://localhost:8080/api/login/admin", loginData);

            if (response.IsSuccessStatusCode)
            {
                Form1 form1 = new Form1();
                form1.Show();
                
            }
            else
            {
                //var data = await response.Content.ReadAsStringAsync();
                //MessageBox.Show(data);\
                MessageBox.Show("Invalid username or password!");
            }
        
        }
        private void createAcc_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
        private void charPass_MouseDown(object sender, MouseEventArgs e)
        {
            passswordTextBox.PasswordChar = '\0';
            passswordTextBox.UseSystemPasswordChar = false;
        }

        private void charPass_MouseUp(object sender, MouseEventArgs e)
        {
            passswordTextBox.PasswordChar = '*';
            passswordTextBox.UseSystemPasswordChar = true;
        }

       
    }
}
