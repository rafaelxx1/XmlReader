using System.Xml.Linq;
using XmlGoNew.Controller;
using XmlGoNew.Model;

foreach (Xml element in XmlReaderIO.getXmlData(@"C:\Users\fraca\source\repos\XmlGoNew\XmlGoNew\File\stuffs.xml"))
{
    Console.WriteLine(element.id);
    Console.WriteLine(element.title);
    Console.WriteLine(element.module);
    Console.WriteLine(element.value);
    Console.WriteLine(element.info);

    Console.WriteLine("******************************************************");

}