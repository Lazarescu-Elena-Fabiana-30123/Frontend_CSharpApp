using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_SCD
{
    class DepartmentService
    {
        static HttpClient client = new HttpClient();
        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public List<Department> getDepartments()
        {
            List<Department> departments = null;

            HttpResponseMessage response = client.GetAsync("/api/department/get").Result;

            if (response.IsSuccessStatusCode)
            {
                //return JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Employee.json"));

                return JsonSerializer.Deserialize<List<Department>>(response.Content.ReadAsStringAsync().Result);

            }

            return null;
        }

        public List<Employee> GetDepartmentEmployees(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/department/get/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                if (!string.IsNullOrEmpty(jsonContent))
                {
                    try
                    {
                        return JsonSerializer.Deserialize<List<Employee>>(jsonContent);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Error parsing JSON: {ex.Message}");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Response content is empty.");
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return null;
            }
        }

        public Department GetDepartmentById(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/department/getById/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                if (!string.IsNullOrEmpty(jsonContent))
                {
                    try
                    {
                        return JsonSerializer.Deserialize<Department>(jsonContent);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Error parsing JSON: {ex.Message}");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Response content is empty.");
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return null;
            }
        }

        public void deleteDepartmentById(int id)
        {
            HttpResponseMessage response = client.DeleteAsync($"api/department/delete/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Department with id " + id + " was deleted successfully!");
            }
            else
              MessageBox.Show($"Error: {response.StatusCode}");
            
        }

        public Department GetDepartmentByName(string name)
        {
            /*Department department = null;

            HttpResponseMessage response = client.GetAsync("/api/department/getByName/{name}").Result;

            if (response.IsSuccessStatusCode)
            {
                //return JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Employee.json"));

               // return JsonSerializer.Deserialize<Department>(response.Content.ReadAsStringAsync().Result);
       
            }

            return null;*/
            HttpResponseMessage response = client.GetAsync($"api/department/getByName/{name}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                if (!string.IsNullOrEmpty(jsonContent))
                {
                    try
                    {
                        return JsonSerializer.Deserialize<Department>(jsonContent);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Error parsing JSON: {ex.Message}");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Response content is empty.");
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return null;
            }

        }

        public Department AddDepartment(Department department)
        {
            string jsonEmployee = JsonSerializer.Serialize(department);


            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("api/department/create", content).Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                try
                {
                    return JsonSerializer.Deserialize<Department>(jsonContent);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Error parsing JSON: {ex.Message}");
                    return null;
                }

            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return null;
            }
        }
    }
}
