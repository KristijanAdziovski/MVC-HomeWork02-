using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersDb = StaticDb.Orders;

            List<OrderDetailsViewModel> orderViewModel = ordersDb.Select(x=> OrderMapper.ToOrderDetailsViewModel(x)).ToList();

            return View(orderViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Order orderDb = StaticDb.Orders.FirstOrDefault(x=> x.Id == id);
            if (orderDb == null)
            {
                return new EmptyResult();
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.ToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
    }
}
