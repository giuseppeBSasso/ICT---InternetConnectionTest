using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chama projeto 
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDados userDados = new UserDados();

        //Informações de user
        private int IdUser;
        private string FirstName;
        private string Password;
        private string LastName;
        private string Position;
        private string Email;

        //Constructors
        public UserModel(int idUser, string password, string firstName, string lastName, string position, string email)
        {
            this.IdUser = idUser;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Email = email;
        }

        public UserModel()
        {

        }

        public string editUserProfile()
        {
            try
            {
                userDados.editProfile(IdUser, FirstName, Password, LastName, Email);
                LoginUser(FirstName, Password);
                return "Seu perfil foi atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Usuário já está registrado, tente outro!";
            }
        }

        public bool LoginUser(string user, string password)
        {
            return userDados.Login(user, password);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDados.recoverPassword(userRequesting);
        }

        //Permissão de acesso OBS: pontos de melhoria
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
