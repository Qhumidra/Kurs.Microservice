using Kurs.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Services.Order.Domain.OrderAggregate
{
    public class Order : Entity, IAggregatedRoot
    {
        public DateTime CreateDate { get; set; }
        public Address Adress { get; set; }
        public string BuyerId { get; set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order()
        {

        }

        public Order(string buyerId, Address adress)
        {
            _orderItems = new List<OrderItem>();
            CreateDate = DateTime.Now;
            BuyerId = buyerId;
            Adress = adress;
        }

        public void AddOrderItem(string productId, string productName, decimal price, string pictureUrl)
        {
            var existProduct = _orderItems.Any(x => x.ProductId == productId);
            if (!existProduct)
            {
                var newOrderItem = new OrderItem(productId, productName, pictureUrl, price);

                _orderItems.Add(newOrderItem);
            }
        }

        public decimal GetTotalPrice => _orderItems.Sum(x => x.Price);

    }
}
