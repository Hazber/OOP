using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Reflection;
using System.Xml.Serialization;

namespace Laba1
{
    public abstract class FileCreator
    {
        public abstract byte[] FileSave(List<Item> catalog);
        public abstract List<Item> FileOpen(byte[] data);
    }
    public class BinaryFileCreator : FileCreator
    {
        public override byte[] FileSave(List<Item> catalog)
        {
            BinaryFormatter Formater = new BinaryFormatter();
            MemoryStream MS = new MemoryStream();
            Formater.Serialize(MS, catalog);
            return MS.ToArray();
        }
        public override List<Item> FileOpen(byte[] data)
        {
            List<Item> catalog;
            BinaryFormatter Formater = new BinaryFormatter();
            MemoryStream MS = new MemoryStream(data);
            catalog = (List<Item>)Formater.Deserialize(MS);
            return catalog;
        }
    }

    public class JsonFileCreator : FileCreator
    {
        public override byte[] FileSave(List<Item> Catalog)
        {
            JsonSerializerSettings Settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string Serialized = JsonConvert.SerializeObject(Catalog, Settings);
            byte[] ret = System.Text.Encoding.UTF8.GetBytes(Serialized);
            return ret;
        }
        public override List<Item> FileOpen(byte[] data)
        {
            string Serialized = Encoding.UTF8.GetString(data);
            JsonSerializerSettings Settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            List<Item> Catalog = JsonConvert.DeserializeObject<List<Item>>(Serialized, Settings);
            return Catalog;
        }
    }

    public class AuthorFileCreator : FileCreator
    {
        public override byte[] FileSave(List<Item> Catalog)
        {
            string Serialized = null;
            foreach (Item item in Catalog)
            {
                Serializer(ref Serialized, item);
                Serialized += "};";
            }
            Serialized += "$";
            byte[] ret = System.Text.Encoding.UTF8.GetBytes(Serialized);
            return ret;
        }

        public override List<Item> FileOpen(byte[] data)
        {
            string Serialized = Encoding.UTF8.GetString(data);
            List<Item> Localcatalog = new List<Item>();
            while (Serialized[0] != '$')
            {
                Localcatalog.Add(Deserializer(ref Serialized));
            }
            return Localcatalog;
        }


        private static void Serializer(ref string str, object obj)
        {
            Item item = (Item)obj;
            Type type = Type.GetType("Laba1." + item.Category.ToString(), false, true);
            str += type.ToString() + "{";
            foreach (FieldInfo param in type.GetFields())
            {
                if (param.FieldType.ToString().IndexOf("Laba1.") > -1 && param.FieldType.ToString().IndexOf("+") <= -1)
                {
                    Serializer(ref str, param.GetValue(item));
                    str += "},";
                }
                else
                {
                    str += param.FieldType.ToString() + ":" + param.GetValue(item) + ",";
                }
            }
        }
        private static Type FieldType(ref string str, int ind)
        {
            Type objtype = Type.GetType(str.Substring(0, ind), false, true);
            str = str.Remove(0, ind + 1);//удаляем тип из строки
            return objtype;
        }

        private static string GetStringValue(ref string str)
        {
            int ind = str.IndexOf(',');
            string s = str.Substring(0, ind);
            str = str.Remove(0, ind + 1);
            return s;
        }

        private static Item Deserializer(ref string str)//Десерт
        {
            object cat = null;
            int index0 = str.IndexOf('{');
            Type objtype = FieldType(ref str, index0);
            FieldInfo[] fields = objtype.GetFields();
            Type[] types = new Type[fields.Length-1]; //чтобы првоерить к чему приводить значения
            Type t;
            object[] values = new object[fields.Length-1];
            int i = 0;
            foreach (var param in fields)
            {
                int index1 = str.IndexOf(':');
                int index2 = str.IndexOf('{');
                if (index1 < index2 || index2 == -1)
                {
                    t = FieldType(ref str, index1);
                    if (t.Name == "TCategories")
                    {
                        string value_str1 = GetStringValue(ref str);
                        cat = Enum.Parse(t, value_str1);

                    }
                    else
                    {
                        types[i] = t;
                        string value_str = GetStringValue(ref str);
                        if (types[i].Name == "Int32")
                            values[i] = Convert.ToInt32(value_str);
                        else if (types[i].Name == "String")
                            values[i] = value_str;
                        else if (types[i].Name == "Double")
                            values[i] = Convert.ToDouble(value_str);
                        else if (types[i].Name == "Boolean")
                            values[i] = Convert.ToBoolean(value_str);
                        else
                        {

                            values[i] = Enum.Parse(types[i], value_str);

                        }
                    }
                }
                else
                {
                    values[i] = Deserializer(ref str);
                }
                    i++;
                
            }
            str = str.Remove(0, 2);
            object obj = Activator.CreateInstance(objtype, values);
            Item Item = (Item)obj;
            Item.Category = (Item.TCategories)cat;
            return Item;
        }
    }
}