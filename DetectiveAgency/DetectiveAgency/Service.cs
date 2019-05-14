using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveAgency
{
    class Service
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public override string ToString()
        {
            return $"{name}  цена: {price} рублей";
        }
    }
}
