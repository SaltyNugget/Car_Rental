using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Program;

namespace Vehicle_Program
{
    public partial class Form1 : Form
    {


        Vehicle[] AllVehicles = new Vehicle[3];
        int cnt = 0;


        public Form1()
        {

            InitializeComponent();
        }





        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cnt >= 3)
            {
                MessageBox.Show("Error you have insert the maximum number of vehicles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                AllVehicles[cnt] = new Vehicle(txtManufacturer.Text, txtModel.Text, txtYear.Text, txtRegistration.Text);
                listBox1.Items.Add(AllVehicles[cnt].PrintToScreen2());
                cnt++;

            }

            txtManufacturer.Clear();
            txtModel.Clear();
            txtRegistration.Clear();
            txtYear.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a vehicle first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            else
            {
                if (string.IsNullOrEmpty(txtKilometres.Text))
                {
                    MessageBox.Show("Field is empty!");
                }
                int parsedValue;
                if (!int.TryParse(txtKilometres.Text, out parsedValue))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }
                else
                {
                    Journey J1 = new Journey(Convert.ToInt32(txtKilometres.Text));
                    //Select item from listbox to add value
                    AllVehicles[listBox1.SelectedIndex].AddJourney(J1);
                    //then display to a messagebox

                    // listBox1.Items.Add(AllVehicles[listBox1.SelectedIndex].PrintToScreen());
                    richTextBox1.Text = AllVehicles[listBox1.SelectedIndex].PrintToScreen();
                }

            }
            //Clear textBox after clicking button
            txtKilometres.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = AllVehicles[listBox1.SelectedIndex].PrintToScreen();
        }

        private void btnServicing_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a vehicle first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txtKMServices.Text))
                {
                    MessageBox.Show("Field is empty!");
                }
                int parsedValue;
                if (!int.TryParse(txtKMServices.Text, out parsedValue))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }
                else
                {
                   Servicing V12 = new Servicing(Convert.ToInt32(txtKMServices.Text));
                    //Select item from listbox to add value
                    AllVehicles[listBox1.SelectedIndex].AddServicing(V12);
                    //then display to a messagebox

                    // listBox1.Items.Add(AllVehicles[listBox1.SelectedIndex].PrintToScreen());
                    richTextBox1.Text = AllVehicles[listBox1.SelectedIndex].PrintToScreen();
                }

            }
            //Clear textBox after clicking button
            txtKilometres.Clear();
        }
    }
    }



