using System;
using System.Collections;
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
    public partial class MainForm : Form
    {
        public static int Price = 1;
        public static int Sold = 2;
        public static int Produced = 3;
        public static int Profit = 4;

        public static int ChartAreaRowStart = 11;
        public static int ChartAreaColStart = 1;
        public static int ChartAreaRowCount = 16;
        public static int ChartAreaColCount = 4;

        public static int ClusteredBar = 0;
        public static int StackedBar = 1;
        public static int Pie = 2;
        public static int Line = 3;
        public static int Radar = 4;

        public static int ChartSizeX;
        public static int ChartSizeY;
        public static int RowHeight;

        public static int SeriesType;
        public static ChartModel ChartModel;
        public static string[] SeriesNames = { "Price", "Sold", "Produced", "Profit" };

        public CellRange[] tempRange;

        public MainForm()
        {
            InitializeComponent();
        }

        public void placeChart(string chartName, ChartModel model, CellRange[] cellRanges, int seriesType, int rowStart, int rowCount, int colStart, int colCount)
        {
            SeriesType = seriesType;
            ChartModel = model;
            ChartSizeX = 0;
            ChartSizeY = 0;
            RowHeight = 0;
            if (fpSpread1.Sheets[0].Charts.Count != 0)
                fpSpread1.Sheets[0].Charts.Clear();

            for (int i = colStart; i < colStart + colCount; i++)
            {
                ChartSizeX += (int)fpSpread1.Sheets[0].Columns[i].Width;
            }
            for (int i = rowStart; i < rowStart + rowCount; i++)
            {
                ChartSizeY += (int)fpSpread1.Sheets[0].Rows[i].Height;
            }
            for (int i = 0; i < rowStart; i++)
            {
                RowHeight += (int)fpSpread1.Sheets[0].Rows[i].Height;
            }
            int size = 0;
            for (int i = 0; i < cellRanges.Length; i++)
            {
                if (cellRanges[i] != null)
                    size++;
            }
            tempRange = new CellRange[size];
            int tempIndex = 0;
            for (int i = 0; i < cellRanges.Length; i++)
            {
                if (cellRanges[i] != null)
                {
                    tempRange[tempIndex] = cellRanges[i];
                    tempIndex++;
                }       
            }

            if (SeriesType == ClusteredBar)
                fpSpread1.Sheets[0].AddChart(tempRange, typeof(ClusteredBarSeries), ChartSizeX, ChartSizeY, (int)fpSpread1.Sheets[0].Columns[0].Width, RowHeight);
            else if (SeriesType == StackedBar)
                fpSpread1.Sheets[0].AddChart(tempRange, typeof(StackedBarSeries), ChartSizeX, ChartSizeY, (int)fpSpread1.Sheets[0].Columns[0].Width, RowHeight);
            else if (SeriesType == Pie)
                fpSpread1.Sheets[0].AddChart(tempRange, typeof(PieSeries), ChartSizeX, ChartSizeY, (int)fpSpread1.Sheets[0].Columns[0].Width, RowHeight);
            else if (SeriesType == Line)
                fpSpread1.Sheets[0].AddChart(tempRange, typeof(LineSeries), ChartSizeX, ChartSizeY, (int)fpSpread1.Sheets[0].Columns[0].Width, RowHeight);
            else if (SeriesType == Radar)
                fpSpread1.Sheets[0].AddChart(tempRange, typeof(RadarPointSeries), ChartSizeX, ChartSizeY, (int)fpSpread1.Sheets[0].Columns[0].Width, RowHeight);
            updateChart();
        }

        public void updateChart()
        {
            if (SeriesType == ClusteredBar)
            {
                ClusteredBarSeries bars = new ClusteredBarSeries();
                for (int i = 0; i < tempRange.Length; i++)
                    bars.Series.Add(createBarSeries(SeriesNames[tempRange[i].Column - 1], tempRange[i].Column, 3, 11));
                fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0].Series[0] = bars;
                YPlotArea barChart = (YPlotArea)fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0];
                barChart.Vertical = false;
            }
            else if (SeriesType == StackedBar)
            {
                StackedBarSeries bars = new StackedBarSeries();
                for (int i = 0; i < tempRange.Length; i++)
                    bars.Series.Add(createBarSeries(SeriesNames[tempRange[i].Column - 1], tempRange[i].Column, 3, 11));
                fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0].Series[0] = bars;
                YPlotArea barChart = (YPlotArea)fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0];
                barChart.Vertical = false;
            }
            else if (SeriesType == Pie)
            {
                for (int i = 0; i < tempRange.Length; i++)
                    fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0].Series[i] = createPieSeries(SeriesNames[tempRange[i].Column - 1], tempRange[i].Column, 3, 11);
            }
            else if (SeriesType == Line)
            {
                for (int i = 0; i < tempRange.Length; i++)
                    fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0].Series[i] = createLineSeries(SeriesNames[tempRange[i].Column - 1], tempRange[i].Column, 3, 11);
            }
            else if (SeriesType == Radar)
            {
                for (int i = 0; i < tempRange.Length; i++)
                    fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0].Series[i] = createRadarPointSeries(SeriesNames[tempRange[i].Column - 1], tempRange[i].Column, 3, 11);
            }

            fpSpread1.Sheets[0].Charts[0].Model.LabelAreas.Add(ChartModel.LabelAreas[0]);
            fpSpread1.Sheets[0].Charts[0].CanMove = FarPoint.Win.Spread.DrawingSpace.Moving.None;
            fpSpread1.Sheets[0].Charts[0].CanSize = FarPoint.Win.Spread.DrawingSpace.Sizing.None;
        }

        public BarSeries createBarSeries(string seriesName, int col, int rowStart, int rowEnd)
        {
            BarSeries series = new BarSeries();
            series.SeriesName = seriesName;
            for (int i = rowStart; i < rowEnd; i++)
            {
                series.Values.Add(Convert.ToDouble(fpSpread1.Sheets[0].Cells[i, col].Value));
                series.CategoryNames.Add(fpSpread1.Sheets[0].Cells[i, 0].Text);
            }
            return series;
        }

        public PieSeries createPieSeries(string seriesName, int col, int rowStart, int rowEnd)
        {
            PieSeries series = new PieSeries();
            series.SeriesName = seriesName;
            for (int i = rowStart; i < rowEnd; i++)
            {
                series.Values.Add(Convert.ToDouble(fpSpread1.Sheets[0].Cells[i, col].Value));
                series.CategoryNames.Add(fpSpread1.Sheets[0].Cells[i, 0].Text);
            }
            return series;
        }

        public LineSeries createLineSeries(string seriesName, int col, int rowStart, int rowEnd)
        {
            LineSeries series = new LineSeries();
            series.SeriesName = seriesName;
            for (int i = rowStart; i < rowEnd; i++)
            {
                series.Values.Add(Convert.ToDouble(fpSpread1.Sheets[0].Cells[i, col].Value));
                series.CategoryNames.Add(fpSpread1.Sheets[0].Cells[i, 0].Text);
            }
            return series;
        }

        public RadarPointSeries createRadarPointSeries(string seriesName, int col, int rowStart, int rowEnd)
        {
            RadarPointSeries series = new RadarPointSeries();
            series.SeriesName = seriesName;
            for (int i = rowStart; i < rowEnd; i++)
            {
                series.Values.Add(Convert.ToDouble(fpSpread1.Sheets[0].Cells[i, col].Value));
                series.CategoryNames.Add(fpSpread1.Sheets[0].Cells[i, 0].Text);
            }
            return series;
        }

        public ChartModel createChart(string name)
        {
            LabelArea label = new LabelArea();
            label.Text = name;
            label.Location = new PointF(0.5f, 0.02f);
            label.AlignmentX = 0.5f;
            label.AlignmentY = 0.0f;

            LegendArea legend = new LegendArea();
            legend.Location = new PointF(0.98f, 0.5f);
            legend.AlignmentX = 1.0f;
            legend.AlignmentY = 0.5f;

            ChartModel model = new ChartModel();
            model.LabelAreas.Add(label);
            model.LegendAreas.Add(legend);

            return model;
        }

        private void fpSpread1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (fpSpread1.ActiveSheet.ActiveCell.Column.Index == 0 && fpSpread1.ActiveSheet.ActiveCell.Row.Index == 11)
            {
                GenerateChart newChart = new GenerateChart(this);
                newChart.ShowDialog();
            }
            else if (fpSpread1.ActiveSheet.ActiveCell.Column.Index == 0 && fpSpread1.ActiveSheet.ActiveCell.Row.Index == 19)
            {
                if (ChartModel != null)
                    updateChart();
            }
        }
    }
}
