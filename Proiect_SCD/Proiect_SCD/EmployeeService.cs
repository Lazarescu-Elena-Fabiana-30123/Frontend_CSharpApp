using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Proiect_SCD
{
    class EmployeeService
    {
        static HttpClient client = new HttpClient();
        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public List<Employee> getEmployees()
        {
            List<Employee> employees = null;

            HttpResponseMessage response = client.GetAsync("/api/employee/get").Result; 

            if (response.IsSuccessStatusCode)
            {
                //return JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Employee.json"));
                
                return JsonSerializer.Deserialize<List<Employee>>(response.Content.ReadAsStringAsync().Result);

            }

            return null;
        }

        /*public List<Employee> getManagers()
        {
            List<Employee> managers = null;

            HttpResponseMessage response = client.GetAsync("/api/employee/get/managers").Result;

            if (response.IsSuccessStatusCode)
            {
                //return JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Employee.json"));

                return JsonSerializer.Deserialize<List<Employee>>(response.Content.ReadAsStringAsync().Result);

            }

            return null;

        }
        */

        public Employee GetEmployeeByID(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/employee/get/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                if (!string.IsNullOrEmpty(jsonContent))
                {
                    try
                    {
                        return JsonSerializer.Deserialize<Employee>(jsonContent);
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

        public Employee getEmployeeByName(string name)
        {
            /*HttpResponseMessage response = client.GetAsync("api/employee/get/employee/{name}").Result;
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<Employee>(response.Content.ReadAsStringAsync().Result);
            }
            else return null;*/
            HttpResponseMessage response = client.GetAsync($"api/employee/get/employee/{name}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;
 
                    try
                    {
                        return JsonSerializer.Deserialize<Employee>(jsonContent);
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
        public void deleteEmployeeById(int id)
        {
            /* HttpResponseMessage response = client.DeleteAsync("api/employee/deleteByName/{name}").Result;

             if (response.IsSuccessStatusCode)
             {
                 MessageBox.Show("Employee deleted successfully");
             }
             else MessageBox.Show($"Error: {response.StatusCode}");
             */


            HttpResponseMessage response = client.DeleteAsync("api/employee/delete/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                try
                {
                    JsonSerializer.Deserialize<Employee>(jsonContent);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Error parsing JSON: {ex.Message}");

                }

            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");

            }
        }
        public void deleteEmployee(string name)
        {
           /* HttpResponseMessage response = client.DeleteAsync("api/employee/deleteByName/{name}").Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Employee deleted successfully");
            }
            else MessageBox.Show($"Error: {response.StatusCode}");
            */
            

            HttpResponseMessage response = client.DeleteAsync("api/employee/deleteByName/{name}").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                try
                {
                     JsonSerializer.Deserialize<Employee>(jsonContent);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Error parsing JSON: {ex.Message}");
                    
                }

            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
               
            }
        }

        public Employee addEmployee(Employee employee)
        {
            /* HttpResponseMessage response = client.DeleteAsync("api/employee/create").Result;

             if (response.IsSuccessStatusCode)
             {
                 return JsonSerializer.Deserialize<Employee>(response.Content.ReadAsStringAsync().Result);
             }
             else MessageBox.Show($"Error: {response.StatusCode}");
             return null;*/
            /*HttpResponseMessage response = client.PostAsync($"api/employee/create").Result;

          */
            string jsonEmployee = JsonSerializer.Serialize(employee);

            
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("api/employee/create", content).Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;

              
                    try
                    {
                        return JsonSerializer.Deserialize<Employee>(jsonContent);
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

        public Employee updateEmployee(int id, Employee employee)
        {
            string jsonEmployee = JsonSerializer.Serialize(employee);


            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync("api/employee/update/{id}", content).Result;
            

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = response.Content.ReadAsStringAsync().Result;


                try
                {
                    return JsonSerializer.Deserialize<Employee>(jsonContent);
                    MessageBox.Show("Employee info updated successfully");
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
