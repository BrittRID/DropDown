using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebContactsRedo.Models
{
    public class BrandIndexVM
    {
        
        private SelectList _BrandSelectList { get; set; }

        public SelectList BrandSelectList
        {
            get
            {
                if(_BrandSelectList != null)
                    return _BrandSelectList;
                //return brandList

            }
        }

        private List<Brand> GetBrand()
        {
            var Brand = new List<Brand>();
            Brand.Add(new Brand() { Id = 1, Title = "Proclear 1" });
            Brand.Add(new Brand() { Id = 2, Title = "Proclear 2" });
            Brand.Add(new Brand() { Id = 3, Title = "Proclear 3" });
            Brand.Add(new Brand() { Id = 4, Title = "Proclear 4" });
        }

    }
}
