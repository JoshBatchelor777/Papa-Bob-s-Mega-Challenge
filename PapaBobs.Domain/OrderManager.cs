using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
        // static GetOrders function to pass info along via the DTO.
        public static List<DTO.OrderDTO> GetOrders()
        {
            var orders = Persistence.OrderRepository.GetOrders();
            return orders;
        }

        // "static" because I don't need to create an instance of "OrderManager" in order to call its (static) functions.
        // This function doesn't neccessarily do the order creation, it's just a step in the ladder, bringing
        // functionality up the layers.
        public static void CreatOrder(DTO.OrderDTO orderDTO)
        {
            // call the order repo, and execute function for creating a new order FOR the new instance of my DTO order.
            Persistence.OrderRepository.CreateOrder(orderDTO);
        }

    }
}
