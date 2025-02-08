using System;
using PersonelApp.Shared.ComplexType;

namespace PersonelApp.Entity.Concrete;

public class Person
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; }= string.Empty;
    public string Email { get; set; } = string.Empty;
    public PersonType PersonType { get; set; }
    public int? GroupId { get; set; }
    public virtual Group? Group { get; set; }

}
