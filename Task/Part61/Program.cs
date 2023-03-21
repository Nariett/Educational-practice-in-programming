using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Part61
{
    public enum Color
    {
        White,
        Yellow,
        Red,
        Green
    }
    public enum Consistency
    {
        Liquid,
        Powdery,
        Solid
    }
    public enum Testimony
    {
        RespiratoryDiseases,
        BodyDisorders,
        MentalIllness,
        Restorative
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c == 0)
            {
                Console.WriteLine("Выберите пункт меню:\n1 - Создание через XMLDoc\n2 - Чтение\n3 - Добавление объектов в XML\n4 - Удаление объектов из начала\n5 - Удаление объектов из конца\n6 - Поиск по критерию\n7 - Фильтрация по цвету и консистенции\n8 - Упорядочивание по цене\n9 - Группировка по назначению");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            XDocument xdoc = new XDocument();
                            XElement tablet = new XElement("Medicine");
                            XElement tabletName = new XElement("name", "Paracetamol");
                            XElement tabletPrice = new XElement("price", "12");
                            XElement tabletDosage = new XElement("dosage", "1");
                            XElement tabletColor = new XElement("color", "White");
                            XElement tabletConsistency = new XElement("consistency", "Solid");
                            XElement tabletTestimony = new XElement("testimony", "Restorative");
                            tablet.Add(tabletName);
                            tablet.Add(tabletPrice);
                            tablet.Add(tabletDosage);
                            tablet.Add(tabletColor);
                            tablet.Add(tabletConsistency);
                            tablet.Add(tabletTestimony);
                            XElement tablet2 = new XElement("Medicine");
                            XElement tabletName2 = new XElement("name", "Flustop");
                            XElement tabletPrice2 = new XElement("price", "23");
                            XElement tabletDosage2 = new XElement("dosage", "2");
                            XElement tabletColor2 = new XElement("color", "Red");
                            XElement tabletConsistency2 = new XElement("consistency", "Solid");
                            XElement tabletTestimony2 = new XElement("testimony", "Restorative");
                            tablet2.Add(tabletName2);
                            tablet2.Add(tabletPrice2);
                            tablet2.Add(tabletDosage2);
                            tablet2.Add(tabletColor2);
                            tablet2.Add(tabletConsistency2);
                            tablet2.Add(tabletTestimony2);
                            XElement tabl = new XElement("Tablet");
                            tabl.Add(tablet);
                            tabl.Add(tablet2);
                            xdoc.Add(tabl);
                            xdoc.Save("Medicine.xml");
                            Console.WriteLine("Создан объект");
                            break;
                        }
                    case 2:
                        {
                            List<Medicine> med = new List<Medicine>();
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("Medicine.xml");
                            XmlElement xRoot = xDoc.DocumentElement;
                            foreach (XmlNode xnode in xRoot)
                            {
                                Medicine tablet = new Medicine();
                                if (xnode.Attributes.Count > 0)
                                {
                                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                                    if (attr != null)
                                        tablet.name = attr.Value;

                                    Console.WriteLine(attr.Value);
                                }
                                foreach (XmlNode childnode in xnode.ChildNodes)
                                {

                                    if (childnode.Name == "name")
                                    {
                                        tablet.name = childnode.InnerText;
                                        Console.WriteLine("Название лекарства: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "price")
                                    {
                                        tablet.price = Convert.ToDouble(childnode.InnerText);
                                        Console.WriteLine("Цена {0}", childnode.InnerText);
                                    }

                                    if (childnode.Name == "dosage")
                                    {
                                        tablet.dosage = Convert.ToDouble(childnode.InnerText);
                                        Console.WriteLine("Дозировка в день: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "color")
                                    {
                                        tablet.color = (Color)Enum.Parse(typeof(Color), childnode.InnerText, true);
                                        Console.WriteLine("Цвет лекарства: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "consistency")
                                    {
                                        tablet.consistency = (Consistency)Enum.Parse(typeof(Consistency), childnode.InnerText, true);
                                        Console.WriteLine("Состояние лекарства: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "testimony")
                                    {
                                        tablet.testimony = (Testimony)Enum.Parse(typeof(Testimony), childnode.InnerText, true);
                                        Console.WriteLine("Показание к применению: {0}", childnode.InnerText);
                                    }
                                }
                                med.Add(tablet);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Все элементы оторажены");
                            break;
                        }
                    case 3:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("Medicine.xml");
                            XmlElement xRoott = xDoc.DocumentElement;
                            XmlElement medData = xDoc.CreateElement("Medicine");
                            XmlElement nameAttr = xDoc.CreateElement("name");
                            XmlElement priceElem = xDoc.CreateElement("price");
                            XmlElement dosageElem = xDoc.CreateElement("dosage");
                            XmlElement colorElem = xDoc.CreateElement("color");
                            XmlElement consistencyElem = xDoc.CreateElement("consistency");
                            XmlElement testimonyElem = xDoc.CreateElement("testimony");
                            Console.WriteLine("Введите название");
                            XmlText nameText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите цену");
                            XmlText priceText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите дозировку");
                            XmlText dosageText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите цвет лекарства\n1 - White\n2 - Yellow\n3 - Red\n4 - Green");
                            XmlText colorText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите консистенцию лекарства\n1 - Liquid\n2 - Powdery\n3 - Solid");
                            XmlText consistencyText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите показания к применению лекарства\n1 - RespiratoryDiseases\n2 - BodyDisorders\n3 - MentalIllness\n4 - Restorative");
                            XmlText testimonyText = xDoc.CreateTextNode(Console.ReadLine());
                            nameAttr.AppendChild(nameText);
                            priceElem.AppendChild(priceText);
                            dosageElem.AppendChild(dosageText);
                            colorElem.AppendChild(colorText);
                            consistencyElem.AppendChild(consistencyText);
                            testimonyElem.AppendChild(testimonyText);
                            medData.AppendChild(nameAttr);
                            medData.AppendChild(priceElem);
                            medData.AppendChild(dosageElem);
                            medData.AppendChild(colorElem);
                            medData.AppendChild(consistencyElem);
                            medData.AppendChild(testimonyElem);
                            xRoott.AppendChild(medData);
                            xDoc.Save("Medicine.xml");
                            Console.WriteLine("Элемент добавлен");
                            break;
                        }
                    case 4:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("Medicine.xml");
                            XmlElement xRoot = xDoc.DocumentElement;
                            XmlNode firstNode = xRoot.FirstChild;
                            xRoot.RemoveChild(firstNode);
                            xDoc.Save("Medicine.xml");
                            Console.WriteLine("Первый элемент удален");
                            break;
                        }
                    case 5:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("Medicine.xml");
                            XmlElement xRoot = xDoc.DocumentElement;
                            XmlNode lastNode = xRoot.LastChild;
                            xRoot.RemoveChild(lastNode);
                            xDoc.Save("Medicine.xml");
                            Console.WriteLine("Последний элемент удален");
                            break;
                        }
                    case 6:
                        {
                            XmlDocument document = new XmlDocument();
                            document.Load("Medicine.xml");
                            Console.WriteLine("Введите название препарата");
                            string name = Console.ReadLine();
                            XmlNodeList nodes =
                            document.DocumentElement.SelectNodes($"//Medicine[name='{name}']");
                            foreach (XmlNode node in nodes)
                            {
                                Console.WriteLine(node.InnerText);
                            }
                            break;
                        }
                    case 7:
                        {
                            XDocument xdoc = XDocument.Load("Medicine.xml");
                            
                            Console.WriteLine("Вывод всех отфильтрованных значений");
                            //Выборка всех, кто от компании Samsung
                            var items = from xe in xdoc.Element("Tablet").Elements("Medicine")
                                        where xe.Element("color").Value == "Red" && xe.Element("consistency").Value == "Solid"
                                        select new Medicine
                                        {
                                            name = xe.Element("name").Value,
                                            price = (double)xe.Element("price"),
                                            dosage = (double)xe.Element("dosage"),
                                            color = (Color)Enum.Parse(typeof(Color), xe.Element("color").Value),
                                            consistency = (Consistency)Enum.Parse(typeof(Consistency), xe.Element("consistency").Value),
                                            testimony = (Testimony)Enum.Parse(typeof(Testimony), xe.Element("testimony").Value)
                                        };
                            foreach (var item in items)
                                Console.WriteLine($"Название лекарства: {item.name}\nЦена: {item.price}\nДозировки: {item.dosage}\nЦвет: {item.color}\nКонсистенция: {item.consistency}\nПоказания к применению: {item.testimony}");
                            break;
                        }
                    case 8:
                        {
                            XDocument xdoc = XDocument.Load("Medicine.xml");
                            Console.WriteLine("Вывод всех отфильтрованных значений");
                            var byprice = from xe in xdoc.Element("Tablet").Elements("Medicine")
                                          orderby xe.Element("price").Value descending
                                          select new Medicine
                                          {
                                              name = xe.Element("name").Value,
                                              price = (double)xe.Element("price"),
                                              dosage = (double)xe.Element("dosage"),
                                              color = (Color)Enum.Parse(typeof(Color), xe.Element("color").Value),
                                              consistency = (Consistency)Enum.Parse(typeof(Consistency), xe.Element("consistency").Value),
                                              testimony = (Testimony)Enum.Parse(typeof(Testimony), xe.Element("testimony").Value)
                                          };

                            foreach (var item in byprice)
                                Console.WriteLine($"Название лекарства: {item.name}\nЦена: {item.price}\nДозировки: {item.dosage}\nЦвет: {item.color}\nКонсистенция: {item.consistency}\nПоказания к применению: {item.testimony}");
                            break;
                        }
                    case 9:
                        {
                            XDocument xdoc = XDocument.Load("Medicine.xml");
                            var companies = from xe in xdoc.Element("Tablet").Elements("Medicine")
                                            group xe by (string)xe.Attribute("testimony") into g
                                            select new { testimony = g.Key, Items = g };
                            foreach (var group in companies)
                            {
                                Console.WriteLine("Testimony: " + group.testimony);

                                foreach (var item in group.Items)
                                {
                                    Console.WriteLine("Item: " + item);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода");
                            break;
                        }
                }
            }
        }
    }
}
