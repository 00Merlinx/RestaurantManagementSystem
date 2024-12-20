using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    internal class connectDB
    {
        public static readonly string conn_source = "Data Source=DESKTOP-NEE6ERU\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public static SqlConnection conn = new SqlConnection(conn_source);

        // Function to validate user login
        public static bool IsValidUser(string username, string pass)
        {
            bool IsValid = false;

            try
            {
                string qry = "SELECT * FROM admin WHERE username = @username AND pass = @pass";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            IsValid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return IsValid;
        }

        public static bool RegisterUser(string name, string username, string pass, string conpass)
        {
            bool isRegistered = false;

            try
            {
                string qry = @"INSERT INTO admin (Uname, username, pass, conpass, date_created) 
                       VALUES (@name, @username, @pass, @conpass, @date_created)";

                using (SqlConnection conn = new SqlConnection(conn_source)) // Use local connection
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@conpass", conpass);
                    cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        isRegistered = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    Console.WriteLine("Username already exists.");
                else
                    Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return isRegistered;
        }

        public static bool IsUsernameTaken(string username)
        {
            bool isTaken = false;

            try
            {
                string qry = "SELECT COUNT(*) FROM admin WHERE username = @username";

                using (SqlConnection conn = new SqlConnection(conn_source))
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        isTaken = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking username: {ex.Message}");
            }

            return isTaken;
        }

        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        //Crud
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                res = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            return res;
        }

        // For loading data from database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        public static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Bunifu.UI.WinForms.BunifuDataGridView gv = (Bunifu.UI.WinForms.BunifuDataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

    }

}
