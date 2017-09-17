using System;
using System.Collections.Generic;

namespace cosmetic_store.Services
{
    public class Product
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image_Link { get; set; }
        public string Product_Link { get; set; }
        public string Website_Link { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }
        public string Product_Type { get; set; }
        public List<string> Tag_List { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Product_Api_Url { get; set; }
        public List<ProductColor> Product_Colors { get; set; }
    }

    public class ProductColor
    {
        public string Hex_Value { get; set; }
        public string Colour_Name { get; set; }
    }
}