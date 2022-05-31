using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMDemo.Models;

namespace WpfMVVMDemo.Services
{
    class MockOrderService : IOrderSevice
    {
        public void PlaceOrder(List<string> dishes)
        {
            string orderFileName = System.IO.Path.Combine(Environment.CurrentDirectory, @"Data\Order.txt");
            System.IO.File.WriteAllLines(orderFileName, dishes.ToArray());
        }
    }
}
