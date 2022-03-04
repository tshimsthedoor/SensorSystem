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
            string sqlQuery = "INSERT INTO SENSOR(SensorName, SensorType) VALUES (@sensorname, @sensortype)";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            var sensorNameParameter = new SqlParameter("sensorname", System.Data.SqlDbType.VarChar)
            {
                Value = txtSensorName.Text
            };
            cmd.Parameters.Add(sensorNameParameter);

            var sensorTypeParameter = new SqlParameter("sensortype", System.Data.SqlDbType.VarChar)
            {
                Value = txtSensorType.Text
            };
            cmd.Parameters.Add(sensorTypeParameter);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
