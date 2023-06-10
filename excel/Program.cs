
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        // Excel dosyasını oluşturmak için bir örnek veri kümesi
        var data = new[]
        {
            new { Name = "John Doe", Age = 30, Email = "john@example.com" },
            new { Name = "Jane Smith", Age = 35, Email = "jane@example.com" },
            new { Name = "Bob Johnson", Age = 40, Email = "bob@example.com" }
        };

        // Excel dosyasını oluşturmak için yeni bir paket oluşturun
        using (var package = new ExcelPackage())
        {
            // Yeni bir çalışma sayfası ekleyin
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            // Başlık satırını ekleyin
            worksheet.Cells[1, 1].Value = "Name";
            worksheet.Cells[1, 2].Value = "Age";
            worksheet.Cells[1, 3].Value = "Email";

            // Verileri doldurun
            for (var i = 0; i < data.Length; i++)
            {
                worksheet.Cells[i + 2, 1].Value = data[i].Name;
                worksheet.Cells[i + 2, 2].Value = data[i].Age;
                worksheet.Cells[i + 2, 3].Value = data[i].Email;
            }

            // Excel dosyasını kaydedin
            FileInfo fileInfo = new FileInfo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.xlsx");
            //fileInfo.CopyTo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.xlsx");
            package.SaveAs(fileInfo);
        }

    }
}