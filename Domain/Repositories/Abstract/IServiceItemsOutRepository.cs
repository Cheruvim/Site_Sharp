using System;
using System.Linq;
using Work.Domain.Entities;

namespace Work.Domain.Repositories.Abstract
{
    public interface IServiceItemsOutRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
