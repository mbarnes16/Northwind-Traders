using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_Traders.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public Decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}