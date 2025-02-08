using System;

namespace PersonelApp.Entity.Concrete;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public virtual ICollection<Person> People { get; set; }=[];

}
