namespace Winforms_Charting
{
    partial class MainForm
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
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", false);
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType1 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType2 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType3 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType4 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType5 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType6 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType7 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType8 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType9 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType10 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType11 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType12 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType13 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType14 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType15 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.CurrencyCellType currencyCellType16 = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType1 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType2 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "fpSpread1, Sheet1, Row 0, Column 0, Video Game Sales 2014 - 2015";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(1142, 553);
            this.fpSpread1.TabIndex = 0;
            this.fpSpread1.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fpSpread1_ButtonClicked);
            this.fpSpread1.SetViewportTopRow(0, 0, 3);
            this.fpSpread1.SetActiveViewport(0, -1, 0);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpSpread1_Sheet1.ColumnCount = 5;
            this.fpSpread1_Sheet1.RowCount = 27;
            this.fpSpread1_Sheet1.AddCustomName("Price", "Sheet1!R4C2:R11C2", 0, 0, false, "");
            this.fpSpread1_Sheet1.AddCustomName("UnitsSold", "Sheet1!R4C3:R11C3", 0, 0, false, "");
            this.fpSpread1_Sheet1.AddCustomName("UnitsProduced", "Sheet1!R4C4:R11C4", 0, 0, false, "");
            this.fpSpread1_Sheet1.AddCustomName("Profit", "Sheet1!R4C5:R11C5", 0, 0, false, "");
            this.fpSpread1_Sheet1.AlternatingRows.Get(0).BackColor = System.Drawing.Color.LightGreen;
            this.fpSpread1_Sheet1.Cells.Get(0, 0).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fpSpread1_Sheet1.Cells.Get(0, 0).ColumnSpan = 5;
            this.fpSpread1_Sheet1.Cells.Get(0, 0).Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold);
            this.fpSpread1_Sheet1.Cells.Get(0, 0).ForeColor = System.Drawing.Color.White;
            this.fpSpread1_Sheet1.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.fpSpread1_Sheet1.Cells.Get(0, 0).RowSpan = 2;
            this.fpSpread1_Sheet1.Cells.Get(0, 0).Value = "Video Game Sales 2014 - 2015";
            this.fpSpread1_Sheet1.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(2, 0).BackColor = System.Drawing.Color.Lime;
            this.fpSpread1_Sheet1.Cells.Get(2, 0).Font = new System.Drawing.Font("Lucida Console", 10F);
            this.fpSpread1_Sheet1.Cells.Get(2, 0).Value = "Console";
            this.fpSpread1_Sheet1.Cells.Get(2, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(2, 1).BackColor = System.Drawing.Color.Lime;
            this.fpSpread1_Sheet1.Cells.Get(2, 1).Font = new System.Drawing.Font("Lucida Console", 10F);
            this.fpSpread1_Sheet1.Cells.Get(2, 1).Value = "Price";
            this.fpSpread1_Sheet1.Cells.Get(2, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(2, 2).BackColor = System.Drawing.Color.Lime;
            this.fpSpread1_Sheet1.Cells.Get(2, 2).Font = new System.Drawing.Font("Lucida Console", 10F);
            this.fpSpread1_Sheet1.Cells.Get(2, 2).Value = "Units Sold (Millions)";
            this.fpSpread1_Sheet1.Cells.Get(2, 2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(2, 3).BackColor = System.Drawing.Color.Lime;
            this.fpSpread1_Sheet1.Cells.Get(2, 3).Font = new System.Drawing.Font("Lucida Console", 10F);
            this.fpSpread1_Sheet1.Cells.Get(2, 3).Value = "Units Produced (Millions)";
            this.fpSpread1_Sheet1.Cells.Get(2, 3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(2, 4).BackColor = System.Drawing.Color.Lime;
            this.fpSpread1_Sheet1.Cells.Get(2, 4).Font = new System.Drawing.Font("Lucida Console", 10F);
            this.fpSpread1_Sheet1.Cells.Get(2, 4).Value = "Profit (Millions)";
            this.fpSpread1_Sheet1.Cells.Get(2, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(3, 0).Value = "Playstation 3";
            this.fpSpread1_Sheet1.Cells.Get(3, 1).CellType = currencyCellType1;
            this.fpSpread1_Sheet1.Cells.Get(3, 1).Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(3, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(3, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(3, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(3, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(3, 2).Value = 82.4D;
            this.fpSpread1_Sheet1.Cells.Get(3, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(3, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(3, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(3, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(3, 3).Value = 85;
            currencyCellType2.DecimalPlaces = 0;
            currencyCellType2.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType2.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType2.Separator = ",";
            currencyCellType2.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(3, 4).CellType = currencyCellType2;
            this.fpSpread1_Sheet1.Cells.Get(3, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(3, 4).Value = 41200D;
            this.fpSpread1_Sheet1.Cells.Get(4, 0).Value = "Playstation 4";
            this.fpSpread1_Sheet1.Cells.Get(4, 1).CellType = currencyCellType3;
            this.fpSpread1_Sheet1.Cells.Get(4, 1).Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(4, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(4, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(4, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(4, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(4, 2).Value = 8.1D;
            this.fpSpread1_Sheet1.Cells.Get(4, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(4, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(4, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(4, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(4, 3).Value = 10;
            currencyCellType4.DecimalPlaces = 0;
            currencyCellType4.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType4.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType4.Separator = ",";
            currencyCellType4.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(4, 4).CellType = currencyCellType4;
            this.fpSpread1_Sheet1.Cells.Get(4, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(4, 4).Value = 3240D;
            this.fpSpread1_Sheet1.Cells.Get(5, 0).Value = "Playstation Vita";
            this.fpSpread1_Sheet1.Cells.Get(5, 1).CellType = currencyCellType5;
            this.fpSpread1_Sheet1.Cells.Get(5, 1).Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(5, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(5, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(5, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(5, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(5, 2).Value = 8.3D;
            this.fpSpread1_Sheet1.Cells.Get(5, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(5, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(5, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(5, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(5, 3).Value = 10;
            currencyCellType6.DecimalPlaces = 0;
            currencyCellType6.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType6.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType6.Separator = ",";
            currencyCellType6.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(5, 4).CellType = currencyCellType6;
            this.fpSpread1_Sheet1.Cells.Get(5, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(5, 4).Value = 1660.0000000000002D;
            this.fpSpread1_Sheet1.Cells.Get(6, 0).Value = "Xbox 360";
            this.fpSpread1_Sheet1.Cells.Get(6, 1).CellType = currencyCellType7;
            this.fpSpread1_Sheet1.Cells.Get(6, 1).Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(6, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(6, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(6, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(6, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(6, 2).Value = 82.3D;
            this.fpSpread1_Sheet1.Cells.Get(6, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(6, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(6, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(6, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(6, 3).Value = 87;
            currencyCellType8.DecimalPlaces = 0;
            currencyCellType8.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType8.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType8.Separator = ",";
            currencyCellType8.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(6, 4).CellType = currencyCellType8;
            this.fpSpread1_Sheet1.Cells.Get(6, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(6, 4).Value = 24690D;
            this.fpSpread1_Sheet1.Cells.Get(7, 0).Value = "Xbox One";
            this.fpSpread1_Sheet1.Cells.Get(7, 1).CellType = currencyCellType9;
            this.fpSpread1_Sheet1.Cells.Get(7, 1).Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(7, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(7, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(7, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(7, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(7, 2).Value = 4.5D;
            this.fpSpread1_Sheet1.Cells.Get(7, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(7, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(7, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(7, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(7, 3).Value = 10;
            currencyCellType10.DecimalPlaces = 0;
            currencyCellType10.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType10.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType10.Separator = ",";
            currencyCellType10.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(7, 4).CellType = currencyCellType10;
            this.fpSpread1_Sheet1.Cells.Get(7, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(7, 4).Value = 2250D;
            this.fpSpread1_Sheet1.Cells.Get(8, 0).Value = "Nintendo Wii";
            this.fpSpread1_Sheet1.Cells.Get(8, 1).CellType = currencyCellType11;
            this.fpSpread1_Sheet1.Cells.Get(8, 1).Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(8, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(8, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(8, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(8, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(8, 2).Value = 100.7D;
            this.fpSpread1_Sheet1.Cells.Get(8, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(8, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(8, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(8, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(8, 3).Value = 200;
            currencyCellType12.DecimalPlaces = 0;
            currencyCellType12.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType12.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType12.Separator = ",";
            currencyCellType12.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(8, 4).CellType = currencyCellType12;
            this.fpSpread1_Sheet1.Cells.Get(8, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(8, 4).Value = 25175D;
            this.fpSpread1_Sheet1.Cells.Get(9, 0).Value = "Nintendo Wii U";
            this.fpSpread1_Sheet1.Cells.Get(9, 1).CellType = currencyCellType13;
            this.fpSpread1_Sheet1.Cells.Get(9, 1).Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.fpSpread1_Sheet1.Cells.Get(9, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(9, 2).ParseFormatInfo)).NumberDecimalDigits = 1;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(9, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(9, 2).ParseFormatString = "N";
            this.fpSpread1_Sheet1.Cells.Get(9, 2).Value = 6.3D;
            this.fpSpread1_Sheet1.Cells.Get(9, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(9, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(9, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(9, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(9, 3).Value = 10;
            currencyCellType14.DecimalPlaces = 0;
            currencyCellType14.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType14.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType14.Separator = ",";
            currencyCellType14.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(9, 4).CellType = currencyCellType14;
            this.fpSpread1_Sheet1.Cells.Get(9, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(9, 4).Value = 1890D;
            this.fpSpread1_Sheet1.Cells.Get(10, 0).Value = "Nintendo 3DS XL";
            this.fpSpread1_Sheet1.Cells.Get(10, 1).CellType = currencyCellType15;
            this.fpSpread1_Sheet1.Cells.Get(10, 1).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 1).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 1).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(10, 1).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(10, 1).Value = 200;
            this.fpSpread1_Sheet1.Cells.Get(10, 2).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 2).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 2).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(10, 2).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(10, 2).Value = 43;
            this.fpSpread1_Sheet1.Cells.Get(10, 3).ParseFormatInfo = ((System.Globalization.NumberFormatInfo)(cultureInfo.NumberFormat.Clone()));
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 3).ParseFormatInfo)).NumberDecimalDigits = 0;
            ((System.Globalization.NumberFormatInfo)(this.fpSpread1_Sheet1.Cells.Get(10, 3).ParseFormatInfo)).NumberGroupSizes = new int[] {
        0};
            this.fpSpread1_Sheet1.Cells.Get(10, 3).ParseFormatString = "n";
            this.fpSpread1_Sheet1.Cells.Get(10, 3).Value = 50;
            currencyCellType16.DecimalPlaces = 0;
            currencyCellType16.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            currencyCellType16.MinimumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            currencyCellType16.Separator = ",";
            currencyCellType16.ShowSeparator = true;
            this.fpSpread1_Sheet1.Cells.Get(10, 4).CellType = currencyCellType16;
            this.fpSpread1_Sheet1.Cells.Get(10, 4).Formula = "RC[-3]*RC[-2]";
            this.fpSpread1_Sheet1.Cells.Get(10, 4).Value = 8600D;
            buttonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace;
            buttonCellType1.Text = "Create Chart";
            this.fpSpread1_Sheet1.Cells.Get(11, 0).CellType = buttonCellType1;
            this.fpSpread1_Sheet1.Cells.Get(11, 0).Font = new System.Drawing.Font("Lucida Console", 12F);
            this.fpSpread1_Sheet1.Cells.Get(11, 0).RowSpan = 8;
            this.fpSpread1_Sheet1.Cells.Get(11, 1).ColumnSpan = 4;
            this.fpSpread1_Sheet1.Cells.Get(11, 1).Font = new System.Drawing.Font("Lucida Console", 28F, System.Drawing.FontStyle.Italic);
            this.fpSpread1_Sheet1.Cells.Get(11, 1).ForeColor = System.Drawing.Color.LightGray;
            this.fpSpread1_Sheet1.Cells.Get(11, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpSpread1_Sheet1.Cells.Get(11, 1).RowSpan = 16;
            this.fpSpread1_Sheet1.Cells.Get(11, 1).Value = "Chart displays here.";
            this.fpSpread1_Sheet1.Cells.Get(11, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            buttonCellType2.ButtonColor2 = System.Drawing.SystemColors.ButtonFace;
            buttonCellType2.Text = "Update Chart";
            this.fpSpread1_Sheet1.Cells.Get(19, 0).CellType = buttonCellType2;
            this.fpSpread1_Sheet1.Cells.Get(19, 0).Font = new System.Drawing.Font("Lucida Console", 12F);
            this.fpSpread1_Sheet1.Cells.Get(19, 0).RowSpan = 8;
            this.fpSpread1_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;
            this.fpSpread1_Sheet1.Columns.Get(0).Width = 144F;
            this.fpSpread1_Sheet1.Columns.Get(1).Width = 89F;
            this.fpSpread1_Sheet1.Columns.Get(2).Width = 181F;
            this.fpSpread1_Sheet1.Columns.Get(3).Width = 229F;
            this.fpSpread1_Sheet1.Columns.Get(4).Width = 168F;
            this.fpSpread1_Sheet1.FrozenRowCount = 3;
            this.fpSpread1_Sheet1.RowHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;
            this.fpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpSpread1_Sheet1.Rows.Get(0).Locked = true;
            this.fpSpread1_Sheet1.Rows.Get(2).Height = 31F;
            this.fpSpread1_Sheet1.Rows.Get(2).Locked = true;
            this.fpSpread1_Sheet1.ZoomFactor = 1.1F;
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 553);
            this.Controls.Add(this.fpSpread1);
            this.Name = "MainForm";
            this.Text = "Video Game Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
    }
}

