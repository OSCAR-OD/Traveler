using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TravelFeedbackDTO : TourPackageDTO
    {
        public List<FeedbackDTO> Feedbacks { get; set; }
        public TravelFeedbackDTO()
        {
            Feedbacks = new List<FeedbackDTO>();
        }
    }
}
