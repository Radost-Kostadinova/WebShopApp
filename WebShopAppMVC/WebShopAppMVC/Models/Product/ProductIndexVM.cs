using System.ComponentModel.DataAnnotations;
using WebShopAppMVC.Models.Brand;
using WebShopAppMVC.Models.Category;

namespace WebShopAppMVC.Models.Product
{
    public class ProductIndexVM
    {
        //Trqbva Required na nqkoi 
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

       
        public int BrandId { get; set; }
        [Display(Name = "Brand")]
        [Required]
        public string  BrandName { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name = "Picture")]
        public string Picture { get; set; } = null!;


        [Display(Name = "Quantity")]
        public int Quantity { get; set; }


        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }




    }
}
