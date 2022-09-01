using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Evakuacija
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evakuacijaDataSet.Skloniste' table. You can move, or remove it, as needed.
            this.sklonisteTableAdapter.Fill(this.evakuacijaDataSet.Skloniste);
            // TODO: This line of code loads data into the 'evakuacijaDataSet.EvMesto' table. You can move, or remove it, as needed.
            this.evMestoTableAdapter.Fill(this.evakuacijaDataSet.EvMesto);

        }

       
    }
}
