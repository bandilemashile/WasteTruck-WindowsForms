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
    public partial class DriverHome : Form
    {
        public DriverHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            this.Hide();
            page.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
