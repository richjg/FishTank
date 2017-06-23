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

        public Tank Deserialize(string xml)
        {
            var tank = new Tank();
            if(string.IsNullOrWhiteSpace(xml))
            {
                return tank;
            }

            var xElement = XElement.Parse(xml);
            var fishElements = xElement.Element("FishTank")?.Elements("Fish");
            foreach (var fishElement in fishElements)
            {
                var fishTypeName = fishElement.Attribute("type").Value;
                var name = (string)fishElement.Element("name");
                var fishType = Type.GetType(fishTypeName, false);
                if (fishType != null)
                {
                    var fishObject = Activator.CreateInstance(fishType) as IFish;
                    if(fishObject != null)
                    {
                        fishObject.Name = name;
                        tank.Add(fishObject);
                    }
                }
            }

            return tank;
        }
    }
}
