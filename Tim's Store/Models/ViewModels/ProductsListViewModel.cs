using System.Collections.Generic;
using OutDoorProducts.Models;

namespace OutDoorProducts.Models.ViewModels {

    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
