using Work.Domain.Repositories.Abstract;

namespace Work.Domain
{
    public class DataManager
    {
        public IServiceItemsInRepository ItemsIn { get; set; }
        public IServiceItemsOutRepository ItemsOut { get; set; }

        public DataManager(IServiceItemsInRepository serviceItemsInRepository, IServiceItemsOutRepository serviceItemsOutRepository)
        {
            ItemsIn = serviceItemsInRepository;
            ItemsOut = serviceItemsOutRepository;
        }
    }
}
