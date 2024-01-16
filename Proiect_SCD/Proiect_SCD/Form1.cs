using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proiect_SCD
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        DepartmentService departmentService;

        List<Employee> employees;
        List<Department> departments;

        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();

            departmentService = new DepartmentService();
            departmentService.createConnection();
        }

        private void loadEmployees_Click(object sender, EventArgs e)
        {
            var employeeList = employeeService.getEmployees();


            employeeListComboBox.DataSource = employeeList;

            employeeListComboBox.DisplayMember = employeeListComboBox.ValueMember;
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            string employee = employeeListComboBox.SelectedItem.ToString();

            ///employeeService.deleteEmployee(employee);
            employeeService.deleteEmployeeById(int.Parse(empID.Text));
           
        }
        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = employeeService.getEmployeeByName(employeeListComboBox.SelectedItem.ToString());
            //var updatedEmployee = new { name = nameLabel.Text, departmentID = deptIDLabel.Text, managerID = managerLabel.Text, email = emailLabel.Text, enrollDate = EnrollDateLabel.Text };
            employee.id = int.Parse(empID.Text);
            
            employee.name = nameLabel.Text;
            employee.departmentID= int.Parse(deptIDLabel.Text);
            employee.managerID = int.Parse(managerLabel.Text);
            employee.email = emailLabel.Text;
     
            employeeService.updateEmployee(int.Parse(empID.Text),employee);
        }
        private void employeeListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
                Employee employee = employeeService.getEmployeeByName(employeeListComboBox.SelectedItem.ToString());
                empID.Text = employee.id.ToString();
                nameLabel.Text = employee.name;
                deptIDLabel.Text = employee.departmentID.ToString();
                managerLabel.Text = employee.managerID.ToString();
                emailLabel.Text = employee.email;
                EnrollDateLabel.Text = employee.enrollDate.ToString();

            Employee manager = employeeService.GetEmployeeByID(int.Parse(managerLabel.Text));
            textBoxManager.Text = manager.name;
            Department department = departmentService.GetDepartmentById(int.Parse(deptIDLabel.Text));
            departmentName.Text = department.description;


        }

        private void addEmployee_Click(object sender, EventArgs e)
        {


            Department department = departmentService.GetDepartmentByName(departmentsComboBox.SelectedItem.ToString());
            
            //Employee manager = employeeService.getEmployeeByName(textBox1.Text);
            Employee employee = new Employee(); //= new { name = nameTxtBox, departmentID = department.departmentID, managerID = textBox3, email = textBox5 };

        employee.name = nameTxtBox.Text;
        employee.departmentID = department.departmentID;
      
        // employee.managerID = manager.id;
        employee.managerID = int.Parse(textBox1.Text);
        employee.email = textBox5.Text;
        employeeService.addEmployee(employee);
    } 

        private void Form1_Load(object sender, EventArgs e)
        {
            var deptList = departmentService.getDepartments();
            departmentsComboBox.DataSource = deptList;
            departmentsComboBox.DisplayMember = departmentsComboBox.ValueMember;

            
            var managers = employeeService.getEmployees();
            managerComboBox.DataSource = managers;
            managerComboBox.DisplayMember = managerComboBox.ValueMember;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       /* private void manageDepartments_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }*/

        private void loadDeptEmployees_Click(object sender, EventArgs e) //load the employees for every department
        {
            var employees1 = departmentService.GetDepartmentEmployees(int.Parse(deptID.Text));
            comboBox2.DataSource = employees1;
            comboBox2.DisplayMember = comboBox2.ValueMember;
            
        }

        private void loadDepartments_Click(object sender, EventArgs e)
        {
            var departmentList = departmentService.getDepartments();
            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = comboBox1.ValueMember;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) 
        {
            Department dep = departmentService.GetDepartmentByName(comboBox1.SelectedItem.ToString());
            nameDepartment.Text = dep.description;
            deptID.Text = dep.departmentID.ToString();
            parentIDtxt.Text = dep.parentID.ToString();
            managertxt1.Text = dep.managerID.ToString();
            Employee manager = employeeService.GetEmployeeByID(int.Parse(managertxt1.Text)); //the name of the manager

            textBox2.Text = manager.name;

        }

        private void deleteDepartment_Click(object sender, EventArgs e)
        {
            string department = departmentsComboBox.SelectedItem.ToString();
            Department dep = departmentService.GetDepartmentByName(department);
            departmentService.deleteDepartmentById(dep.departmentID);
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department();

            department.description = textBox4.Text;
            department.parentID = int.Parse(textBoxParentID.Text);
            department.managerID = employeeService.getEmployeeByName(managerComboBox.SelectedItem.ToString()).id;
        }

        
    }
}
