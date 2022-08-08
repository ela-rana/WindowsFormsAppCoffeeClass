using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCoffeeClass
{
    public partial class Form1 : Form
    {
        List<Coffee> orders = new List<Coffee>(); //to create a list of coffee orders and initialize it
        Coffee currentOrder = new Coffee(); //to create a temporary object to hold the current entered Coffee order
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridOrders.DataSource = orders; //to set the coffee orders list as the source to display in the datagridview


            comboCoffeeType.DataSource = Enum.GetValues(typeof(CoffeeTypes)); //to set possible values for the
                                                                              //combobox as all the possible values in the enum CoffeeTypes
            comboCoffeeType.SelectedIndex = 0;   //to select PlainLightRoasted by default
            comboSize.DataSource = Enum.GetValues(typeof(Size)); //to set possible values for the
                                                                 // combobox as all the possible values in the enum Size
            comboSize.SelectedIndex = 0; //to select Medium by default
            comboSize.DataSource = Enum.GetValues(typeof(HeatCategory)); //to set possible values for the
                                                                 // combobox as all the possible values in the enum 
            comboSize.SelectedIndex = 2; //to select Iced by default
            comboPump1.DataSource = Enum.GetValues(typeof(Flavors)); //to set possible values for the
                                                                     //combobox as all the possible values in the enum Flavors
            comboPump1.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
            comboPump2.DataSource = Enum.GetValues(typeof(Flavors)); //to set possible values for the
                                                                     //combobox as all the possible values in the enum Flavors
            comboPump2.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
            comboPump3.DataSource = Enum.GetValues(typeof(Flavors)); //to set possible values for the
                                                                     //combobox as all the possible values in the enum Flavors
            comboPump3.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
        }

        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to make all groupboxes visible when the user clicks the Open All menu choice
            groupCurrentOrders.Visible = true;
            groupDeleteOrders.Visible = true;
            groupNewCoffeOrder.Visible = true;

        }
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to make all groupboxes invisible when the user clicks the Close All menu choice
            groupCurrentOrders.Visible = false;
            groupDeleteOrders.Visible = false;
            groupNewCoffeOrder.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to close the app when the user presses the Exit Menu choice
            Application.Exit();
        }
        private void comboFlavorPumps_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentOrder.Pumps = comboFlavorPumps.SelectedIndex;
            switch(currentOrder.Pumps)
            {
                case 3:
                    labelPump3Flavor.Visible = true;
                    comboPump3.Visible = true;
                    labelPump2Flavor.Visible = true;
                    comboPump2.Visible = true;
                    labelPump1Flavor.Visible = true;
                    comboPump1.Visible = true;
                    break;
                case 2:
                    labelPump2Flavor.Visible = true;
                    comboPump2.Visible = true;
                    labelPump1Flavor.Visible = true;
                    comboPump1.Visible = true;
                    break;
                case 1:
                    labelPump1Flavor.Visible = true;
                    comboPump1.Visible = true;
                    break;
                case 0:
                    //labelPump1Flavor.Visible = false;
                    //labelPump2Flavor.Visible = false;
                    //labelPump3Flavor.Visible = false;
                    //comboPump1.Visible = false;
                    //comboPump2.Visible = false;
                    //comboPump3.Visible = false;
                    break;
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            currentOrder.BevSize = (Size)comboSize.SelectedIndex;
            currentOrder.DrinkTemperature = (HeatCategory)comboHotCold.SelectedIndex;

            if (currentOrder.WhippedCream.ToString() == "Yes")
                currentOrder.WhippedCream = true;
            else
                currentOrder.WhippedCream = false;

            

            orders.Add(currentOrder);
            RefreshData();

        }

        /// A method to reset selected index for all fields and to refresh the datagrid 
        /// with most current number of records
        /// </summary>
        private void RefreshData()
        {
            comboCoffeeType.SelectedIndex = 0;   //to select PlainLightRoasted by default
            comboSize.SelectedIndex = 0; //to select Medium by default
            comboSize.SelectedIndex = 2; //to select Iced by default
            comboPump1.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
            comboPump2.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
            comboPump3.SelectedIndex = 0;   //to set the additional pumps as none (index 0) by default
            gridOrders.DataSource = orders; //to set the coffee orders list as the source to display in the datagridview
            labelPump1Flavor.Visible = false;
            labelPump2Flavor.Visible = false;
            labelPump3Flavor.Visible = false;
            comboPump1.Visible = false;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (orders.Count != 0)    //As long as the students list is not blank
            {
                orders.RemoveAt(gridOrders.CurrentRow.Index);   //the record at the selected row is deleted
                RefreshData();  //then the datagrid is refreshed
            }
            else
            {
                MessageBox.Show("There are no records to delete."); //if the students list is blank and the 
                                         //delete record button is clicked, this error message is displayed
            }
        }

        private void comboCoffeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentOrder.CoffeeType = (CoffeeTypes)comboCoffeeType.SelectedIndex;
            textBoxTotal.Text = currentOrder.TotalPrice.ToString();
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTotal.Text = currentOrder.TotalPrice.ToString();
        }
    }
}