using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebappTestSQLConnectivity
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bConnect_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder.ApplicationName = "SQL Connectivity Test";
            SqlConnectionStringBuilder.DataSource = tServer.Text;
            SqlConnectionStringBuilder.UserID = tUser.Text;
            SqlConnectionStringBuilder.Password = tPassword.Text;
            SqlConnectionStringBuilder.ConnectTimeout = 5;

            SqlConnection SqlConnection = new SqlConnection(SqlConnectionStringBuilder.ConnectionString);

            string SQLquery = "SELECT @@SERVERNAME + ' - ' + @@VERSION AS RESULT";

            SqlCommand SqlCommand = new SqlCommand(SQLquery, SqlConnection);
            SqlCommand.CommandTimeout = 5;

            try
            {
                SqlConnection.Open();
                string Result = SqlCommand.ExecuteScalar().ToString();
                tResult.ForeColor = System.Drawing.Color.Black;
                tResult.Text = Result;
            }
            catch (Exception ex)
            {
                tResult.ForeColor = System.Drawing.Color.Red;
                tResult.Text = ex.ToString();
                
            }
            finally
            {
                if (SqlConnection.State != ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }


        }
    }
}