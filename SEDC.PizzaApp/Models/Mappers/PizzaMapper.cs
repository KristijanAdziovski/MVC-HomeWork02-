using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel(Pizza pizzaDb)
        {
            if (pizzaDb.HasExtras)
            {
                return new PizzaViewModel()
                {
                    Id = pizzaDb.Id,
                    Name = pizzaDb.Name,
                    Price = pizzaDb.Price + 10,
                    PizzaSize = pizzaDb.PizzaSize,
                };
            }else
            {
                return new PizzaViewModel()
                {
                    Id = pizzaDb.Id,
                    Name = pizzaDb.Name,
                    Price = pizzaDb.Price,
                    PizzaSize = pizzaDb.PizzaSize,
                };
            }

              
            }
        }
    }
