﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComprasService.Models
{
    [Table("Order")]

    public class Order
    {
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column("OrderDate", TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        [Column("ProveedorId", TypeName = "int")]
        public int ProveedorId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column("Total", TypeName = "decimal(18,4)")]
        public double Total { get; set; }

        public virtual List<OrderItem> Items { get; set; }
    }
}