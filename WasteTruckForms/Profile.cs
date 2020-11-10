using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace WasteTruckForms
{
    public partial class Profile : Form
    {
      
        SqlConnection con;
        SqlDataAdapter da;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.wasteTruckDataSet.Driver);


           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DriverHome home = new DriverHome();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile driverProfile = new Profile();
            this.Hide();
            driverProfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            this.Hide();
            vehicle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schedules schedule = new Schedules();
            this.Hide();
            schedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Maintenance maintain = new Maintenance();
            this.Hide();
            maintain.Show();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wasteTruckDataSet);

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
