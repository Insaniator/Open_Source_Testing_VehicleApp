using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_OpensourcetestingCluster
{
    
    public partial class Form1 : Form
    {
        int CarLimit = 10;
        public Vehicle[] Vehicles = new Vehicle[10];
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Car_btn_Click(object sender, EventArgs e)
        {
            

            if (txtMakeYear.Text != "" && txtManufacturer.Text != "" && txtModel.Text != "" && txtRegistration.Text != "")
                
            {
               
                
                    if(counter <= CarLimit - 1)
                    {
                        Vehicle V = new Vehicle(counter + 1, txtManufacturer.Text, txtModel.Text, txtMakeYear.Text, txtRegistration.Text, 0, 0, 0, 0, 0);
                        Vehicles[counter] = V;
                        counter++;
                        lblResult.Text = "Successfully Added Vehicle.";
                    }
                    else
                    {
                        lblResult.Text = "Max amount of Vehicles Made.";
                    }
                   
            }
            else
            {
                lblResult.Text = "Please fill all text boxes!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_Front.Items.Clear();

            int list = 0;
            
            if (counter > 1)
            {


                do
                {
                    list_Front.Items.Add($"Vehicle Id: {list + 1}.   Model: {Vehicles[list].Model()}, Manfucturer: {Vehicles[list].Manufactorur()}, Year: {Vehicles[list].Make_year()}, Registration: {Vehicles[list].Registration()}, Kilometres: {Vehicles[list].Km_Travelled()}, Total Services: {Vehicles[list].total_Services}, Fuel Economy: {Vehicles[list].Fuel_Economy()}L/100Km, Total Revenue: {Vehicles[list].revenue_earned}, Kilometres Since Service: {Vehicles[list].kilo_service}. Requires Service: {Vehicles[list].Requires_Service()}.");
                    list++;

                } while (list != counter);
            }
            else
            {

            }
        }

        private void list_Front_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rent_Distance_btn_Click(object sender, EventArgs e)
        {
            int car_id;
            double distance, fuel;
            if(int.TryParse(txt_DistanceId.Text, out car_id) && double.TryParse(txt_DistanceRented.Text, out distance) && double.TryParse(txt_perkmFuel.Text, out fuel))
            {
                
                PerKmRental JD = new PerKmRental(car_id, distance, fuel);
                if (Vehicles[car_id].Requires_Service() == false)
                {
                    Vehicles[car_id - 1].kilometres_Travelled = Vehicles[car_id - 1].kilometres_Travelled + JD.Distance_Travelled();
                    Vehicles[car_id - 1].kilo_service = Vehicles[car_id - 1].kilo_service + JD.Distance_Travelled();
                    Vehicles[car_id - 1].fuel_tank = fuel;

                    list_Front.Items.Clear();
                    list_Front.Items.Add($"Vehicle: {Vehicles[car_id - 1].Model()}   Rented for: {JD.Distance_Travelled()} Kms.    Costing: ${JD.Price()}. Using: {JD.Fuel_used()} Litres of Fuel.");
                }
                else
                {
                    lblResult.Text = "This selected car requires service before it can be rented again.";
                }
            }
            else
            {
                lblResult.Text = "Please insert proper Data.";
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            int car_id;
            double distance, Days, Fuel;
            if (int.TryParse(txt_DaysRented_Vehicle.Text, out car_id) && double.TryParse(txt_DaysRented.Text, out distance) && double.TryParse(txt_DistanceTravelled_Days.Text, out Days) && double.TryParse(txt_perDayFuel.Text, out Fuel))
            {

                PerDayRental FD = new PerDayRental(car_id, distance, Days, Fuel);
                if (Vehicles[car_id - 1].Requires_Service() == false)
                {
                    Vehicles[car_id - 1].kilometres_Travelled = Vehicles[car_id - 1].kilometres_Travelled + FD.Distance_Travelled();
                    Vehicles[car_id - 1].kilo_service = Vehicles[car_id - 1].kilo_service + FD.Distance_Travelled();
                    Vehicles[car_id - 1].fuel_tank = Fuel;

                    list_Front.Items.Clear();
                    list_Front.Items.Add($"Vehicle: {Vehicles[car_id - 1].Model()}   Rented for: {FD.days_rented} Days.      Travelling: {FD.Distance_Travelled()} Kms.     Costing: ${FD.Price()}. Using: {FD.Fuel_Used()} Litres of Fuel.");
                }
                else
                {
                    lblResult.Text = "This selected car requires service before it can be rented again.";
                }
            }
            else
            {
                lblResult.Text = "Please insert proper Data.";
            }
        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            int Vehicle_Id;
            if (int.TryParse(txt_Vehicle_Id.Text, out Vehicle_Id) && Water_Check.Checked && Oil_Check.Checked && Rear_Lights_Check.Checked && Fornt_Lights_Check.Checked && Indicators_Check.Checked && Windscreen_Check.Checked)
            {
                Vehicles[Vehicle_Id - 1].kilo_service = 0;
                Vehicles[Vehicle_Id - 1].total_Services++;
                MessageBox.Show("Vehicle service Complete.");
                lblResult.Text = "Vehicle has been completely serviced.";
            }
            else
            {
                MessageBox.Show("Please pick a correct Vehicle and Check all requirements!");
            }
        }
    }
}
