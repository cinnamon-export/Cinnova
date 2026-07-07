using Cinnova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnova.Services
{
  
        public class InventoryService
        {
            private List<Inventory> items = new List<Inventory>();

            public List<Inventory> GetAll()
            {
                return items;
            }

            public void Add(Inventory item)
            {
                items.Add(item);
            }

            public void Update(Inventory item)
            {
                var existing = items.FirstOrDefault(x => x.ItemId == item.ItemId);
                if (existing != null)
                {
                    existing.Category = item.Category;
                    existing.Quantity = item.Quantity;
                    existing.Unit = item.Unit;
                    existing.MinStock = item.MinStock;
                    existing.Status = item.Status;
                    existing.LastUpdated = item.LastUpdated;
                }
            }

            public void Delete(int id)
            {
                var item = items.FirstOrDefault(x => x.ItemId == id);
                if (item != null)
                {
                    items.Remove(item);
                }
            }

            public List<Inventory> Search(string keyword)
            {
                return items.Where(x =>
                    x.Category.ToLower().Contains(keyword.ToLower())).ToList();
            }
        }
    
}



