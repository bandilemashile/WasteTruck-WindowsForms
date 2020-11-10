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
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            this.Hide();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewDriver add = new NewDriver();
            this.Hide();
            add.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewVehicle vehicle = new NewVehicle();
            this.Hide();
            vehicle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMaintenance manager = new AddMaintenance();
            this.Hide();
            manager.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddSchedule schedule = new AddSchedule();
            this.Hide();
            schedule.Show();
        }
    }
}
