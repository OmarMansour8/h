using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication3
{
    public partial class adduser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
                string strinsert = String.Format("INSERT INTO Members VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", fnameTB.Text, LastNameTB.Text, EmailTB.Text, PhoneNUmbaertB.Text, usernameTB.Text, passwordTB.Text, AddressTB.Text);

                SqlCommand cmdinsert = new SqlCommand(strinsert, conn);
                conn.Open();
                cmdinsert.ExecuteNonQuery();
                conn.Close();




                lbl.Text = "Welcome " + fnameTB.Text + " your account has been created succefully";
            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                {
                    lbl.Text = "The Username " + usernameTB.Text + "  already exists";
                }
                //else
                //{
                //    lblMsg.Text = "Database problem , Please try again later ";
                //}
            }
            catch
            {
                lbl.Text = "Sorry, the system is not available at the moment , please try again later";
            }

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
                string strinsert = String.Format("INSERT INTO Members VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", fnameTB.Text, LastNameTB.Text, EmailTB.Text, PhoneNUmbaertB.Text, usernameTB.Text, passwordTB.Text, AddressTB.Text);

                SqlCommand cmdinsert = new SqlCommand(strinsert, conn);
                conn.Open();
                cmdinsert.ExecuteNonQuery();
                conn.Close();




                lbl.Text = "Welcome " + fnameTB.Text + " your account has been created succefully";
            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                {
                    lbl.Text = "The Username " + usernameTB.Text + "  already exists";
                }
                //else
                //{
                //    lblMsg.Text = "Database problem , Please try again later ";
                //}
            }
            catch
            {
                lbl.Text = "Sorry, the system is not available at the moment , please try again later";
            }

        }
    }
}