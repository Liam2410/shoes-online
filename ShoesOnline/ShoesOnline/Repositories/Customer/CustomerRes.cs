using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ShoesOnline.Const;
using ShoesModel = ShoesOnline.Models.Customer.Shoes;

namespace ShoesOnline.Repositories.Customer
{
    public class CustomerRes
    {
        public static List<ShoesModel> GetAllShoes()
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = "SELECT * FROM Shoes";

            SqlCommand command = new SqlCommand(queryString, connection);

            var result = command.ExecuteReader();

            // Kiểm tra có kết quả trả về
            if (result.HasRows)
            {
                List<ShoesModel> shoesList = new List<ShoesModel>();

                while (result.Read())
                {
                    ShoesModel shoes = new ShoesModel();
                    shoes.ID = int.Parse(result["ID"].ToString());
                    shoes.Name = result["Name"].ToString();
                    shoes.Type = result["Type"].ToString();
                    shoes.Price = int.Parse(result["Price"].ToString());
                    shoes.Quantity = int.Parse(result["Quantity"].ToString());
                    shoes.Desciption = result["Desciption"].ToString();
                    shoes.ImagePath = result["ImagePath"].ToString();

                    shoesList.Add(shoes);
                }
                return shoesList;
            }
            return new List<ShoesModel>();
        }

        public static ShoesModel GetShoesById(int ID)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();

            string queryString = "SELECT * FROM Shoes WHERE ID = @ID";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ID", ID);
            
            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                //Phải dùng while như bên dưới mới đọc được dữ liệu trong result
                while (result.Read())
                {
                    ShoesModel shoes = new ShoesModel();
                    shoes.ID = (int) result["ID"];
                    shoes.Name = result["Name"].ToString();
                    shoes.Type = result["Type"].ToString();
                    shoes.Price = int.Parse(result["Price"].ToString());
                    shoes.Quantity = int.Parse(result["Quantity"].ToString());
                    shoes.Desciption = result["Desciption"].ToString();
                    shoes.ImagePath = result["ImagePath"].ToString();

                    return shoes;
                }
            }
            return new ShoesModel();
        }
    }
}
