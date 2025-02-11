using PlakDükkanıYöneticiModülü.Abstract_Repositories;
using PlakDükkanıYöneticiModülü.Abstract_Services;
using PlakDükkanıYöneticiModülü.Entities;
using PlakDükkanıYöneticiModülü.StaticMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDükkanıYöneticiModülü
{
    public partial class RegisterPage : Form
    {
        private readonly IYöneticiService _yöneticiService;
        private readonly IAlbumService _albumService;

        public RegisterPage(IYöneticiService yöneticiService,IAlbumService albumService)
        {
            InitializeComponent();
            _yöneticiService = yöneticiService;
            _albumService = albumService;
        }

        private bool ValidateControl(string password)
        {

            string pattern = @"^(?=.*[A-Z].*[A-Z])(?=.*[a-z].*[a-z].*[a-z])(?=.*[!:+*].*[!:+*]).{8,}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            return regex.IsMatch(password);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Yönetici yönetici=new Yönetici();
            
            if (_yöneticiService.GetAdminByUserName(txtUserName.Text)==null)
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
                {
                    if (ValidateControl(txtPassword.Text) == true)
                    {
                        yönetici.UserName = txtUserName.Text;
                        yönetici.Password = Sha256Hasher.ComputeSha256Hash(txtPassword.Text);
                        _yöneticiService.AddYönetici(yönetici);
                        MessageBox.Show("Başarıyla kaydedilmiştir");
                        Form loginForm = new Form1(_yöneticiService,_albumService);
                        this.Hide();
                        loginForm.ShowDialog();
                    }
                    else
                    {

                        lblErrorMessage.Text = "Şifre kriterleri sağlamıyor.\n"+"Şifre en az 8 karakter uzunluğunda olmalı. \n"+" en az 2 büyük harf 3 küçük harfiçermeli\n"+ "(!, :, +, *) bu karakterlerden en az  ikisini içermeli.";
                        lblErrorMessage.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lblErrorMessage.Text = "Passwords must match";
                    lblErrorMessage.ForeColor = Color.Red;
                }
               

            }else
            {
                lblErrorMessage.Text = "This username is already in use";
                lblErrorMessage.ForeColor = Color.Red;
            }
        }
    }
}
