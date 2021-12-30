using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesOnline.Models.Admin
{
    public class Shoes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Desciption { get; set; }
        public string ImagePath { get; set; }
        
    }
}
