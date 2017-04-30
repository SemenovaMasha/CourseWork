using System;
using System.Data;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace CourseWork
{
    class Reports
    {
    static public void invoicesPdf()
    {

            DataTable dt = ConnectionClass.getResult("select Material,Volume,Price,Name,Data,(Price*Volume) as Cost" +
                " from Purchase,Providers where Purchase.ProviderID = Providers.ID");

            var doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream(@"D:\Invoices.pdf",
        FileMode.Create)); doc.Open();

        BaseFont baseFont = BaseFont.CreateFont(@"D:\Tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Phrase phrase = new Phrase("От "+ DateTime.Today.ToShortDateString(), new
iTextSharp.text.Font(baseFont, 15,
iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0,0,0))));
            Paragraph a1 = new Paragraph(phrase);
            a1.Alignment = Element.ALIGN_RIGHT;
            a1.Add(Environment.NewLine);
            doc.Add(a1);
       phrase = new Phrase("Товарная накладная", new
iTextSharp.text.Font(baseFont, 15,
iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0,0,0))));
       a1 = new Paragraph(phrase);
        a1.Alignment = Element.ALIGN_CENTER;
            a1.Add(Environment.NewLine);
            a1.Add(Environment.NewLine);
            doc.Add(a1);

            PdfPTable table = new PdfPTable(7);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 50, 70, 80, 70, 80, 80, 80 });

            var font = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black));

            PdfPCell cell = new PdfPCell();
            cell.BackgroundColor = new BaseColor(Color.White);
            cell.Phrase = new Phrase("№", font);
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell);
            cell.Phrase = new Phrase("Наименование", font);
            table.AddCell(cell);
            cell.Phrase = new Phrase("Количество", font);
            table.AddCell(cell);
            cell.Phrase = new Phrase("Цена", font);
            table.AddCell(cell);
            cell.Phrase = new Phrase("Поставщик", font);
            table.AddCell(cell);
            cell.Phrase = new Phrase("Дата", font);
            table.AddCell(cell);
            cell.Phrase = new Phrase("Сумма", font);
            table.AddCell(cell);

            font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));
            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            int result = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cell.Phrase = new Phrase((i + 1) + "", font);
                table.AddCell(cell);
                for(int j = 0; j < 6; j++)
                {               
                    cell.Phrase = new Phrase(dt.Rows[i][j].ToString(), font);
                    table.AddCell(cell);
                }
                result += Convert.ToInt32(dt.Rows[i][5].ToString());
            }

            cell.Phrase = new Phrase("", font);
            cell.Colspan=5;
            table.AddCell(cell);

            cell.Phrase = new Phrase("Итого", font);
            cell.Colspan = 1;
            table.AddCell(cell);

            cell.Phrase = new Phrase(result+"", font);
            table.AddCell(cell);

            doc.Add(table);

            doc.Close();
    }


        static public void invoicesExcel(PictureBox p)
        {

            DataTable dt = ConnectionClass.getResult("select Material,sum(Price * Volume), substr(Data,4,10) as d from Purchase where substr(Data,7,4)=='2017' group by Material,d order by Material;");


            Excel.Application excelapp;
            Excel.Workbooks excelappworkbooks;
            Excel.Workbook excelappworkbook;
            Excel.Sheets excelsheets;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;

            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 3;
            excelapp.Workbooks.Add(Type.Missing);

            excelapp.DisplayAlerts = true;
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelsheets = excelappworkbook.Worksheets;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

            excelworksheet.Activate();

            excelcells = (Excel.Range)excelworksheet.Cells[3, 3];
            excelcells.Value2 = "Январь";

            Excel.Range vRange1 = excelapp.get_Range("C3:N3", Type.Missing);
            Excel.Range vRange = excelapp.get_Range("C3", Type.Missing);
            vRange.AutoFill(vRange1, Excel.XlAutoFillType.xlFillMonths);

            int mat_k = 0;
            for (int i = 0; i < dt.Rows.Count;)
            {
                string mat = dt.Rows[i][0].ToString();
                excelcells = (Excel.Range)excelworksheet.Cells[4 + mat_k, 2];
                excelcells.Value2 = mat;
                mat_k++;
                for (; i < dt.Rows.Count && dt.Rows[i][0].ToString() == mat; i++)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[3 + mat_k, 2 + Convert.ToInt32(dt.Rows[i][2].ToString().Substring(0, 2))];
                    excelcells.Value2 = dt.Rows[i][1].ToString();

                }
            }
            
            Excel.ChartObjects chartsobjrcts = (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing); Excel.ChartObject chartsobjrct = chartsobjrcts.Add(10, 200, 500, 400);
            excelcells = excelworksheet.get_Range("C4", "N" + (mat_k + 3));
            Excel.Chart excelchart = chartsobjrct.Chart;
            excelchart.SetSourceData(excelcells, Type.Missing);
            excelchart.ChartType = Excel.XlChartType.xlColumnClustered;
            excelchart.HasTitle = true;
            excelchart.ChartTitle.Text = "Покупка материалов";
            excelchart.ChartTitle.Font.Size = 14;
            excelchart.ChartTitle.Font.Color = 100;
            //excelchart.ChartTitle.Shadow = true;
            // excelchart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;
            ((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            //((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            ((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Месяц";
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlSeriesAxis,Excel.XlAxisGroup.xlPrimary)).HasTitle = false;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Материалов";
            excelchart.HasLegend = true;
            excelchart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionLeft;
            ((Excel.LegendEntry)excelchart.Legend.LegendEntries(1)).Font.Size = 12;
            //((Excel.LegendEntry)excelchart.Legend.LegendEntries(3)).Font.Size = 12;
            Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)excelchart.SeriesCollection(Type.Missing);
            Excel.Series series = seriesCollection.Item(1);

            for (int i = 0; i < mat_k; i++)
            {
                series = seriesCollection.Item(i + 1);
                excelcells = excelworksheet.get_Range("B" + (i + 4), Type.Missing);
                series.Name = excelcells.Value2;
            }
            series.XValues = excelapp.get_Range("C3:N3", Type.Missing);


            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelappworkbook.SaveAs(@"D:/invoices.xlsx",  //object Filename
      Excel.XlFileFormat.xlHtml,          //object FileFormat
      Type.Missing,                       //object Password 
      Type.Missing,                       //object WriteResPassword  
      Type.Missing,                       //object ReadOnlyRecommended
      Type.Missing,                       //object CreateBackup
      Excel.XlSaveAsAccessMode.xlNoChange,//XlSaveAsAccessMode AccessMode
      Type.Missing,                       //object ConflictResolution
      Type.Missing,                       //object AddToMru 
      Type.Missing,                       //object TextCodepage
      Type.Missing,                       //object TextVisualLayout
      Type.Missing);                      //object Local

            
            string fullPath = Path.GetTempPath() + "invoices.png";
            excelchart.Export(fullPath, "PNG",false);
            p.Image = new Bitmap( System.Drawing.Image.FromFile(fullPath), new Size(p.Width,p.Height));
            //excelappworkbook.Save();
            //return dt;

            //Bitmap bmp = new Bitmap(p.Width, p.Height);
            //Graphics gr = Graphics.FromImage(bmp);

            //int h = p.Height;
            //int w = p.Width;
            //int dx = w / 12;
            //int dy = h / 500;

            //int k = 0;
            //for (int i = 0; i < dt.Rows.Count;) { 
            //    string mat = dt.Rows[i][0].ToString();
            //    k++;
            //    gr.DrawString(mat, new System.Drawing.Font("Arial", 10), Brushes.Red,10+k * dx, h - 20);
            //    for (; i < dt.Rows.Count && dt.Rows[i][0].ToString() == mat; i++)
            //    {

            //    }
            //}

            //p.Image = bmp;
        }
        static public void expensesExcel(PictureBox p)
        {

            DataTable dt = ConnectionClass.getResult("select Type,sum(Sales.Price), substr(Data,4,10) as d from Sales,Products" +
                " where substr(Data,7,4)=='2017' and Products.ID=Sales.ProductID group by Type,d order by Type;");
            

            Excel.Application excelapp;
            Excel.Workbooks excelappworkbooks;
            Excel.Workbook excelappworkbook;
            Excel.Sheets excelsheets;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;

            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 3;
            excelapp.Workbooks.Add(Type.Missing);

            excelapp.DisplayAlerts = true;
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelsheets = excelappworkbook.Worksheets;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

            excelworksheet.Activate();

            excelcells = (Excel.Range)excelworksheet.Cells[3, 3];
            excelcells.Value2 = "Январь";

            Excel.Range vRange1 = excelapp.get_Range("C3:N3", Type.Missing);
            Excel.Range vRange = excelapp.get_Range("C3", Type.Missing);
            vRange.AutoFill(vRange1, Excel.XlAutoFillType.xlFillMonths);

            int mat_k = 0;
            for (int i = 0; i < dt.Rows.Count;)
            {
                string mat = dt.Rows[i][0].ToString();
                excelcells = (Excel.Range)excelworksheet.Cells[4 + mat_k, 2];
                excelcells.Value2 = mat;
                mat_k++;
                for (; i < dt.Rows.Count && dt.Rows[i][0].ToString() == mat; i++)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[3 + mat_k, 2 + Convert.ToInt32(dt.Rows[i][2].ToString().Substring(0, 2))];
                    excelcells.Value2 = dt.Rows[i][1].ToString();

                }
            }
           // MessageBox.Show(mat_k + "");

            Excel.ChartObjects chartsobjrcts = (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing); Excel.ChartObject chartsobjrct = chartsobjrcts.Add(10, 200, 500, 400);
            excelcells = excelworksheet.get_Range("C4", "N" + (mat_k + 3));
            Excel.Chart excelchart = chartsobjrct.Chart;
            excelchart.SetSourceData(excelcells, Type.Missing);
            excelchart.ChartType = Excel.XlChartType.xlColumnClustered;
            excelchart.HasTitle = true;
            excelchart.ChartTitle.Text = "Продажа товаров";
            excelchart.ChartTitle.Font.Size = 14;
            excelchart.ChartTitle.Font.Color = 100;
            //excelchart.ChartTitle.Shadow = true;
            // excelchart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;
            ((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            //((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            ((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Месяц";
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlSeriesAxis,Excel.XlAxisGroup.xlPrimary)).HasTitle = false;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Материалов";
            excelchart.HasLegend = true;
            excelchart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionLeft;
            ((Excel.LegendEntry)excelchart.Legend.LegendEntries(1)).Font.Size = 12;
            //((Excel.LegendEntry)excelchart.Legend.LegendEntries(3)).Font.Size = 12;
            Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)excelchart.SeriesCollection(Type.Missing);
            Excel.Series series = seriesCollection.Item(1);

            for (int i = 0; i < mat_k; i++)
            {
                series = seriesCollection.Item(i + 1);
                excelcells = excelworksheet.get_Range("B" + (i + 4), Type.Missing);
                series.Name = excelcells.Value2;
            }
            series.XValues = excelapp.get_Range("C3:N3", Type.Missing);


            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelappworkbook.SaveAs(@"D:/expenses.xlsx",  //object Filename
      Excel.XlFileFormat.xlHtml,          //object FileFormat
      Type.Missing,                       //object Password 
      Type.Missing,                       //object WriteResPassword  
      Type.Missing,                       //object ReadOnlyRecommended
      Type.Missing,                       //object CreateBackup
      Excel.XlSaveAsAccessMode.xlNoChange,//XlSaveAsAccessMode AccessMode
      Type.Missing,                       //object ConflictResolution
      Type.Missing,                       //object AddToMru 
      Type.Missing,                       //object TextCodepage
      Type.Missing,                       //object TextVisualLayout
      Type.Missing);                      //object Local


            string fullPath = Path.GetTempPath() + "expenses.png";
            excelchart.Export(fullPath, "PNG", false);
            p.Image = new Bitmap(System.Drawing.Image.FromFile(fullPath), new Size(p.Width, p.Height));
            //excelappworkbook.Save();
            //return dt;

            //Bitmap bmp = new Bitmap(p.Width, p.Height);
            //Graphics gr = Graphics.FromImage(bmp);

            //int h = p.Height;
            //int w = p.Width;
            //int dx = w / 12;
            //int dy = h / 500;

            //int k = 0;
            //for (int i = 0; i < dt.Rows.Count;) { 
            //    string mat = dt.Rows[i][0].ToString();
            //    k++;
            //    gr.DrawString(mat, new System.Drawing.Font("Arial", 10), Brushes.Red,10+k * dx, h - 20);
            //    for (; i < dt.Rows.Count && dt.Rows[i][0].ToString() == mat; i++)
            //    {

            //    }
            //}

            //p.Image = bmp;
        }

        static public void effectExcel(PictureBox p)
        {
            DataTable dt1 = ConnectionClass.getResult("select sum(Price * Volume), substr(Data,4,10) as d from Purchase where substr(Data,7,4)=='2017' group by d ;");
            DataTable dt2 = ConnectionClass.getResult("select sum(Sales.Price), substr(Data,4,10) as d from Sales where substr(Data,7,4)=='2017'  group by d ;");


            Excel.Application excelapp;
            Excel.Workbooks excelappworkbooks;
            Excel.Workbook excelappworkbook;
            Excel.Sheets excelsheets;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;

            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 3;
            excelapp.Workbooks.Add(Type.Missing);

            excelapp.DisplayAlerts = true;
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelsheets = excelappworkbook.Worksheets;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

            excelworksheet.Activate();

            excelcells = (Excel.Range)excelworksheet.Cells[3, 3];
            excelcells.Value2 = "Январь";

            Excel.Range vRange1 = excelapp.get_Range("C3:N3", Type.Missing);
            Excel.Range vRange = excelapp.get_Range("C3", Type.Missing);
            vRange.AutoFill(vRange1, Excel.XlAutoFillType.xlFillMonths);

            excelcells = (Excel.Range)excelworksheet.Cells[4, 2];
            excelcells.Value2 = "Расходы";
            excelcells = (Excel.Range)excelworksheet.Cells[5, 2];
            excelcells.Value2 = "Доходы";
            excelcells = (Excel.Range)excelworksheet.Cells[6, 2];
            excelcells.Value2 = "Прибыль";


            for (int i = 0; i < dt1.Rows.Count;i++)
            {
                excelcells = (Excel.Range)excelworksheet.Cells[4, 2 + Convert.ToInt32(dt1.Rows[i][1].ToString().Substring(0, 2))];
                excelcells.Value2 = dt1.Rows[i][0].ToString();
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                excelcells = (Excel.Range)excelworksheet.Cells[5, 2 + Convert.ToInt32(dt1.Rows[i][1].ToString().Substring(0, 2))];
                excelcells.Value2 = dt2.Rows[i][0].ToString();
            }
            for (int i = 0; i <12; i++)
            {
                excelcells = (Excel.Range)excelworksheet.Cells[6, 3 +i];
                excelcells.Formula = "=" + (char)('C' + i) + "4-" + (char)('C' + i) + "5";
            }

            Excel.ChartObjects chartsobjrcts = (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing); Excel.ChartObject chartsobjrct = chartsobjrcts.Add(10, 200, 500, 400);
            excelcells = excelworksheet.get_Range("C4", "N5");
            Excel.Chart excelchart = chartsobjrct.Chart;
            excelchart.SetSourceData(excelcells, Type.Missing);
            excelchart.ChartType = Excel.XlChartType.xlColumnClustered;
            excelchart.HasTitle = true;
            excelchart.ChartTitle.Text = "Расходы и доходы";
            excelchart.ChartTitle.Font.Size = 14;
            excelchart.ChartTitle.Font.Color = 100;
            //excelchart.ChartTitle.Shadow = true;
            // excelchart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;
            ((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            //((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            ((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Месяц";
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlSeriesAxis,Excel.XlAxisGroup.xlPrimary)).HasTitle = false;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Материалов";
            excelchart.HasLegend = true;
            excelchart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionLeft;
            ((Excel.LegendEntry)excelchart.Legend.LegendEntries(1)).Font.Size = 12;
            //((Excel.LegendEntry)excelchart.Legend.LegendEntries(3)).Font.Size = 12;
            Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)excelchart.SeriesCollection(Type.Missing);
            Excel.Series series = seriesCollection.Item(1);

            series = seriesCollection.Item(1);
            series.Name = "Расходы";
            series = seriesCollection.Item(2);
            series.Name = "Доходы";
            series.XValues = excelapp.get_Range("C3:N3", Type.Missing);


            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];

            excelappworkbook.SaveAs(@"D:/effectiveness.xlsx",  //object Filename
      Excel.XlFileFormat.xlHtml,          //object FileFormat
      Type.Missing,                       //object Password 
      Type.Missing,                       //object WriteResPassword  
      Type.Missing,                       //object ReadOnlyRecommended
      Type.Missing,                       //object CreateBackup
      Excel.XlSaveAsAccessMode.xlNoChange,//XlSaveAsAccessMode AccessMode
      Type.Missing,                       //object ConflictResolution
      Type.Missing,                       //object AddToMru 
      Type.Missing,                       //object TextCodepage
      Type.Missing,                       //object TextVisualLayout
      Type.Missing);                      //object Local


            string fullPath = Path.GetTempPath() + "effectiveness.png";
            excelchart.Export(fullPath, "PNG", false);
            p.Image = new Bitmap(System.Drawing.Image.FromFile(fullPath), new Size(p.Width, p.Height));
            //excelappworkbook.Save();
            //return dt;

            //Bitmap bmp = new Bitmap(p.Width, p.Height);
            //Graphics gr = Graphics.FromImage(bmp);

            //int h = p.Height;
            //int w = p.Width;
            //int dx = w / 12;
            //int dy = h / 500;

            //int k = 0;
            //for (int i = 0; i < dt.Rows.Count;) { 
            //    string mat = dt.Rows[i][0].ToString();
            //    k++;
            //    gr.DrawString(mat, new System.Drawing.Font("Arial", 10), Brushes.Red,10+k * dx, h - 20);
            //    for (; i < dt.Rows.Count && dt.Rows[i][0].ToString() == mat; i++)
            //    {

            //    }
            //}

            //p.Image = bmp;



            chartsobjrcts = (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing);
            chartsobjrct = chartsobjrcts.Add(610, 200, 500, 400);
            excelcells = excelworksheet.get_Range("C6", "N6");
            excelchart = chartsobjrct.Chart;
            excelchart.SetSourceData(excelcells, Type.Missing);
            excelchart.ChartType = Excel.XlChartType.xlColumnClustered;
            excelchart.HasTitle = true;
            excelchart.ChartTitle.Text = "Эффективность";
            excelchart.ChartTitle.Font.Size = 14;
            excelchart.ChartTitle.Font.Color = 100;
            //excelchart.ChartTitle.Shadow = true;
            // excelchart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;
            ((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            //((Excel.Axis)(excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary))).HasTitle = true;
            ((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Месяц";
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlSeriesAxis,Excel.XlAxisGroup.xlPrimary)).HasTitle = false;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).HasTitle = true;
            //((Excel.Axis)excelchart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary)).AxisTitle.Text = "Материалов";
            excelchart.HasLegend = true;
            excelchart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionLeft;
            ((Excel.LegendEntry)excelchart.Legend.LegendEntries(1)).Font.Size = 12;
            //((Excel.LegendEntry)excelchart.Legend.LegendEntries(3)).Font.Size = 12;
            seriesCollection = (Excel.SeriesCollection)excelchart.SeriesCollection(Type.Missing);
            series = seriesCollection.Item(1);

            series = seriesCollection.Item(1);
            series.Name = "Прибыль";
            series.XValues = excelapp.get_Range("C3:N3", Type.Missing);


        }
    }

}
