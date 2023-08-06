using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_EmpolyeeDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Binary_Writer_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Employee.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(Emp_ID.Text);
                employee.Name = Emp_Name.Text;
                employee.Salary = Convert.ToInt32(EMp_Salary.Text);
                formatter.Serialize(fileStream, employee);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Binary_Read_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Employee.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Employee employee = new Employee();

                // we done explicit type casting from Object --> Product
                employee = (Employee)formatter.Deserialize(fileStream);
                Emp_ID.Text = employee.Id.ToString();
                Emp_Name.Text = employee.Name;
                EMp_Salary.Text = employee.Salary.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
