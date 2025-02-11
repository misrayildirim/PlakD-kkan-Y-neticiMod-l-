using PlakDükkanıYöneticiModülü.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Abstract_Services
{
    public interface IYöneticiService
    {
        void AddYönetici(Yönetici yönetici);
        Yönetici Login(string username,string password);
        Yönetici GetAdminByUserName (string userName);
       
       
    }
}
