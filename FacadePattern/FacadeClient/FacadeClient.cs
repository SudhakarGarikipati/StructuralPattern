using FacadePattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeClient
{
    public static class FacadeClient
    {
        public static void Execute()
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.PlaceOrder(1, 99.00);
        }
    }
}
