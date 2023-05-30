using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ApprovalStatus { get; set; }
        public int PaymentType { get; set; }
        public string Number { get; set; }
        public string Notes { get; set; }
        public string ShippingTrackingNumber { get; set; }
    }
}
