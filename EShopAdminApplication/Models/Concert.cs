using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Domain
{
    public class Concert 
    {
        public Guid Id { get; set; }
        public string ConcertName { get; set; }
        public string ConcertDescription { get; set; }
        public string ConcertImage { get; set; }
        public double Rating { get; set; }

    }
}
