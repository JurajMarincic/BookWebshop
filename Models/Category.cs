using System.ComponentModel.DataAnnotations;

namespace BookWebshop.Models;

public class Category
{
    // primarni kljuc
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
}
