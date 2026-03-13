using TourAndTravel.DAL.Models;

namespace DAL.Repos
{
    internal class Repo
    {
        internal TourAndTravelContext db;
        internal Repo()
        {
            db = new TourAndTravelContext();
        }
    }
}