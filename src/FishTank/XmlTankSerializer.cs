using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FishTank
{
    public class XmlTankSerializer
    {
        public string Serialize(Tank tank, bool disableFormatting = true)
        {
            var xElement = new XElement("FishTank");

            if (tank == null)
                return xElement.ToString();

            xElement.Add(from f in tank.Fish
                         select new XElement("Fish", new XAttribute("type", f.GetType().FullName), new XElement("Name", f.Name)));

            return xElement.ToString(disableFormatting ? SaveOptions.DisableFormatting : SaveOptions.None);
        }
    }
}
