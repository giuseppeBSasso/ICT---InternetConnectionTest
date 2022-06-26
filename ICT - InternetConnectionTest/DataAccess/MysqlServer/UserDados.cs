using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chamando BD MYSQL
using MySql.Data.MySqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDados:ConnectionToMysql
    {

        //Metodo Editar Perfil
        public void editProfile(int id, string user, string password, string lastname, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update user set " +
                        "FirstName=@FirstName, Password=@Password, LastName=@user, Email=@Email where IdUser=@IdUser";
                    command.Parameters.AddWithValue("@FirstName", user);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@IdUser", id);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo Iniciar Cessão
        public bool Login(String user, String password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from user where FirstName=@FirstName and Password=@Password";
                    command.Parameters.AddWithValue("@FirstName", user);
                    command.Parameters.AddWithValue("@Password", password); 
                    command.CommandType = System.Data.CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(1);
                            UserLoginCache.LastName = reader.GetString(2);
                            UserLoginCache.Password = reader.GetString(3);
                            UserLoginCache.Position = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                        }
                        return true;
                    }else
                    {
                        return false;
                    }
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();          
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from user where FirstName=@user or Email=@Email";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@Email", userRequesting);
                    command.CommandType = System.Data.CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(5);
                        string accountPassword = reader.GetString(3);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: solicitação de recuperação de senha!",
                            body:"Oi, "+userName+ "\nVocê pediu para recuperar sua senha!\n" +
                            "Sua senha atual é: "+accountPassword+
                            "\nNo entanto, solicitamos que altere sua senha \nimediatamente assim que entrar no sistema!",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Oi, " + userName + "\nVocê pediu para recuperar sua senha!\n" +
                            "Por favor cheque seu e-mail: " + userMail +
                            "\nNo entanto, solicitamos que altere sua senha \nimediatamente assim que entrar no sistema!";
                    }
                    else
                    {
                        return "Desculpe, você não tem uma conta com esse e-mail ou nome de usuário!";
                    }
                }
            }
        }

        //Permissão de acesso OBS: Pontos de melhoria
        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrador)
            {
                
            }
            if (UserLoginCache.Position == Positions.Visitante)
            {

            }
        }
    }
}
