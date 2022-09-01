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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Evakuacija.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();
        OleDbDataReader SetPodataka = null;

        public class EvMesto
        {
            public int SifEM;
            public string Naziv;
            public string DatumEvakuacije;
            public string BrojStanovnika;

            public EvMesto(OleDbDataReader SetPodataka)
            {
                this.SifEM = SetPodataka.GetInt32(0);
                this.Naziv = SetPodataka.GetString(1);
                this.DatumEvakuacije = SetPodataka.GetString(2);
                this.BrojStanovnika = SetPodataka.GetString(3);
            }
            public override string ToString()
            {
                return Naziv + " " + DatumEvakuacije + " " + BrojStanovnika;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                ucitaj();
            }
        }
        private void ucitaj()
        {
            Lista.Items.Clear();
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();
            Komanda.Connection = Konekcija;
            Komanda.CommandType = CommandType.Text;
            string sqlupit = "SELECT * FROM EvMesto";
            if (pretraga.Text != "")
            {
                sqlupit += " WHERE Naziv LIKE '" + pretraga.Text + "%'";
            }
            Komanda.CommandText = sqlupit;
            SetPodataka = Komanda.ExecuteReader();

            EvMesto EvMesto1;
            while (SetPodataka.Read())
            {
                EvMesto1 = new EvMesto(SetPodataka);
                Lista.Items.Add(EvMesto1);
            }
            SetPodataka.Close();
            Konekcija.Close();
        }

        private void Nov_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            ucitaj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex >= 0)
            {
                Form3 frm = new Form3();
                EvMesto EvMesto1 = (EvMesto)Lista.Items[Lista.SelectedIndex];
                frm.SifEM.Text = EvMesto1.SifEM.ToString();
                frm.Naziv.Text = EvMesto1.Naziv;
                frm.DatumEvakuacije.Text = EvMesto1.DatumEvakuacije;
                frm.BrojStanovnika.Text = EvMesto1.BrojStanovnika.ToString();
                frm.ShowDialog();
                ucitaj();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucitaj();
        }


    }
}
