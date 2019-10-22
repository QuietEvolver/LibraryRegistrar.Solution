using System.Collections.Generic;

namespace LibraryRegistrar.Models
{
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<CategoryItem> Categories { get;}
    }
}