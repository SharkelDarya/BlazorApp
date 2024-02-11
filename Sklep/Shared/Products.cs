using System.ComponentModel.DataAnnotations;

namespace Sklep.Shared
{
    public class Products
    {
        // Лey oznacza primary key w bazie danych
        [Key]
        public int Id { get; set; }
        //Знак вопроса нужен что бы была возможность у переменной
        //значение NULL
        public string? Name { get; set; }
        public string? Categories { get; set; }

        public string? ImageUrl { get; set; }
        public string? Url { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public string? Description { get; set; }
    }
}

