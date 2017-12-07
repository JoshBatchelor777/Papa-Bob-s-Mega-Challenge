using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var order = new DTO.OrderDTO();
            // when the page loads, show the Orders database.
            displayOrders();
            Button1.Enabled = false;
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            // new variable to place the values of the updated db entities in.
            var order = new DTO.OrderDTO();

            // NOTE: if the GetOrders and displayOrders functions are to be invoked, there must be 
            // "something" (data) in each field, becuase null is not allowed for some fields.

            // TODO: refactor DB entities to print, to receive input from top level(PapaBobs.Web) functionality.

            
            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Medium;
            order.Crust = DTO.Enums.CrustType.Thick;
            order.Pepperoni = true;
            order.Name = "test";
            order.Address = "123 Kekistan Ave.";
            order.Zip = "12345";
            order.Phone = "555-5554";
            order.PaymentType = DTO.Enums.PaymentType.RepublicCredits;
            order.TotalCost = 9999.99M;
            
            
            try
            {
                // call the order manager to, create order for my local order instance.
                Domain.OrderManager.CreatOrder(order);
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }
        

        // Another Spike in functionality. This drills down to domain, then persistence, 
        // and is assembled (or chained together) by the DTO.
        private void displayOrders()
        {
            var orders = Domain.OrderManager.GetOrders();

            // fill the grid view with the values of orders.
            ordersGridView.DataSource = orders.ToList();
            ordersGridView.DataBind();
        }
    }
    // MISc. NOTE: order.TotalCost = 9999.99M; 
    // Whenevr hardcoding a Decimal literal, use an "M", then no cast is needed.
}