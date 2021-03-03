//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MyShop.Core.Contracts;
//using MyShop.Core.Models;
//using MyShop.Services;
//using MyShop.WebUI.Controllers;
//using MyShop.WebUI.Tests.Mocks;
//using System;
//using System.Linq;

//namespace MyShop.WebUI.Tests.Controllers
//{
//    [TestClass]
//    public class BasketControllerTests
//    {
//        [TestMethod]
//        public void canAddBasketItem()
//        {
//            IRepository<Basket> baskets = new MockContext<Basket>();
//            IRepository<Product> product = new MockContext<Product>();

//            var httpContext = new MockHttpContext();

//            IBasketService basketService = new BasketService(product, baskets);
//            var controller = new BasketController(basketService);
//            controller.ControllerContext = new System.Web.Mvc.ControllerContext(httpContext, new System.Web.Routing.RouteData(), controller);
            
//            //basketService.AddToBasket(httpContext, "1");

//            controller.AddToBasket("1");

//            Basket basket = baskets.Collection().FirstOrDefault();

//            Assert.IsNotNull(basket);
//            Assert.AreEqual(1, basket.BasketItems.Count);
//            Assert.AreEqual("1", basket.BasketItems.ToList().FirstOrDefault().ProductId);
//        }
//    }
//}
