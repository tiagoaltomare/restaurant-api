using Restaurants.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Application
{
    public class ReviewAppService : AppServiceBase<Review>, IReviewAppService
    {
        private readonly IReviewService _appService;

        public ReviewAppService(IReviewService appService) : base(appService)
        {
            _appService = appService;
        }
    }
}
