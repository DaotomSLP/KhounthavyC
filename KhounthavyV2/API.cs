using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace KhounthavyV2
{
    class API
    {

        private String conStr = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Khounthavy;Integrated Security=True";
        SqlDataReader sqlDataReader;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        DataTable dt;

        public static String Current_user = "US000001"; 

        public DataTable LoadData(String Table)
        {
            String queryStr = "";
            if (Table == "Customer")
            {
                queryStr = "SELECT TOP 70 * FROM Customer ORDER BY Cust_id DESC";
            }
            else if(Table == "Pawn")
            {

            }
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dt = new DataTable();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            return dt;
        } 

        public String GetNewId(String Table)
        {
            String id = "e";
            String queryStr = "";
            Object resultScalar;
            String FirstChar = "";

            if (Table == "Customer")
            {
                FirstChar = "CM";
                queryStr = "SELECT MAX(Cust_id) FROM Customer";
            }
            else if (Table == "Pawn")
            {
                FirstChar = "PN";
                queryStr = "SELECT MAX(Pawn_id) FROM Pawn";
            }

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(queryStr, sqlConnection);
            resultScalar = sqlCommand.ExecuteScalar();

            String maxId = resultScalar.ToString();

            if (maxId == "")
            {

                id = FirstChar+"000001";

            }
            else
            {
                int maxId2 = Convert.ToInt32(maxId.Substring(2, maxId.Length - 2));
                if (maxId2 < 9)
                {
                    id = FirstChar + "00000" + (maxId2 + 1).ToString();
                }
                else if(maxId2 < 99)
                {
                    id = FirstChar + "0000" + (maxId2 + 1).ToString();
                }
                else if (maxId2 < 999)
                {
                    id = FirstChar + "000" + (maxId2 + 1).ToString();
                }
                else if (maxId2 < 9999)
                {
                    id = FirstChar + "00" + (maxId2 + 1).ToString();
                }
                else if (maxId2 < 99999)
                {
                    id = FirstChar + "0" + (maxId2 + 1).ToString();
                }
                else if (maxId2 >= 99999)
                {
                    id = FirstChar + (maxId2 + 1).ToString();
                }

            }

            sqlConnection.Close();

            return id;
        }

        public void InsertCustomer
            (
                String id,String name, String lastname,String tel,String Vill,String Dist,String Prov,String Img
            )
        {

            String sqlQueryString = "INSERT INTO Customer VALUES('"+id+"',N'"+name+"',N'"+lastname+"','"+tel+"',N'"+
                Vill+"',N'"+Dist+"',N'"+Prov+"','"+Img+"')";
            
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void InsertPawn
            (
                String id, DateTimePicker date,String no, String name, String color, String kipp, String bath, DateTimePicker exp, 
                String Cust_id, String User_id, String status, String turnDate, String password, String img,String type
            )
        {

            String sqlQueryString = "INSERT INTO Pawn VALUES('" + id + "','" + date.Value + "',N'" + no + "',N'" +
                name + "',N'" + color + "','" + kipp + "','" + bath + "','" + exp.Value + "','"+Cust_id+"','" +
                User_id+"',N'"+ status + "','" + turnDate + "',N'" + password + "','" + img + "',N'"+type+"')";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteCustomer(String id)
        {
            String sqlQueryString = "DELETE FROM Customer WHERE Cust_id='" + id + "'";
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateCustomer
            (
                String id, String name, String lastname, String tel, String Vill, String Dist, String Prov, String Img
            )
        {
            String sqlQueryString = "UPDATE Customer SET Cust_name=N'" + name + "', Cust_lastname=N'" + lastname +
                "', Tel='" + tel + "', Village=N'" + Vill + "', District=N'" + Dist + "', Province=N'"+Prov+
                "',Image='"+Img+"' WHERE Cust_id='"+id+"' ";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public DataTable PawnSearch(String searchKeyWord)
        {
            String queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img" +
                " FROM Pawn_view WHERE Pawn_id like '%" + searchKeyWord + "%' OR Prod_no like N'%" + searchKeyWord +
                "%' OR  Prod_name like N'%" + searchKeyWord + "' OR Cust_name like N'%" + searchKeyWord +
                "%' OR Cust_lastname like N'%" + searchKeyWord + "%' ORDER BY Pawn_id DESC";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dt = new DataTable();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            return dt;
        }

        public DataTable LoadCustomerFromPawn(String PawnId)
        {
            String queryStr = "SELECT TOP (50) Cust_id,Cust_name,Cust_lastname,Tel,Village,District,Province,Image" +
                " FROM Pawn_view WHERE Pawn_id = '" + PawnId + "' ORDER BY Cust_id DESC";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dt = new DataTable();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            return dt;
        }

        public DataTable SearchPawnByDate(String keyword, String start, String end)
        {
            String queryStr = "";
            if (keyword == "")
            {
                queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img" +
                 " FROM Pawn_view WHERE Pawn_date BETWEEN '" + start + "' AND '" + end + "' ORDER BY Pawn_id DESC";
            }
            else
            {
                queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img" +
                   " FROM Pawn_view WHERE (Pawn_id like '%" + keyword + "%' OR Prod_no like N'%" + keyword +
                   "%' OR  Prod_name like N'%" + keyword + "' OR Cust_name like N'%" + keyword +
                   "%' OR Cust_lastname like N'%" + keyword + "%') AND Pawn_date BETWEEN '" + start + "' AND '" + end +
                   "' ORDER BY Pawn_id DESC";
            }


            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dt = new DataTable();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            return dt;
        }
    }



}
