using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp
{
    public class StaticDb
    {
        public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Alfredo",
                Price = 330m,
                IsOnPromotion = true,
                PizzaSize = PizzaSize.Normal,
                HasExtras = true,
            },
            new Pizza()
            {
                Id=2,
                Name = "Margrita",
                Price = 360m,
                IsOnPromotion = false,
                PizzaSize= PizzaSize.Family,
                HasExtras = true
            },
            new Pizza()
            {
                Id = 3,
                Name = "Macedonian",
                Price = 400m,
                IsOnPromotion = true,
                PizzaSize = PizzaSize.Family,
                HasExtras = false                
            }
        };

        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Kristijan",
                LastName = "Adziovski",
                Address = "Dusan Taskovic1",
                PhoneNumber = "078 222 333"
            },
            new User()
            {
                Id = 2,
                FirstName = "Stefan",
                LastName = "Stefanovski",
                Address = "Koce Metalec 25",
                PhoneNumber = "077 777 777"
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x=> x.Id== 2),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethod.Cash
            },
            new Order()
            {
                Id = 2,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 3),
                User = Users.First(x => x.Id == 1),
                PaymentMethod = PaymentMethod.Card
            }
        };
    }
}
