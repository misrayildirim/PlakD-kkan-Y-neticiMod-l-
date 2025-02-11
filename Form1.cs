using Microsoft.VisualBasic.ApplicationServices;
using PlakDükkanıYöneticiModülü.Abstract_Services;
using PlakDükkanıYöneticiModülü.StaticMethods;

namespace PlakDükkanıYöneticiModülü
{
    public partial class Form1 : Form
    {
        private readonly IYöneticiService _yöneticiService;
        private readonly IAlbumService _albumService;

        public Form1(IYöneticiService yöneticiService,IAlbumService albumService)
        {
            InitializeComponent();
            _yöneticiService = yöneticiService;
            _albumService = albumService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var admin = _yöneticiService.Login(txtUsername.Text, Sha256Hasher.ComputeSha256Hash(txtPassword.Text));
            Form form = new HomePage(_albumService);
            form.ShowDialog();
            this.Hide();
        }

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new RegisterPage(_yöneticiService, _albumService);
            form.ShowDialog();
            this.Hide();
        }
    }
}
