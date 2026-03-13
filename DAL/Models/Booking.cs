using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        public Booking()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int BookingId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int TourPackageId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public int NumberOfPeople { get; set; }

        public string SpecialRequests { get; set; }

       
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("TourPackageId")]
        public virtual TourPackage TourPackage { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }

}
