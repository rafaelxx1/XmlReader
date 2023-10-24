using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XmlGoNew.Model;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace XmlGoNew.Controller
{
    internal class XmlReaderIO
    {
        public static List<Xml> getXmlData(string xmlPath)
        {
                    string xml = System.IO.File.ReadAllText(xmlPath);
                    byte[] byteArray = Encoding.UTF8.GetBytes(xml);

                    MemoryStream ms = new MemoryStream(byteArray);
                    XmlReader xr = XmlReader.Create(ms);

                    Xml model = new Xml();
                    List<Xml> listReader = new List<Xml>();

                    while (xr.Read())
                    {
                        if(xr.NodeType == XmlNodeType.Element && xr.Name == "Element" && xr.HasAttributes == true)
                        {
                            string id = xr.GetAttribute(0);
                            model.id = id;
                        }
                        if(xr.NodeType == XmlNodeType.Element && xr.Name == "title")
                        {
                            model.title = xr.ReadElementContentAsString();
                        }
                        if(xr.NodeType == XmlNodeType.Element && xr.Name == "module")
                        {
                            model.module = xr.ReadElementContentAsString();
                        }
                        if (xr.NodeType == XmlNodeType.Element && xr.Name == "value")
                        {
                            model.value = xr.ReadElementContentAsString();
                        }
                        if(xr.NodeType == XmlNodeType.Element && xr.Name == "info")
                        {
                            model.info = xr.ReadElementContentAsString();
                            listReader.Add(model);
                            model = new Xml();
                        }
                    }
                    return listReader;
        }


        public static List<XmlBox> ordernedXml(List<Xml> list)
        {
            XmlBox box = new XmlBox();
            List<XmlBox> boxList = new List<XmlBox>();
            foreach(Xml xml in list)
            {
                if(xml.id == "element1")
                {
                    box.type = BoxType.Skirt;
                    box.id = xml.id;
                    box.title = xml.title;
                    box.module = xml.module;
                    box.value = xml.value;
                    box.info = xml.info;

                    boxList.Add(box);
                    box = new XmlBox();
                }
                if(xml.id == "element2")
                {
                    box.type = BoxType.Shirt;
                    box.id = xml.id;
                    box.title = xml.title;
                    box.module = xml.module;
                    box.value = xml.value;
                    box.info = xml.info;

                    boxList.Add(box);
                    box = new XmlBox();
                }
                if(xml.id == "element3")
                {
                    box.type = BoxType.Coat;
                    box.id = xml.id;
                    box.title = xml.title;
                    box.module = xml.module;
                    box.value = xml.value;
                    box.info = xml.info;

                    boxList.Add(box);
                    box = new XmlBox();
                }
            }
            return boxList;
        }

    }

}
