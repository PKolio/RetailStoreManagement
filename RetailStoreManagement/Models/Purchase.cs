using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailStoreManagement.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        [ForeignKey("ProductId)")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }


    }
}
