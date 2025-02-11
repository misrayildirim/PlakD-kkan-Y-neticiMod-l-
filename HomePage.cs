using PlakDükkanıYöneticiModülü.Abstract_Services;
using PlakDükkanıYöneticiModülü.Entities;
using PlakDükkanıYöneticiModülü.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDükkanıYöneticiModülü
{
    public partial class HomePage : Form
    {
        private readonly IAlbumService _albumService;
        Album selectedalbum;

        public HomePage(IAlbumService albumService)
        {
            InitializeComponent();
            _albumService = albumService;
            LoadAlbums();
        }
        private void LoadAlbums()
        {
            dgvAlbums.DataSource = _albumService.GetAllAlbums();
            dgvAlbums.Columns["Id"].Visible = false;
        }
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Name = txtAlbumName.Text;
            album.Artist = txtArtistorGroup.Text;
            album.ReleaseDate = dtpReleaseDate.Value;
            album.Price = Convert.ToDecimal(txtPrice.Text) * (1 - Convert.ToDecimal(txtDiscountText.Text) / 100);
            album.DiscountRace = Convert.ToDecimal(txtDiscountText.Text);
            album.IsSale = rdSale.Checked ? SaleStatus.OnSale : SaleStatus.NotOnSale;
            album.CreatedTime = DateTime.Today;

            _albumService.AddAlbum(album);
            MessageBox.Show("Başarıyla eklenmiştir");
            LoadAlbums();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedalbum = (Album)dgvAlbums.SelectedRows[0].DataBoundItem;

            if (selectedalbum != null)
            {
                _albumService.DeleteAlbum(selectedalbum.Id);
                selectedalbum = null;
                MessageBox.Show("Başarıyla silinmiştir.");
                LoadAlbums();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçiniz");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedalbum = (Album)dgvAlbums.SelectedRows[0].DataBoundItem;
            if (selectedalbum != null)
            {
                if (!string.IsNullOrWhiteSpace(txtAlbumName.Text))
                {
                    selectedalbum.Name = txtAlbumName.Text;
                }

                if (!string.IsNullOrWhiteSpace(txtArtistorGroup.Text))
                {
                    selectedalbum.Artist = txtArtistorGroup.Text;
                }

                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    selectedalbum.Price = Convert.ToDecimal(txtPrice.Text);
                }

                if (!string.IsNullOrWhiteSpace(txtDiscountText.Text))
                {
                    selectedalbum.DiscountRace = Convert.ToDecimal(txtDiscountText.Text);
                }

                if (dtpReleaseDate.Value != null)
                {
                    selectedalbum.ReleaseDate = dtpReleaseDate.Value;
                }

                if (rdSale.Checked || rdIsNotSale.Checked)
                {
                    selectedalbum.IsSale = rdSale.Checked ? SaleStatus.OnSale : SaleStatus.NotOnSale;
                }

                _albumService.UpdateAlbum(selectedalbum.Id, selectedalbum);
                selectedalbum = null;
                MessageBox.Show("Başarı ile güncellenmiştir");
                LoadAlbums();
            }
        }

        private void btnListNotOnSale_Click(object sender, EventArgs e)
        {
            var notOnSaleAlbums = _albumService.GetAlbumsNotOnSale();

            var notOnSaleList = notOnSaleAlbums.Select(x => new
            {
                AlbumName = x.Name,
                ArtistorGroup = x.Artist
            }).ToList();
            dgvAlbums.DataSource = notOnSaleList;
        }

        private void btnListOnSale_Click(object sender, EventArgs e)
        {
            var onSaleAlbums = _albumService.GetAlbumsOnSale();
            var OnSaleList = onSaleAlbums.Select(x => new
            {
                AlbumName = x.Name,
                ArtistorGroup = x.Artist
            }).ToList();
            dgvAlbums.DataSource = OnSaleList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLastTenAlbum_Click(object sender, EventArgs e)
        {
            var lastTenAlbums = _albumService.GetLastTenAlbums();
            var lastTenAlbumsList = lastTenAlbums.Select(x => new
            {
                AlbumName = x.Name,
                ArtistorGroup = x.Artist
            }).ToList();
            dgvAlbums.DataSource = lastTenAlbumsList;
        }

        private void btnDiscountedAlbums_Click(object sender, EventArgs e)
        {
            var discounted = _albumService.GetDiscountedAlbums();
            var discountedAlbums = discounted.Select(x => new
            {
                AlbumName = x.Name,
                ArtistorGroup = x.Artist
            }).ToList();
            dgvAlbums.DataSource = discountedAlbums;

        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            var allAlbums=_albumService.GetAllAlbums();
            dgvAlbums.DataSource = allAlbums;
            dgvAlbums.Columns["Id"].Visible = false;

        }
    }
}
