using Restaurants.Domain;

namespace Restaurants.Data.Services
{
    public class ReviewService : ServiceBase<Review>, IReviewService
    {
        private readonly IReviewRepository _serviceRepository;

        public ReviewService(IReviewRepository serviceRepository) : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
