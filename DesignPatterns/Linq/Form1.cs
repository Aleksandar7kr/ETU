using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OopLabs.A;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             artists.DataSource = Album.GetAlbums()
                                        .OrderBy(album => album.Artist)
                                     .Select(album => album.Artist) 
                                     .Distinct()
                                     .ToList(); 
        }

        private void artists_SelectedIndexChanged(object sender, EventArgs e)
        {
            albums.DataSource = Album.GetAlbums()
                                    .Where(album => album.Artist == artists.SelectedItem.ToString())
                                    .OrderByDescending(album => album.Date)
                                    .Select(album => album.Title.ToString() + " (" + album.Date.ToShortDateString() + ")")
                                    .ToList(); 
        }

    }
}
