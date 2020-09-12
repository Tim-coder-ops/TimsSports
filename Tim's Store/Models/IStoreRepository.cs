using System.Linq;

namespace OutDoorProducts.Models {
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }
    }
}
