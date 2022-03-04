using System;
using System.Configuration;
using System.Data;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
           
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SaveSensor", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            string sensorName = txtSensorName.Text;
            string sensorType = txtSensorType.Text;

            cmd.Parameters.Add(new SqlParameter("@SensorName", sensorName));
            cmd.Parameters.Add(new SqlParameter("@SensorType", sensorType));
           
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
