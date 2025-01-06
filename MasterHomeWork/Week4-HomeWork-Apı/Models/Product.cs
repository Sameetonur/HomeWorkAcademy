using System;

namespace Week4_HomeWork_Apı.Models;

public class Product
{

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Image { get; set; } = "SamplePicture.png";
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Color { get; set; }
    public string? Category { get; set; }
    public int Discount { get; set; }

}
