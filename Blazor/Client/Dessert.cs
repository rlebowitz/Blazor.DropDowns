using System.ComponentModel.DataAnnotations;

namespace Blazor.Client
{
    public enum Dessert
    {
        [Display(Name ="Chocolate Cake")]
        ChocolateCake,
        Baklavah,
        [Display(Name = "Fruit Compote")]
        FruitCompote,
        Tiramisu,
        [Display(Name = "Toffee Squares")]
        ToffeeSquares
    }
}
