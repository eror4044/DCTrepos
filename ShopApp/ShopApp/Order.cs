using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShopApp
{  [Serializable]
   public class Order
    {
        public User user;
        public string address;
        public List<Product> backet;
        public string deliveryMethod;
        public string payMethod;
        public DateTime orderDate;

      

        public void OredrToXML() {
            
            XmlSerializer formatter = new XmlSerializer(typeof(Order));

            using (FileStream fs = new FileStream($"Order.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }

        }
    }
    
}
