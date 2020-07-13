using System;
using System.Linq;
using Work.Domain.Entities;

namespace Work.Domain.Repositories.Abstract
{
    public interface IServiceItemsInRepository
    {
        IQueryable<ServiceItemIn> GetServiceItems();
        ServiceItemIn GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItemIn entity);
        void DeleteServiceItem(Guid id);
    }
}
