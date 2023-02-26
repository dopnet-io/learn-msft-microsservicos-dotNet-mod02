using Microsoft.AspNetCore.Mvc;

namespace MicrosservicosModDois.Controllers;

[ApiController]
[Route("[controller]")]
public class ContosoPizzaInfoController : ControllerBase
{
    private static readonly ContosoPizzaInfo[] Menu = new[]
    {
        new ContosoPizzaInfo { PizzaName = "The Mighty Meatball", Ingredients = "Meatballs and cheese", Cost = 40, InStock = "yes"},
        new ContosoPizzaInfo { PizzaName = "Crab Apple", Ingredients = "Dungeness crab and apples", Cost = 35, InStock = "no"},
        new ContosoPizzaInfo { PizzaName = "Forest Floor", Ingredients = "Mushrooms, rutabagas, and walnuts", Cost = 20, InStock = "yes"},
        new ContosoPizzaInfo { PizzaName = "Don't At Me", Ingredients = "Pineapple, Canadian bacon, jalapeños", Cost = 25, InStock = "yes"},
        new ContosoPizzaInfo { PizzaName = "Vanilla", Ingredients = "Sausage and pepperoni", Cost = 15, InStock = "no"},
        new ContosoPizzaInfo { PizzaName = "Spice Coming At Ya", Ingredients = "Peppers, chili sauce, spicy andouille", Cost = 50, InStock = "yes"}
    };

    private readonly ILogger<ContosoPizzaInfoController> _logger;

    public ContosoPizzaInfoController(ILogger<ContosoPizzaInfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<ContosoPizzaInfo> Get()
    {
        return Menu;
    }
}
