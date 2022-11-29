
using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {

        CategoryRepository _cRep;

        public Form1()
        {
            InitializeComponent();
            _cRep = new CategoryRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstSonuc.DataSource = _cRep.GetAll();
        }

        private void ListCategories()
        {
            lstSonuc.DataSource = _cRep.GetActives();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            //Category c = new Category();
            //c.CategoryName = txtIsim.Text;
            //c.Description = txtDescription.Text;

            //_cRep.Add(c);


            _cRep.Add(new Category
            {
                CategoryName = txtIsim.Text,
                Description = txtDescription.Text
            });

            ListCategories();
        }

        Category c;

        private void lstSonuc_Click(object sender, EventArgs e)
        {
            if (lstSonuc.SelectedIndex > -1)
            {
                c = lstSonuc.SelectedItem as Category;
                txtIsim.Text = c.CategoryName;
                txtDescription.Text = c.Description;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                c.CategoryName = txtIsim.Text;
                c.Description = txtDescription.Text;
                _cRep.Update(c);
                ListCategories();
                c = null;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                _cRep.Delete(c);
                ListCategories();
                c = null;
            }
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            lstSonuc.DataSource = _cRep.GetPassives();
        }

        private void btnGuncellenen_Click(object sender, EventArgs e)
        {
            lstSonuc.DataSource = _cRep.GetModifieds();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {

        }
    }
}
