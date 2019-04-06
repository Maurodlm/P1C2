using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCC2.Models
{
    public enum PayType
    {
        Cash,
        CreditCard,
        Check
    }
    public enum StatusType
    {
        Activo,
        Inactivo
    }
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Pounds { get; set; }
        public int Age { get; set; }
        public decimal Size { get; set; }
        [Required]
        public PayType Pay { get; set; }
        public StatusType Status { get; set; }
    }
}