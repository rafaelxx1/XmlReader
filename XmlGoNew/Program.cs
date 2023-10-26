using System.Xml.Linq;
using XmlGoNew.Build;
using XmlGoNew.Controller;
using XmlGoNew.Model;


string data = @"C:\Users\fraca\source\repos\XmlGoNew\XmlGoNew\File\stuffs.xml";
List<Xml> list = XmlReaderIO.getXmlData(data);



foreach (XmlBox element in XmlReaderIO.ordernedXml(list))
{
    Console.WriteLine(element.type + " [ DEPARTAMENTO *");
    Console.WriteLine(element.id);
    Console.WriteLine(element.title);
    Console.WriteLine(element.module);
    Console.WriteLine(element.value);
    Console.WriteLine(element.info);

    Console.WriteLine("******************************************************");

}

FileXml.xmlFile();