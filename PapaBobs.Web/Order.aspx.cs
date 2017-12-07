using PapaBobs.Persistence;
using PapaBobs.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Order : System.Web.UI.Page
    {
        public int total { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            total = 0;
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            // new variable to place the values of the updated db entities in.
            var order = new DTO.OrderDTO();

            // NOTE: if the GetOrders and displayOrders functions are to be invoked, there must be 
            // "something" (data) in each field, becuase null is not allowed for some fields.

            order.OrderId = Guid.NewGuid();
            order.Pepperoni = pepCheck.Checked;
            order.Sausage = sausCheck.Checked;
            order.Green_Peppers = gpCheck.Checked;
            order.Onions = oniCheck.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;
            // SIZE
            if (sizeList.SelectedValue == "Small")
            {
                order.Size = DTO.Enums.SizeType.Small;
            }
            if (sizeList.SelectedValue == "Medium")
            {
                order.Size = DTO.Enums.SizeType.Medium;
            }
            if (sizeList.SelectedValue == "Large")
            {
                order.Size = DTO.Enums.SizeType.Large;
            }
            // CRUST
            if (crustList.SelectedValue == "Regular")
            {
                order.Crust = DTO.Enums.CrustType.Regular;
            }
            if (crustList.SelectedValue == "Thick")
            {
                order.Crust = DTO.Enums.CrustType.Thick;
            }
            if (crustList.SelectedValue == "Thin")
            {
                order.Crust = DTO.Enums.CrustType.Thin;
            }
            // PAYMENT METHOD
            if (cashRButton.Checked)
            {
                order.PaymentType = DTO.Enums.PaymentType.Cash;
            }
            if (creditRButton.Checked)
            {
                order.PaymentType = DTO.Enums.PaymentType.Credit;
            }
            if (rpRButton.Checked)
            {
                order.PaymentType = DTO.Enums.PaymentType.RepublicCredits;
            }



            size();
            crust();
            toppings();

            order.TotalCost = order.TotalCost + total;
            costLabel.Text = total.ToString();
            if (total != 0)
            {
                order.Completed = true;
            }

            try
            {
                // call the order manager to, create order for my local order instance.
                Domain.OrderManager.CreatOrder(order);
            }
            catch (Exception ex)
            {
                costLabel.Text = ex.Message;
            }
        }

        private int crust()
        {
            if (crustList.SelectedValue == "Thick")
            {
                total = total + 2;
            }
            return Convert.ToInt32(total);
        }
        private int size()
        {
            if (sizeList.SelectedValue == "Small")
            {
                total = total + 12;
            }
            if (sizeList.SelectedValue == "Medium")
            {
                total = total + 14;
            }
            if (sizeList.SelectedValue == "Large")
            {
                total = total + 100;
            }

            return Convert.ToInt32(total);
        }
        private int toppings()
        {
            if (pepCheck.Checked)
            {
                total = total + 1;
            }
            if (sausCheck.Checked)
            {
                total = total + 2;
            }
            if (gpCheck.Checked)
            {
                total = total + 1;
            }
            if (oniCheck.Checked)
            {
                total = total + 1;
            }

            return Convert.ToInt32(total);
        }
    }
}