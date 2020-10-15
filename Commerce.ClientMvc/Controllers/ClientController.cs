using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.ClientMvc.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        //物流方案页面
        public IActionResult wuliu()
        {
            return View();
        }
        //注册页面
        public IActionResult reg()
        {
            return View();
        }
        //一级购物车页面
        public IActionResult cart()
        {
            return View();
        }
        //确定订单信息
        public IActionResult cart2()
        {
            return View();
        }
        //完成支付页面
        public IActionResult cart3()
        {
            return View();
        }
    }
}