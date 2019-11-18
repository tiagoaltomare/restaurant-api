using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application;
using Restaurants.Domain;
using Restaurants.WebApi.ViewModel;

namespace Restaurants.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAppService _appService;

        public OrderController(IOrderAppService appService)
        {
            _appService = appService;
        }

        [Authorize("Bearer")]
        [HttpPost]
        public int Post([FromBody] OrderViewModel orderViewModel)
        {
            var listItems = new List<OrderItem>();

            orderViewModel.OrderItem.ForEach(o =>
                listItems.Add
                (
                    new OrderItem()
                    {
                        Price = o.Price,
                        Produto = new Menu() { Id = o.MenuId },
                        Quantity = o.Quantity
                    }
                )
            );


            if(orderViewModel.PaymentOption == "MON")
            {
                orderViewModel.PaymentOption = "Dinheiro";
            }
            else if (orderViewModel.PaymentOption == "DEB")
            {
                orderViewModel.PaymentOption = "Cartão de Débito";
            }
            else
            {
                orderViewModel.PaymentOption = "Cartão Refeição";
            }

            var order = new Order()
            {
                Address = orderViewModel.Address,
                Email = orderViewModel.Email,
                Telephone = orderViewModel.Telephone,
                Number = orderViewModel.Number,
                OptionalAddress = orderViewModel.OptionalAddress,
                PaymentOption = new PaymentOption() { Name = orderViewModel.PaymentOption },
                Items = listItems
            };

            return _appService.InsertOrder(order);
        }
    }
}