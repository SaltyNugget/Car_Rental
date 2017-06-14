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

        //Vehicle Array
        Vehicle[] AllVehicles = new Vehicle[3];
        int cnt = 0;
        int i;
        double iDO;
       
        public Form1()
        {
           
            InitializeComponent();
        }


        
      
        //Insert Button
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Prevent Winform to crash if more than 3 vehicle are inserted
            if (cnt >= 3)
            {
                MessageBox.Show("You have insert the maximum number of vehicles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Add vehicle to listBox
            else
            {
                AllVehicles[cnt] = new Vehicle(txtManufacturer.Text, txtModel.Text, txtYear.Text, txtRegistration.Text);
                listBox1.Items.Add(AllVehicles[cnt].PrintToScreen2());
                cnt++;

            }
            //Clear all textboxes after clicking insert button
            txtManufacturer.Clear();
            txtModel.Clear();
            txtRegistration.Clear();
            txtYear.Clear();
        }












        //Travel Button
        private void btnTravel_Click(object sender, EventArgs e)
        {
            //Prevent Winform to crash if all 3 textboxes are not fill or if input type is a string 
            if (String.IsNullOrEmpty(txtKilometres.Text) || !int.TryParse(txtKilometres.Text, out i) || String.IsNullOrEmpty(txtFuelCost.Text) || !double.TryParse(txtFuelCost.Text, out iDO) || String.IsNullOrEmpty(txtFuelQtyPurchase.Text) || !double.TryParse(txtFuelQtyPurchase.Text, out iDO))
            {
                MessageBox.Show("Please fill all textboxes or check your input type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Prevent the user to add more information about vehicle if service needed
                if (AllVehicles[listBox1.SelectedIndex].IsServiceRequired() == true)
                {
                    MessageBox.Show("This Vehicle need to be serviced!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //Select Vehicle to add Kilometres Travelled
                    AllVehicles[listBox1.SelectedIndex].AddJourney((double)Convert.ToDouble(txtKilometres.Text));
                    //Select Vehicle to add Fuel qty and fuel cost to it's total revenue
                    AllVehicles[listBox1.SelectedIndex].AddFuelPurchase((double)Convert.ToDouble(txtFuelQtyPurchase.Text), (double)Convert.ToDouble(txtFuelCost.Text));
                }
            }

            txtFuelCost.Clear();
            txtFuelQtyPurchase.Clear();
            txtKilometres.Clear();
            


        }

       













        //............

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (richTextBox1 != null)
            {
                richTextBox1.Clear();
            }
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (AllVehicles[listBox1.SelectedIndex].IsServiceRequired() == true)
            { //Prevent the user to add more information about vehicle if service needed
                MessageBox.Show("This Vehicle need to be serviced!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                richTextBox1.SelectedText = (AllVehicles[listBox1.SelectedIndex].PrintToScreen());
            }
         
            
        }

       


        private void btnDayRental_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPerDayRental.Text) || !int.TryParse(txtPerDayRental.Text, out i))
            {
                MessageBox.Show("Please check your input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (AllVehicles[listBox1.SelectedIndex].IsServiceRequired() == true)
                {
                    //Prevent the user to add more information about vehicle if service needed
                    MessageBox.Show("This Vehicle need to be serviced!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //Select Vehicle to add Per Day Rental
                    AllVehicles[listBox1.SelectedIndex].AddPerDayRental((int)Convert.ToInt32(txtPerDayRental.Text));

                }
            }
            txtPerDayRental.Clear();
            
        }

        private void btnKmRental_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKmRental.Text) || !int.TryParse(txtKmRental.Text, out i))
            {
                MessageBox.Show("Please check your input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (AllVehicles[listBox1.SelectedIndex].IsServiceRequired() == true)
                {
                    //Prevent the user to add more information about vehicle if service needed
                    MessageBox.Show("This Vehicle need to be serviced!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //Select Vehicle to add Per Kilometres Rental
                    AllVehicles[listBox1.SelectedIndex].AddPerKmRental((double)Convert.ToDouble(txtKmRental.Text));
                }
            }
            txtKmRental.Clear();
        }

        private void btnServiceVehicle_Click(object sender, EventArgs e)
        {
            //Select vehicle in listbox to service it
            AllVehicles[listBox1.SelectedIndex].AddService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = AllVehicles[listBox1.SelectedIndex].PrintToScreen();
        }
    }
}
