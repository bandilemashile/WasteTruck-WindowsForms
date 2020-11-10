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
    public partial class NewVehicle : Form
    {

        SqlCommand cmd;
        SqlConnection con;

        public NewVehicle()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerHome home = new ManagerHome();
            this.Hide();
            home.Show();

        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.wasteTruckDataSet1);

        }

        private void NewVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet1.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter1.Fill(this.wasteTruckDataSet1.Vehicle);
            // TODO: This line of code loads data into the 'wasteTruckDataSet.Vehicle' table. You can move, or remove it, as needed.
            //this.vehicleTableAdapter.Fill(this.wasteTruckDataSet.Vehicle);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bandile Mashile\Desktop\WasteTruckForms\WasteTruckForms\WasteTruck.mdf;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("INSERT INTO Vehicle (id,Brand,Model,type,cost,miles) VALUES (@id, @Brand ,@Model ,@type ,@cost,@miles) ", con);



            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Parameters.AddWithValue("@Brand", brandTextBox.Text.ToString());
            cmd.Parameters.AddWithValue("@Model", modelTextBox.Text);
            cmd.Parameters.AddWithValue("@type",typeTextBox.Text);
            cmd.Parameters.AddWithValue("@cost", costTextBox.Text.ToString());
            cmd.Parameters.AddWithValue("@miles", milesTextBox.Text.ToString());


            cmd.ExecuteNonQuery();

            MessageBox.Show("\nVehicle Added Sucessfully");
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
