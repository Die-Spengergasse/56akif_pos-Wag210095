// See https://aka.ms/new-console-template for more information
using Basis.CSharp;
using Basis.CSharp.Delegates;
using Microsoft.VisualBasic;
using static Basis.CSharp.Student;

string s = "My first string";
Console.WriteLine(s);

Student student = new Student(); 
student.Id = 5467;
student.Gender = Genders.Male;
student.FirstName = "Max ";
student.LastName = "Xy";
Console.WriteLine($"Student ID: {student.Id}, Name: {student.FirstName}{student.LastName}");
Console.WriteLine("Hello" + " " + "World");
Console.WriteLine("C:\\temp\\databases\\mydb.db");
Console.WriteLine(@"C:\temp\databases\mydb.db");
Console.WriteLine($"Name: {student.FirstName} - {student.LastName}");
Console.WriteLine($@"Name: {student.FirstName} - {student.LastName} ; Path: C:\temp\databases\mydb.db");
Console.WriteLine(string.Format("Datum: {0}, {1}", DateTime.Now, "asdfg"));
Console.WriteLine(string.Format("Datum: {0:dd-MM-yyyy}, {1}", DateTime.Now, "asdfg"));
//var fullName = student.GetType().FullName; .GetProperties(); .GetMethods(); 
//Console.In.ReadLine() liefert Liste mit den gewünschten Gets

int? a = null;//int? a = 12;
if (a.HasValue)// value kann nicht null sein 
{
    //Console.WriteLine(a.Value.ToString() ?? 5.ToString());// ?? coalesce operator 
    Console.WriteLine(a?.ToString() ?? 5.ToString());// ?? coalesce operator 
}
//a?. --> wie if block wenn a!= null;
//a?.ToString() wenn a != null ist--> To String() schréibe a

MyStudentList students = new MyStudentList()
{
    new Student() {FirstName = "First01", LastName = "Last01", Birthdate= new DateTime(2012, 04, 03) },
    new Student() {FirstName = "First02", LastName = "Last02", Birthdate= new DateTime(2012, 03, 03) },
    new Student() {FirstName = "First03", LastName = "Last03", Birthdate= new DateTime(2012, 02, 03) },
    new Student() {FirstName = "First04", LastName = "Last04", Birthdate= new DateTime(2012, 01, 03) },
    new Student() {FirstName = "First05", LastName = "Last05", Birthdate= new DateTime(2012, 06, 03) },
    new Student() {FirstName = "First06", LastName = "Last06", Birthdate= new DateTime(2012, 07, 03) },
    }; 
foreach(Student item in students)
{
    Console.WriteLine(item.ToString);
}