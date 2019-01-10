using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class Servis : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-71KF32U;Initial Catalog=Baza;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(ConnectionString);
        public Servis()
        {
            InitializeComponent();
        }

        
        private void Izadji(object sender, EventArgs e)
        {
            this.Hide();
            Ulaz otvori = new Ulaz();
            otvori.Show();
        }

        private void Otvori_Narudzbenicu(object sender, EventArgs e)
        {
            this.Hide();
            Narudzbenica otvori = new Narudzbenica();
            otvori.Show();
        }

         void SpremiUredjaj(object sender, EventArgs e)
        {




            con.Open();

             
            string zadatak = "INSERT INTO Servis(Sifra,Marka,Model,Komponenta,Rok,Cijena,Potrebno_vrijeme)  VALUES("+this.Sifratxt.Text+" , ' "+this.MarkaTxt.Text+"' , '"+this.ModelTxT.Text+"', '"+this.KomponentaTxt.Text+ "' ,'"+this.RokKraj.Text+"' , "+this.CijenaTxtic.Text+" , "+this.Vrijeme.Text+" );";
            SqlCommand cmd = new SqlCommand (zadatak, con);
            
            cmd.ExecuteNonQuery();
            
            con.Close();

            this.Sifratxt.Text = " ";
            this.MarkaTxt.Text = " ";
            this.ModelTxT.Text = " ";
            this.KomponentaTxt.Text = " ";
            this.CijenaTxtic.Text = " ";
            this.Vrijeme.Text = " ";



        }

        

       
    }
}
