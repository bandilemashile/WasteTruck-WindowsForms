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
    public partial class NewDriver : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public NewDriver()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet.Driver' table. You can move, or remove it, as needed.
            //this.driverTableAdapter.Fill(this.wasteTruckDataSet.Driver);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            companyTextBox.Text = "";
            emailTextBox.Text = "";
            vehicleTextBox.Text = "";
            areaTextBox.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerHome home = new ManagerHome();
            this.Hide();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\\Users\Bandile Mashile\Desktop\WasteTruckForms\WasteTruckForms\WasteTruck.mdf;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("INSERT INTO Driver (id,name,surname,company,email,vehicle,area) VALUES (@id,@name, @surname ,@company ,@email ,@vehicle,@area) ", con);



            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@surname",surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@company", companyTextBox.Text);
            cmd.Parameters.AddWithValue("@email",emailTextBox.Text);
            cmd.Parameters.AddWithValue("@vehicle", vehicleTextBox.Text);
            cmd.Parameters.AddWithValue("@area", areaTextBox.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Driver "+nameTextBox.Text+" Added Sucessfully");
            con.Close();
            idTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            companyTextBox.Text = "";
           emailTextBox.Text = "";
           vehicleTextBox.Text = "";
            areaTextBox.Text = "";

            

        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wasteTruckDataSet);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
