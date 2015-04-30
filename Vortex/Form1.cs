using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.IO;

namespace Vortex
{
    public partial class Vortex : MetroForm
    {
        public Vortex()
        {
            InitializeComponent();
        }
        private void Vortex_Load(object sender, EventArgs e)
        {
            SearchEngine.Items.Add("Google");
            SearchEngine.Items.Add("Youtube");
            SearchEngine.Items.Add("Wikipedia");
            SearchEngine.SelectedIndex = 0;

            Browser.Navigate("http://google.fr");
        }

#region Boutons : Precedent, Suivant, Actualiser
        private void Precedent_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Browser.GoHome();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Browser.Stop();
        }
#endregion

#region Barre d'adresse

     private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            BarreAdresse.Text = Browser.Url.ToString(); // Renvoie l'adresse du site internet dans la barre d'adresse
            PageOnglet.SelectedTab.Text = Browser.DocumentTitle.ToString(); 
        }
#endregion

#region Barre de Recherche

// Barre de recherche integré dans la barre d'adresse
        private void BarreAdresse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Browser.Navigate(("https://google.fr/#q=" + BarreAdresse.Text));
                BarreAdresse.Text = "";
            }
        }
#endregion

#region Barre de recherche avec choix du moteur
        private void BarreRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            switch(SearchEngine.SelectedIndex)
            {
                case 0:
                    if (e.KeyCode == Keys.Enter)
                    {
                        Browser.Navigate("https://www.google.fr/#q=" + BarreRecherche.Text);
                    }
                break;
                case 1:
                    if (e.KeyCode == Keys.Enter)
                    {
                        Browser.Navigate("https://www.youtube.com/results?search_query="+ BarreRecherche.Text);
                    }
                break;
                case 2:
                     if (e.KeyCode == Keys.Enter)
                    {
                        Browser.Navigate("http://fr.wikipedia.org/wiki/"+ BarreRecherche.Text);
                    }
                break;
            }
        }
#endregion


#region Icone

        //public void Icone()
      //  {
      //     WebClient wc = new WebClient();
      //     Uri url1 = new Uri (Browser.Url.ToString()) ;
      //     MemoryStream ms = new MemoryStream(wc.DownloadData("http://" + url1.Host + "/favicon.ico"));
      //     Icon icone = new Icon(ms);

      //    if (imageList1.Images.Count == -1)
      //    {
      //        imageList1.Images.Add(icone.ToBitmap);
      //        PageOnglet.SelectedTab.ImageIndex == 0;

      //    }
      //    else
      //    {
      //        imageList1.Images.Clear();
      //        imageList1.Images.Add(icone.ToBitmap);
      //        PageOnglet.SelectedTab.ImageIndex == 0;
      //    }

      //  }


#endregion 


    }

}

