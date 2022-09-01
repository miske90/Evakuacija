namespace Evakuacija
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evMestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evakuacijaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evakuacijaDataSet = new Evakuacija.EvakuacijaDataSet();
            this.evMestoTableAdapter = new Evakuacija.EvakuacijaDataSetTableAdapters.EvMestoTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sklonisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sklonisteTableAdapter = new Evakuacija.EvakuacijaDataSetTableAdapters.SklonisteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evMestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evakuacijaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evakuacijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklonisteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.evMestoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Naziv";
            series1.YValueMembers = "SifEM";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(378, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "Evakuacija";
            this.chart1.Titles.Add(title1);
            // 
            // evMestoBindingSource
            // 
            this.evMestoBindingSource.DataMember = "EvMesto";
            this.evMestoBindingSource.DataSource = this.evakuacijaDataSetBindingSource;
            // 
            // evakuacijaDataSetBindingSource
            // 
            this.evakuacijaDataSetBindingSource.DataSource = this.evakuacijaDataSet;
            this.evakuacijaDataSetBindingSource.Position = 0;
            // 
            // evakuacijaDataSet
            // 
            this.evakuacijaDataSet.DataSetName = "EvakuacijaDataSet";
            this.evakuacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evMestoTableAdapter
            // 
            this.evMestoTableAdapter.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.sklonisteBindingSource;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(419, 32);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Naziv";
            series2.YValueMembers = "SifSK";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(351, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // sklonisteBindingSource
            // 
            this.sklonisteBindingSource.DataMember = "Skloniste";
            this.sklonisteBindingSource.DataSource = this.evakuacijaDataSetBindingSource;
            // 
            // sklonisteTableAdapter
            // 
            this.sklonisteTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 392);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evMestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evakuacijaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evakuacijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklonisteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource evakuacijaDataSetBindingSource;
        private EvakuacijaDataSet evakuacijaDataSet;
        private System.Windows.Forms.BindingSource evMestoBindingSource;
        private EvakuacijaDataSetTableAdapters.EvMestoTableAdapter evMestoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource sklonisteBindingSource;
        private EvakuacijaDataSetTableAdapters.SklonisteTableAdapter sklonisteTableAdapter;

    }
}