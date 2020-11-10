using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace WasteTruckForms
{
    public partial class AddMaintenance : Form
    {

        SqlCommand cmd;
        SqlConnection con;

        public AddMaintenance()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerHome home = new ManagerHome();
            this.Hide();
            home.Show();
        }

        private void maintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maintenanceBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.wasteTruckDataSet1);

        }

        private void AddMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet1.Maintenance' table. You can move, or remove it, as needed.
           // this.maintenanceTableAdapter1.Fill(this.wasteTruckDataSet1.Maintenance);
            // TODO: This line of code loads data into the 'wasteTruckDataSet.Maintenance' table. You can move, or remove it, as needed.
           // this.maintenanceTableAdapter.Fill(this.wasteTruckDataSet.Maintenance);

        }

        private void brandLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_ServiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void vehicleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bandile Mashile\Desktop\WasteTruckForms\WasteTruckForms\WasteTruck.mdf;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("INSERT INTO Maintenance (Vehicle,Brand,Model,Cost,Duration,LastService) VALUES (@Vehicle, @Brand ,@Model ,@Cost ,@Duration,@LastService) ", con);



            cmd.Parameters.AddWithValue("@Vehicle", vehicleTextBox.Text);
            cmd.Parameters.AddWithValue("@Brand", brandTextBox.Text);
            cmd.Parameters.AddWithValue("@Model", modelTextBox.Text);
            cmd.Parameters.AddWithValue("@Cost", costTextBox.Text);
            cmd.Parameters.AddWithValue("@Duration", durationTextBox.Text);
            cmd.Parameters.AddWithValue("@LastService", lastServiceTextBox.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Maintenance Added Sucessfully");
        }

        private void vehicleTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
