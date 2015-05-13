using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        //private string id;
        //private string  name;
        //private double sallary;

       Employee aEmployee=new Employee();
        private void showButton_Click(object sender, EventArgs e)
        { 
            if(idTextBox.Text != "" && nameTextBox.Text != "" && salarryTextBox.Text !="")
            {
                aEmployee.id = idTextBox.Text;
                aEmployee.name = nameTextBox.Text;
                aEmployee.sallary = Convert.ToDouble(salarryTextBox.Text);

                MessageBox.Show("Id :" + aEmployee.id + "\nName:" + aEmployee.name + "\nSallary :"
                                + aEmployee.sallary);
                idTextBox.Clear();
                nameTextBox.Clear();
                salarryTextBox.Clear();
            }
        else
            {
                MessageBox.Show("Please enter values");
            }

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployee.id;
            nameTextBox.Text = aEmployee.name;
            salarryTextBox.Text = Convert.ToString(aEmployee.sallary);

           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            idTextBox.Clear();
            nameTextBox.Clear();
            salarryTextBox.Clear();
           
        }
    }
}
