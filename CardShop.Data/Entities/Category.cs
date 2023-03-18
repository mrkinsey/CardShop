using System.ComponentModel.DataAnnotations;

namespace CardShop.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}