using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        // constructor that will daisy chain the Dbcontext down to the base, which is our GenericRepository<Hotel>
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
