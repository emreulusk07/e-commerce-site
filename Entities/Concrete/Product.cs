using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public string MainImage { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Gender { get; set; }
        public int Amount { get; set; }
        public int SalesAmount { get; set; }
        public string Description { get; set; }
        public int ApprovalStatus { get; set; }
        public float Weight { get; set; }
    }
}
