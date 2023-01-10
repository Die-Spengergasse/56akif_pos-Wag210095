DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
optionsBuilder.UseSqlite("Data Source = SpengerShop_test.db");
SpengerShopContext db = new SpengerShopContext(optionsBuilder.Options);

   


List<Customer> res01 = db.Customers.Where(c=>c.FirstName.StartsWith("M")).ToList();//ToList immer so spät wie möglich aufrufen, Listen liegen im RAM und machen alles langsam so tötet man Server

var res02 = db.Customers.Where(c => c.Id == 12).FirstOrDefault();// gäbe es 2 mit 12 dann nimm den ersten liefert sowieso nur den einen (12) aber where liefert liste
//var res02 = db.Customers.SingleOrDefault(c => c.Id == 12) ?? Alternative;// liefert nur den mit 12 braucht kein where
//var res02 = db.Customers.Single(c => c.Id == 12);// wirft nur Ex kann kein Coalesce
var res03 = db.Customers.Count(c => !c.LastChangedDate.hasValue);
var res04 = db.Customers.Where(c => c.FirstName.StartsWith("H")
                    && c.BirthDate > new DateTime(2000, 01, 01));
//Produkt mit Normalpreis
var res05 = db.Products.Where( p => p.Prices.Any(p => p.CatPriceTypeNavigation.ShortName == "Normal"));

//Test Where SingeOrDefault Any Count




Console.Read();

