using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        public static string CategoryNameAlreadyExist = "Böyle bir kategori var";
        public static string CategoryAdded ="Category eklendi";
        public static string CategoryListed="kategoriler listelendi";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductAdded="Ürünler eklendi";
        internal static string CategoryUpdated;
        internal static string ProductUpdated;
        internal static string OrderAdd;
        internal static string ProductNameAlreadyExist;
    }
}
