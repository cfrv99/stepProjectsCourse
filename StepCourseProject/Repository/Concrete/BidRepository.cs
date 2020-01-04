using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Concrete
{
    public class BidRepository : IBidRepo
    {
        private readonly AppDbContext context;

        public BidRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Bid entity)
        {
            if (entity != null)
            {
                context.Bids.Add(entity);
                context.SaveChanges();
            }
            throw new Exception("Bid was not found");
        }

        public void Delete(Bid entity)
        {
            if (entity != null)
            {
                context.Bids.Remove(entity);
                context.SaveChanges();
            }
            throw new Exception("Bid was not found!!!");
        }

        public Bid GetBid(int id)
        {
            if (id > 0)
            {
                var bid = context.Bids.FirstOrDefault(i => i.Id == id);
                return bid;
            }
            throw new Exception("Bid was not found");
        }

        public List<Bid> GetBids()
        {
            return context.Bids.ToList();
        }

        public void Update(Bid entity)
        {
            if (entity != null)
            {
                context.Bids.Update(entity);
                context.SaveChanges();
            }

            throw new Exception("Bid was not found!!!");
        }
    }
}
