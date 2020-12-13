using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace KhounthavyV2
{
    class API
    {

        private String conStr = "";

        public API()
        {
            AppSetting appSetting = new AppSetting();
            conStr = appSetting.GetConnStr("KhounthavyV2.Properties.Settings.KhounthavyConnectionString");
        }

        
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
                queryStr = "SELECT TOP 70 Pawn_id, Pawn_date, Pawn_exp, Prod_no, Prod_name, Prod_color"+
                    ", Pawn_amount_kip, Pawn_amount_bath, Pawn_status, Pawn_turnBa_date, Password, Cust_id, khon_ma_ao"+
                    " FROM Pawn_View ORDER BY Pawn_id DESC";
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

        public DataTable Login(String UserName,String Password)
        {
            String queryStr = "SELECT TOP 1 * FROM Users WHERE Users_name ='"+UserName+"' AND Users_pass = '"+Password+"' ";
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
                String id,String name, String lastname,String tel,String Vill,String Dist,String Prov,String Img,  byte[] ImageData
            )
        {

            String sqlQueryString = "INSERT INTO Customer VALUES('"+id+"',N'"+name+"',N'"+lastname+"','"+tel+"',N'"+
                Vill+"',N'"+Dist+"',N'"+Prov+"','"+Img+"',@Image)";
            
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Image",ImageData);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void InsertPawn
            (
                String id, DateTimePicker date,String no, String name, String color, String kipp, String bath, DateTimePicker exp, 
                String Cust_id, String User_id, String status, String turnDate, String password, String img,String type, String khon_ma_ao
            )
        {

            String sqlQueryString = "INSERT INTO Pawn VALUES('" + id + "','" + date.Value + "',N'" + no + "',N'" +
                name + "',N'" + color + "','" + kipp + "','" + bath + "','" + exp.Value + "','"+Cust_id+"','" +
                User_id+"',N'"+ status + "','" + turnDate + "',N'" + password + "','" + img + "',N'"+type+"','"+khon_ma_ao+"')";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateBarcodeImage()
        {
            String ImagePath = Directory.GetCurrentDirectory() + @"\barcode.jpg";
            byte[] content = ImageToStream(ImagePath);

            String SqlQueryString = "UPDATE Barcode_image SET bar_img = @img";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(SqlQueryString, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@img", content);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void InsertBarcodeImage()
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
            String ImagePath = Directory.GetCurrentDirectory() + @"\barcode.jpg";
            byte[] content = ImageToStream(ImagePath);

            String SqlQueryString = "INSERT INTO Barcode_image (bar_id,bar_img) VALUES('BC00001',@img)";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(SqlQueryString, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@img", content);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private byte[] ImageToStream(string imagePath)
        {
            MemoryStream stream = new MemoryStream();
             tryagain:
            try
            {
                Bitmap image = new Bitmap(imagePath);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch 
            {
                goto tryagain;
            }

            return stream.ToArray();
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
                String id, String name, String lastname, String tel, String Vill, String Dist, String Prov, String Img, byte[] ImageData
            )
        {
            String sqlQueryString = "UPDATE Customer SET Cust_name=N'" + name + "', Cust_lastname=N'" + lastname +
                "', Tel='" + tel + "', Village=N'" + Vill + "', District=N'" + Dist + "', Province=N'"+Prov+
                "',Image='"+Img+"', Image_Pic=@Image WHERE Cust_id='"+id+"' ";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Image", ImageData);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public DataTable LoadPawn(String searchKeyWord)
        {
            String queryStr = "SELECT TOP (100) *" +
                " FROM Pawn_view WHERE Pawn_id = '" + searchKeyWord + "' ORDER BY Pawn_id DESC";

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

        public DataTable PawnSearch(String searchKeyWord)
        {
            String queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,"+
                "Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password, Cust_id, khon_ma_ao" +
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

        public DataTable PawnSearchByCustomer(String cust_id)
        {
            String queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip," +
                "Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password, Cust_id, khon_ma_ao" +
                " FROM Pawn_view WHERE Cust_id like '%" + cust_id  + "%' ORDER BY Pawn_id DESC";

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

        public DataTable LoadCustomerFromPawn(String Cust_id)
        {

            String queryStr = "SELECT TOP (50) Cust_id,Cust_name,Cust_lastname,Tel,Village,District,Province,Image_Pic" +
                " FROM Customer WHERE Cust_id = '" + Cust_id + "' ORDER BY Cust_id DESC";

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
                queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,"+
                "Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password, Cust_id, khon_ma_ao" +
                 " FROM Pawn_view WHERE Pawn_date BETWEEN '" + start + "' AND '" + end + "' ORDER BY Pawn_id DESC";
            }
            else
            {
                queryStr = "SELECT TOP (100) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,"+
                    "Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password, Cust_id, khon_ma_ao" +
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

        public void TurnBack(String id, String khon_ma_ao)
        {
            DateTime dateTime = DateTime.Now;
            String sqlQueryString = "UPDATE Pawn SET Pawn_status=N'ສົ່ງເຄື່ອງຄືນ', khon_ma_ao='"+khon_ma_ao+
                "', Pawn_turnBa_date='"+dateTime+"' WHERE Pawn_id='" + id + "' ";

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(sqlQueryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void BackUp(String savePath)
        {
            String queryStr = @"BACKUP DATABASE Khounthavy TO DISK = '"+savePath+"'";
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void Restore(String restorePath)
        {
            String queryStr = @"RESTORE DATABASE Khounthavy FROM DISK = '"+ restorePath+"'";
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = conStr;
            sqlConnection.Open();

            sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public byte[] ConvertImageToByte(PictureBox PicImg)
        {
            ImageConverter imageConverter = new ImageConverter();
            Byte[] ImageData = (Byte[])imageConverter.ConvertTo(PicImg.Image, Type.GetType("System.Byte[]"));

            return ImageData;
        }

        public void ReSaveImage(PictureBox PicImg){
            using (var fbd = new SaveFileDialog())
            {
                fbd.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|All files (*.*)|*.*";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        PicImg.Image.Save(fbd.FileName);
                        MessageBox.Show("Success...");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }



}
