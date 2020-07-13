using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Work.Domain.Entities;
using Work.Domain.Repositories.Abstract;

namespace Work.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsOutRepository : IServiceItemsOutRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsOutRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItemOut> GetServiceItems()
        {
            return context.ServiceItems_out;
        }

        public ServiceItemOut GetServiceItemById(Guid id)
        {
            return context.ServiceItems_out.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItemOut entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems_out.Remove(new ServiceItemOut() { Id = id });
            context.SaveChanges();
        }
    }
}
