using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public int FeedbackId { get; set; }
        public int CustomerId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
    }
}
