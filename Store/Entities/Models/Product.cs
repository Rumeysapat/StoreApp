using System.ComponentModel.DataAnnotations;

namespace Entities;
public class Product

{
    public int ProductId { get; set; }


    [Required(ErrorMessage ="ProductName is required")]
     public string? ProductName { get; set; }=String.Empty;


     [Required(ErrorMessage ="Price is required")]
      public decimal Price { get; set; }
     

    public string? Description { get; set; }
}
