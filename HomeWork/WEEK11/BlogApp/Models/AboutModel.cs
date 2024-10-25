using System;

namespace BlogApp.Models;

public class AboutModel
{
    public string? AdSoyad { get; set; }
    public string? Aciklama { get; set; }
    public List<StajYer>? Staj { get; set; }
    public string? Resim { get; set; }
    public List<LinkModel>? Links { get; set; }

}


