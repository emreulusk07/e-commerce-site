using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsAllow { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }
    }
}
