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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string StringKonekcije = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\Evakuacija.accdb;Persist Security Info=False;");
        OleDbConnection Konekcija;
        OleDbCommand Komanda = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Naziv.Text == "")
            {
                MessageBox.Show("ime je obavezan podatak");
                Naziv.Focus();
            }
            else
            {
                Konekcija = new OleDbConnection(StringKonekcije);/*Kreiranje instance klase*/
                Konekcija.Open();/*Otvaranje baze podataka*/
                Komanda.Connection = Konekcija;/*Povezivanje komande i konekcije*/
                Komanda.CommandType = CommandType.Text;/*Tipa komande*/
                /*formiranje SQL upita komandi*/
                string sqlupit = "INSERT INTO EvMesto (Naziv,  DatumEvakuacije,   BrojStanovnika) ";
                sqlupit += "VALUES('" + Naziv.Text + "', '"   + DatumEvakuacije.Text + "', '"     + BrojStanovnika.Text+ "')"; 
                Komanda.CommandText = sqlupit;
                int responce = Komanda.ExecuteNonQuery();
                Konekcija.Close();
                this.Close();
            }
        }
    }
}
