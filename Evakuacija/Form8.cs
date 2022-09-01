using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evakuacija
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evakuacijaDataSet.EvOsoba' table. You can move, or remove it, as needed.
            this.evOsobaTableAdapter.Fill(this.evakuacijaDataSet.EvOsoba);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            evOsobaTableAdapter.Update(evakuacijaDataSet.EvOsoba);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procitano.Text = "";
            Procitano.AppendText("Ukupno selektovanih celija: " + DataGrid.SelectedCells.Count.ToString() + "\n");
            foreach (DataGridViewCell celija in DataGrid.SelectedCells)
            {
                Procitano.AppendText("Red: " + celija.RowIndex.ToString() +
                 ", kolona: " + celija.ColumnIndex.ToString() +
                 ", vrednost celije: " + celija.Value + "\n");
            }

        }

       

        
    }
}
