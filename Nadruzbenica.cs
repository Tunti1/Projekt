using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projekt
{
    public partial class Narudzbenica : Form
    {

        private const string ConnectionString = @"Data Source=DESKTOP-71KF32U;Initial Catalog=Baza;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(ConnectionString);
        public Narudzbenica()
        {
            InitializeComponent();
            popuni_combo();
        }

       

        private void Izlaz(object sender, EventArgs e)
        {
            this.Hide();
            Servis otvori = new Servis();
            otvori.Show();
        }

        private void Stvori_novog(object sender, EventArgs e)
        {
            this.Hide();
            Kooperant otvori = new Kooperant();
            otvori.Show();
        }

        void popuni_combo()
        {
            con.Open();
            string izvadi = "select * from  Kooperant;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();

            
            while (citac.Read())
            {

                string Snaziv = citac.GetString(1);

                KomboKop.Items.Add(Snaziv);
            }
            con.Close();
        }

        private void Spremi_narudzbenicu(object sender, EventArgs e)
        {
            con.Open();
            string zadatak = "INSERT INTO Narudzbenica (Broj, Djelovi,Kooperant)  VALUES( " + this.Broj.Text + " ,'" + this.Djelovi.Text + "','" + this.KomboKop.Text.ToString() + "'); ";
            SqlCommand cmdnar = new SqlCommand(zadatak, con);

            cmdnar.ExecuteNonQuery();


            con.Close();

        }
    }
        
        
        
            

    
                




        
    
}
