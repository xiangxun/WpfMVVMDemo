using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMDemo.Models;

namespace WpfMVVMDemo.Services
{
    interface IOrderSevice
    {
        void PlaceOrder(List<string> dishes);
    }
}
