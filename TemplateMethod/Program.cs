using TemplateMethod;

var pdfGenerator = new PdfGenerator();
Console.WriteLine("** PDF **");
pdfGenerator.GenerateReport();

var csvGenerator = new CsvGenerator();
Console.WriteLine("** CSV **");
csvGenerator.GenerateReport();

var excelGenerator = new ExcelGenerator();
Console.WriteLine("** EXCEL **");
excelGenerator.GenerateReport();
