using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface IBidRepo
    {
        List<Bid> GetBids();
        Bid GetBid(int id);

        void Add(Bid entity);
        void Delete(Bid entity);
        void Update(Bid entity);
    }
}
