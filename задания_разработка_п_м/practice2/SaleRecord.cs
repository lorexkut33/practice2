using System;
using System.Collections.Generic;
using System.Text;

namespace задания_разработка_п_м.practice2
{
    internal class SaleRecord
    {
       
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }

            public SaleRecord(int productId, string productName, int quantity, decimal totalPrice)
            {
                ProductId = productId;
                ProductName = productName;
                Quantity = quantity;
                TotalPrice = totalPrice;
            }
      
    }
}
