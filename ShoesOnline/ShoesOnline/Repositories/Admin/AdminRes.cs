using CAIT.SQLHelper;
using ShoesOnline.Const;
using ShoesOnline.Models.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesOnline.Repositories.Admin
{
    public class AdminRes
    {
        public static List<Shoes> GetAll()
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            string queryString = "SELECT * FROM Shoes";

            SqlCommand command = new SqlCommand(queryString, connection);

            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                List<Shoes> lstShoes = new List<Shoes>();

                while (result.Read())
                {
                    Shoes shoes = new Shoes();

                    shoes.ID = int.Parse(result["ID"].ToString());
                    shoes.Name = result["Name"].ToString();
                    shoes.Type = result["Type"].ToString();
                    shoes.Size = int.Parse(result["Size"].ToString());
                    shoes.Price = int.Parse(result["Price"].ToString());
                    shoes.Quantity = int.Parse(result["Quantity"].ToString());
                    shoes.Desciption = result["Desciption"].ToString();
                    shoes.ImagePath = result["ImagePath"].ToString();

                    lstShoes.Add(shoes);
                }

                return lstShoes;
            }

            return new List<Shoes>();

        }

        public static bool InsertShoes(string name, string type, int size, int price, int quantity, string desciption)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"INSERT INTO Shoes (Name, Type, Size, Price, Quantity, Desciption)
                                    VALUES(@Name, @Type, @Size, @Price, @Quantity, @Desciption)";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@Size", size);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Desciption", desciption);

            var result = command.ExecuteNonQuery();
            // Kiểm tra có đã có dòng nào được thêm vào chưa
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateShoes(int ID, string name, string type, int size, int price, int quantity, string desciption)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"UPDATE Shoes SET Name = @Name, Type = @Type, Size = @Size, 
                                    Price = @Price, Quantity = @Quantity, Desciption = @Desciption Where ID = @ID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@Size", size);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Desciption", desciption);

            var result = command.ExecuteNonQuery();
            // Kiểm tra có đã có dòng nào được thêm vào chưa
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool RemoveShoes(int ID)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"DELETE FROM Shoes WHERE ID=@ID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ID", ID);

            var result = command.ExecuteNonQuery();

            if (result > 0)
            {
                return true;
            }
            return false;

        }

        public static Shoes GetShoes(int ID)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"SELECT * FROM Shoes WHERE ID=@ID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ID", ID);


            var result = command.ExecuteReader();

            if (result.HasRows)
            {

                while (result.Read())
                {
                    Shoes shoes = new Shoes();

                    shoes.ID = int.Parse(result["ID"].ToString());
                    shoes.Name = result["Name"].ToString();
                    shoes.Type = result["Type"].ToString();
                    shoes.Size = int.Parse(result["Size"].ToString());
                    shoes.Price = int.Parse(result["Price"].ToString());
                    shoes.Quantity = int.Parse(result["Quantity"].ToString());
                    shoes.Desciption = result["Desciption"].ToString();
                    shoes.ImagePath = result["ImagePath"].ToString();

                    return shoes;
                }

                
            }

            return null;

        }

    }
}
