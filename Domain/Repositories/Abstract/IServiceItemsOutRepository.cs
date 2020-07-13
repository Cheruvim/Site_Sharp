using System;
using System.Linq;
using Work.Domain.Entities;

namespace Work.Domain.Repositories.Abstract
{
    public interface IServiceItemsOutRepository
    {
        IQueryable<ServiceItemOut> GetServiceItems();
        ServiceItemOut GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItemOut entity);
        void DeleteServiceItem(Guid id);
    }
}
