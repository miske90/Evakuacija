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
    public partial class Form7 : Form
    {
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Evakuacija.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija; /*Deklaracija instance klase koja predstavlja konekciju na bazu*/
        OleDbCommand Komanda = new OleDbCommand();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Naziv.Text == "")
            {
                MessageBox.Show("Naziv moze biti Podrum ili beton");
                Naziv.Focus();
            }
            else if (SifSK.Text == "")
            {
                MessageBox.Show("Sifra sklonista je obavezan podatak");
                SifSK.Focus();
            }
            else if (Kapacitet.Text == "")
            {
                MessageBox.Show("Kapacitet sklonista je obavezan podatak");
                Kapacitet.Focus();
            }
            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);/*Kreiranje instance klase*/
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "INSERT INTO Skloniste (SifSK,Naziv,Kapacitet) ";
                sqlupit += "VALUES('" + SifSK.Text + "', '" + Naziv.Text + "','" + Kapacitet.Text + "')";
                Komanda.CommandText = sqlupit;
                int responce = Komanda.ExecuteNonQuery();
                Konekcija.Close();
                this.Close();
            }
        }
    }
}
