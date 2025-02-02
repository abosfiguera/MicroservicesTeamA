﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaSearch.Models
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Column("OrderId", TypeName = "int")]
        public int OrderId { get; set; }

        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("ProductoId", TypeName = "int")]
        public int ProductoId { get; set; }

        [Required]
        [Column("Quantity", TypeName = "int")]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column("Price", TypeName = "decimal(18,4)")]
        public double Price { get; set; }
        public virtual Producto? Producto { get; set; } 
    }
}