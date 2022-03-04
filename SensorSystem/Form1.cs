using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SensorSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SensorSystem;Integrated Security=True;";
            string sqlQuery = "INSERT INTO SENSOR(SensorName, SensorType) VALUES (" + "'" + txtSensorName.Text + "'" + "," + "'" + txtSensorType.Text + "'" + ")";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
