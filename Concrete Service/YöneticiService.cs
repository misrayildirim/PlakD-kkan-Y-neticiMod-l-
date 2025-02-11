using Microsoft.VisualBasic.ApplicationServices;
using PlakDükkanıYöneticiModülü.Abstract_Repositories;
using PlakDükkanıYöneticiModülü.Abstract_Services;
using PlakDükkanıYöneticiModülü.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlakDükkanıYöneticiModülü.Concrete_Service
{
    public class YöneticiService : IYöneticiService
    {
        private readonly IGenericRepository<Yönetici> _repository;

        public YöneticiService(IGenericRepository<Yönetici> repository)
        {
            _repository = repository;
        }
        public void AddYönetici(Yönetici yönetici)
        {
            _repository.Add(yönetici);
        }

        public Yönetici GetAdminByUserName(string userName)
        {
            var admins = _repository.GetAll();

            var admin = admins.FirstOrDefault(x => x.UserName==userName);
            return admin;
        }

        public Yönetici Login(string username,string password)
        {
            var allUsers = _repository.GetAll();
            var userTryToLogin = allUsers.FirstOrDefault(x => x.UserName == username && x.Password == password);

            if (userTryToLogin != null)
            {
                return userTryToLogin;
            }
            else
            {
                return null;
            }
        }

       

       
    }
}
