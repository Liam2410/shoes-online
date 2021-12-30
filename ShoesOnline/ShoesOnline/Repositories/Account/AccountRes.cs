using System;
using System.Data.SqlClient;
using ShoesOnline.Const;

using AccountModel = ShoesOnline.Models.Account.Account;

namespace ShoesOnline.Repositories.Account
{
    public class AccountRes
    {
        public static AccountModel CheckLogin(string emailOrPhone, string password)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();
            
            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"SELECT * FROM Account 
                                    WHERE Email = @Email AND Password = @Password
                                    OR Phone = @Phone AND Password = @Password";
            
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Email", emailOrPhone);
            command.Parameters.AddWithValue("@Phone", emailOrPhone);
            command.Parameters.AddWithValue("@Password", password);

            var result = command.ExecuteReader();
            // Kiểm tra có kết quả trả về
            if (result.HasRows)
            {
                //Phải dùng while như bên dưới mới đọc được dữ liệu trong result
                while (result.Read())
                {
                    AccountModel account = new AccountModel();
                    account.ID = (int) result["ID"];
                    account.Email = result["Email"].ToString();
                    account.Phone = result["Phone"].ToString();
                    account.Role = result["Role"].ToString();
                    account.Gender = result["Gender"].ToString();
                    account.Fullname = result["Fullname"].ToString();
                    account.AvatarPath = result["AvatarPath"].ToString();
                
                    return account;
                }
            }
            return null;
        }
        
        public static bool RegisterAccount(string email, string phone, string password, 
            string fullname, string gender)
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            connection.Open();
            
            //Xuống dòng thì dùng @ để tiếp tục nối chuỗi, nếu không dùng @ thì dùng + nối chuỗi cũng oke
            string queryString = @"INSERT INTO Account (Email, Phone, Password, FullName, Gender)
                                    VALUES(@Email, @Phone, @Password, @FullName, @Gender)";
            
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@FullName", fullname);
            command.Parameters.AddWithValue("@Gender", gender);
            
            var result = command.ExecuteNonQuery();
            // Kiểm tra có đã có dòng nào được thêm vài chưa
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}