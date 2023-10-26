using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using XmlGoNew.Model;

namespace XmlGoNew.Build
{
    internal class FileXml
    {

        public static void xmlFile()
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("node", 
                  new XElement("element1","valor1"),
                  new XElement("element2","valor2")
                )
          );

            string path = @"C:\Users\fraca\source\repos\XmlGoNew\XmlGoNew\File\xml\";
            string finalPaht = System.IO.Path.Combine(path, "file1.xml");

            xml.Save( finalPaht );
        }
    }
}
