using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Seller : User, IEntity
    {
        [Key]
        public int Id { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
