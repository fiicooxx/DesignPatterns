using Builder;

var builder = new InvoiceBuilder();

Invoice invoice = builder
.SetDate(new DateTime(2023, 1, 17))
.SetInvoiceNumber("A1")
.SetVendor("Google")
.SetVendee("Vendee")
.SetLineItems(new List<string>() { "Line item1", "Line item2" })
.Build();

Console.WriteLine(invoice.Vendee);
Console.WriteLine(invoice.Vendor);