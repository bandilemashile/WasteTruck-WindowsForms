using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WasteTruckForms
{
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet1.Maintenance' table. You can move, or remove it, as needed.
            this.maintenanceTableAdapter.Fill(this.wasteTruckDataSet1.Maintenance);

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

        private void maintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maintenanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wasteTruckDataSet1);

        }
    }
}
