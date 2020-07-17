using System;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Work.Domain.Entities;
using Work.Domain.Repositories.Abstract;

namespace Work.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsInRepository : IServiceItemsInRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsInRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems_in;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems_in.FirstOrDefault(x => x.Id == id);
        }

        

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems_in.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
