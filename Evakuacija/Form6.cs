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
    public partial class Form6 : Form
    {
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Evakuacija.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija; /*Deklaracija instance klase koja predstavlja konekciju na bazu*/
        OleDbCommand Komanda = new OleDbCommand();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Naziv.Text == "")
            {
                MessageBox.Show("Naziv moze da bude Mesto 1 ili Mesto 2 ");
                Naziv.Focus();
            }
            else if (SifSK.Text == "")
            {
                MessageBox.Show("Sifra Sklonista je obavezan podatak");
                SifSK.Focus();
            }
            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "UPDATE Skloniste SET Naziv='" + Naziv.Text;
                sqlupit += "', SifSK='" + SifSK.Text;
                sqlupit += "' WHERE Kapacitet=" + Kapacitet.Text;
                Komanda.CommandText = sqlupit;
                int responce = Komanda.ExecuteNonQuery();
                Konekcija.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija = new OleDbConnection(StringKonekcije);
            Konekcija.Open();/*Otvaranje baze podataka*/
            Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
            Komanda.CommandType = CommandType.Text;/*Određivanje tipa komande*/
            /*formiranje SQL upita komandi*/
            string sqlupit = "DELETE FROM Skloniste WHERE SifSK=" + SifSK.Text;
            Komanda.CommandText = sqlupit;
            int responce = Komanda.ExecuteNonQuery();
            Konekcija.Close();
            this.Close();
        }
    }
}
