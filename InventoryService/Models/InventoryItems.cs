using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Models
{
    public class InventoryItems
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
