using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.DateTime;

namespace BookWebshop.Models;

    public class Product
    {
        // primarni kljuc
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public Category Category { get; set; }
        public DateTime DateOfPublish { get; set;}
        public string Picture { get; set; }
        public int NumberOfPages { get; set; }
}


