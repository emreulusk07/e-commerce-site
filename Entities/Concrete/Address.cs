using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
