using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.Calculators.DataModels
{
    public class IntelModel
    {
        public string Id { get; set; }
        public string Topic { get; set; }
        public string Url { get; set; }
        public string Province { get; set; }
        public string HtmlData { get; set; }
        public DateTime IntelTimestamp { get; set; }
        public string SimpleData { get; set; }
    }
}
