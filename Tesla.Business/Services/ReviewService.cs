using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesla.Data;
using Tesla.Data.Entities;

namespace Tesla.Business.Services
{
    public interface IReviewService
    {
        Task<Review> Add(string content);

    }
    public class ReviewService : IReviewService
    {
        private readonly ApplicationContext _context;

        public ReviewService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Review> Add(string content)
        {
            var review = new Review
            {
                Content = content
            };

            var result = await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
