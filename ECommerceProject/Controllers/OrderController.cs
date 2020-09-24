using Microsoft.AspNetCore.Mvc;
using ECommerceProject.Models;
namespace ECommerceProject.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
