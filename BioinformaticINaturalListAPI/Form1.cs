using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;
using System.Diagnostics;

namespace BioinformaticINaturalListAPI
{
    public partial class frm_InaturalList : Form
    {
        string uri = "";
        int c = 0;
        List<INaturalResponseObs> respuesta = null;
        public frm_InaturalList()
        {
            InitializeComponent();
        }

        private void frm_InaturalList_Load(object sender, EventArgs e)
        {
            //especie de prueba
            //txtEspecie.Text = "Allobates Femoralis";
            lblResultado.Visible = false;
            btnAnterior.Visible = false;
            btnSigueinte.Visible = false;
            btnPrimero.Visible = false;
            btnUltimo.Visible = false;
        }
        private static List<INaturalResponseObs> MakeRequestINaturalObservation(string requestUrl)
        {
            
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));
                    var str = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    var jsonResponse = JsonConvert.DeserializeObject<List<INaturalResponseObs>>(str);
                    return jsonResponse;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            searchSpecies();
            
        }
        private void searchSpecies()
        {
            if (txtEspecie.Text != null && txtEspecie.Text != "")
            {
                string UrlRequest = "https://www.inaturalist.org/observations.json?taxon_name=" + txtEspecie.Text;
                respuesta = MakeRequestINaturalObservation(UrlRequest);
                c = 0;
                if (respuesta.Count > 1)
                {
                    lblResultado.Visible = true;
                    btnAnterior.Visible = true;
                    btnSigueinte.Visible = true;
                    btnPrimero.Visible = true;
                    btnUltimo.Visible = true;
                }
                if (respuesta.Count > 0)
                    showSpecies();
                else
                {
                    this.pictureBox1.Image = global::BioinformaticINaturalListAPI.Properties.Resources.zelenyi_fon_model_zelenaia_stebel_liagushka_krasotka_fauna_1;
                    MessageBox.Show("Especie no encontrada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Ingrese una especie", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void loadImageFromUrl(string url)
        {
            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }
        private void showSpecies()
        {
            txtLatitud.Text = respuesta[c].latitude;
            txtLongitud.Text = respuesta[c].longitude;
            txtLocalidad.Text = respuesta[c].place_guess;
            txtFechaObservacion.Text = respuesta[c].observed_on;
            if (respuesta[c].photos.Count > 0)
            {
                photos aPhoto = new photos();
                aPhoto = respuesta[c].photos[0];
                loadImageFromUrl(aPhoto.large_url);
            }
            uri = respuesta[c].uri;
            lblResultado.Text = "Especies encontradas en INatural:" + respuesta.Count + ". Especie Mostrada "+(c+1);
        }

        private void btnINaturalVer_Click(object sender, EventArgs e)
        {
            Process.Start(uri);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (c > 0)
            {
                c--;
                showSpecies();
            }
        }

        private void btnSigueinte_Click(object sender, EventArgs e)
        {
            if (c < respuesta.Count-1)
            {
                c++;
                showSpecies();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            c = 0;
            showSpecies();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            c = respuesta.Count - 1;
            showSpecies();
        }

        private void txtEspecie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                searchSpecies();
            }
        }
    }
}
