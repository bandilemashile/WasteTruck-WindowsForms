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
    public partial class AddSchedule : Form
    {


        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public AddSchedule()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerHome home = new ManagerHome();
            this.Hide();
            home.Show();
        }

        private void scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wasteTruckDataSet);

        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wasteTruckDataSet.Schedule' table. You can move, or remove it, as needed.
           // this.scheduleTableAdapter.Fill(this.wasteTruckDataSet.Schedule);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bandile Mashile\Desktop\WasteTruckForms\WasteTruckForms\WasteTruck.mdf;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("INSERT INTO Schedule (Start,Finish,Duration,Area,Houses) VALUES (@Start, @Finish ,@Duration ,@Area ,@Houses) ", con);



            cmd.Parameters.AddWithValue("@Start", startTextBox.Text);
            cmd.Parameters.AddWithValue("@Finish", finishTextBox.Text);
            cmd.Parameters.AddWithValue("@Duration", durationTextBox.Text);
            cmd.Parameters.AddWithValue("@Area", areaTextBox.Text);
            cmd.Parameters.AddWithValue("@Houses", housesTextBox.Text);
           


            cmd.ExecuteNonQuery();

            MessageBox.Show("Schedule Added Sucessfully");
        }
    }
}
