using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Evakuacija
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Evakuacija.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija; 
        OleDbCommand Komanda = new OleDbCommand(); 
        OleDbDataReader SetPodataka = null;

        public class Skloniste
        {
            public int SifSK;
            public string Naziv;
            public string Kapacitet;
           
            public Skloniste(OleDbDataReader SetPodataka)
            {
                this.SifSK = SetPodataka.GetInt32(0);
                this.Naziv = SetPodataka.GetString(1);
                this.Kapacitet = SetPodataka.GetString(2);
               
            }
            public override string ToString()
            {
                return  SifSK + "           " + Naziv + "          " + Kapacitet;
            }
        }
        private void ucitaj()
        {
            Lista1.Items.Clear();//brisanje liste za slučaj da je nešto ispisano
            Konekcija = new OleDbConnection(StringKonekcije);/*Kreiranje instance klase*/
            Konekcija.Open();/*Otvaranje baze podataka*/
            Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
            Komanda.CommandType = CommandType.Text;/*Tip komande*/
            string sqlupit = "SELECT * FROM Skloniste";

            if (pretraga.Text != "")
            {
                sqlupit += " WHERE Naziv LIKE '" + pretraga.Text + "%'";
            }

            Komanda.CommandText = sqlupit;
            SetPodataka = Komanda.ExecuteReader();/*Izvršavanje komande, SetPodataka će biti popunjen*/
            Skloniste Skloniste1;
            while (SetPodataka.Read())//Čita jedan po jedna red, sve dok ima redova Read() metod vraća True
            {
                Skloniste1 = new Skloniste(SetPodataka);
                Lista1.Items.Add(Skloniste1);//ListBox kontrola se popunjava instancama klase kupac
            }
            SetPodataka.Close();
            Konekcija.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Lista1.SelectedIndex >= 0)
            {
                Form6 frm = new Form6();
                Skloniste Skloniste1 = (Skloniste)Lista1.Items[Lista1.SelectedIndex];
                frm.SifSK.Text = Skloniste1.SifSK.ToString();
                frm.Naziv.Text = Skloniste1.Naziv;
                frm.Kapacitet.Text = Skloniste1.Kapacitet.ToString();
                frm.ShowDialog();
                ucitaj();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
            ucitaj();
        }
           


    }
}
