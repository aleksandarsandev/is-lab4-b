using EShop.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace EShopAdminApplication.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid ConcertId { get; set; }
        public Concert? Concert { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}
