using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarPoint.Win.Chart;
using FarPoint.Win.Spread.Model;

namespace Winforms_Charting
{
    public partial class GenerateChart : Form
    {
        private Form parentForm;
        public GenerateChart(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MainForm mainForm = (MainForm)this.parentForm;
                string chartType = this.comboBox1.Text;
                string chartName = this.textBox1.Text;
                CellRange[] cellRanges = new CellRange[4];
                if (checkBox1.Checked)
                    cellRanges[0] = new CellRange(3, MainForm.Price, 8, 1);
                if (checkBox2.Checked)
                    cellRanges[1] = new CellRange(3, MainForm.Sold, 8, 1);
                if (checkBox3.Checked)
                    cellRanges[2] = new CellRange(3, MainForm.Produced, 8, 1);
                if (checkBox4.Checked)
                    cellRanges[3] = new CellRange(3, MainForm.Profit, 8, 1);

           if (!this.comboBox1.Text.Equals(null))
           {
                ChartModel chart = mainForm.createChart(chartName);
                if (chartType.Equals("Clustered Bar"))
                {
                    mainForm.placeChart(chartName, chart, cellRanges, MainForm.ClusteredBar, MainForm.ChartAreaRowStart, MainForm.ChartAreaRowCount, MainForm.ChartAreaColStart, MainForm.ChartAreaColCount);
                    this.Close();
                }
                else if (chartType.Equals("Stacked Bar"))
                {
                    mainForm.placeChart(chartName, chart, cellRanges, MainForm.StackedBar, MainForm.ChartAreaRowStart, MainForm.ChartAreaRowCount, MainForm.ChartAreaColStart, MainForm.ChartAreaColCount);
                    this.Close();
                }
                else if (chartType.Equals("Pie"))
                {
                    mainForm.placeChart(chartName, chart, cellRanges, MainForm.Pie, MainForm.ChartAreaRowStart, MainForm.ChartAreaRowCount, MainForm.ChartAreaColStart, MainForm.ChartAreaColCount);
                    this.Close();
                }
                else if (chartType.Equals("Line"))
                {
                    mainForm.placeChart(chartName, chart, cellRanges, MainForm.Line, MainForm.ChartAreaRowStart, MainForm.ChartAreaRowCount, MainForm.ChartAreaColStart, MainForm.ChartAreaColCount);
                    this.Close();
                }
                else if (chartType.Equals("Radar Point"))
                {
                    mainForm.placeChart(chartName, chart, cellRanges, MainForm.Radar, MainForm.ChartAreaRowStart, MainForm.ChartAreaRowCount, MainForm.ChartAreaColStart, MainForm.ChartAreaColCount);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
