using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.EntityLayer.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        //bu kısımlar slider için bu şekilde tanımlandı. 3 sayfa olduğu varsayılarak 3'e kadar property tanımladık.
        public string Title1 { get; set; }
        public string Description1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public string Title3 { get; set; }
        public string Description3 { get; set; }
    }
}
