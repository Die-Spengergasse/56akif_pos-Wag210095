// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

namespace Basis.CSharp;
public class Student

{
    public enum Genders { Male, Female, Other };
    public string? _lastName;// ReferenzTyp nicht null also entweder ?, string.empty, "" oder default
    [Key]
    public int Id { get; set; }
    public Genders Gender { get; set; }
    public DateTime Birthdate { get; set; }
    public string? FirstName { get; set; }
     public string? LastName { 
        
        get
        {
            return _lastName;
        }
        set
        {
            if (value != "xy")
            {
                _lastName = value;
            }
            else
                throw new NoXyException("");
        }
    }
    public void Save()
    {
        StudentData data = new StudentData();
    }
    
}