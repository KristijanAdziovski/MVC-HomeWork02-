using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class OrderMapper
    {
        public static OrderDetailsViewModel ToOrderDetailsViewModel(Order orderDb)
        {
            return new OrderDetailsViewModel()
            {
                PaymentMethod = orderDb.PaymentMethod,
                PizzaName = orderDb.Pizza.Name,
                Price = orderDb.Pizza.Price,
                UserFullName = $"{orderDb.User.FirstName} {orderDb.User.LastName}",
                UserAddress = orderDb.User.Address,
            };
        }
    }
}
