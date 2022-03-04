using System;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            string sqlQuery = "INSERT INTO SENSOR(SensorName, SensorType) VALUES (" + "'" + txtSensorName.Text + "'" + "," + "'" + txtSensorType.Text + "'" + ")";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
