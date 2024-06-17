using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSSimaticMLTools
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Tuple<string, string,string> GetInfo(string text)
        {
            string type;
            string name;
            string number;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(text);
            //Get Type, Name, and Number for FB, FC, DB or OB
            XmlNode node = xmlDoc.SelectSingleNode("Document/SW.Blocks.FB");
            if (node != null)
            {
                type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                name = node["AttributeList"]["Name"].InnerText;
                number = "FB" + node["AttributeList"]["Number"].InnerText;
            }
            else
            {
                node = xmlDoc.SelectSingleNode("Document/SW.Blocks.FC");
                if (node != null)
                {
                    type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                    name = node["AttributeList"]["Name"].InnerText;
                    number = "FC" + node["AttributeList"]["Number"].InnerText;
                }
                else
                {
                    node = xmlDoc.SelectSingleNode("Document/SW.Blocks.InstanceDB");
                    if (node != null)
                    {
                        type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                        name = node["AttributeList"]["Name"].InnerText;
                        number = "DB" + node["AttributeList"]["Number"].InnerText;
                    }
                    else
                    {
                        node = xmlDoc.SelectSingleNode("Document/SW.Blocks.OB");
                        //OB Support is Limited
                        if (node != null)
                        {
                            type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                            name = node["AttributeList"]["Name"].InnerText;
                            number = "OB" + node["AttributeList"]["Number"].InnerText;
                        }
                        else
                        {
                            type = "Null";
                            name = "Null";
                            number = "Null";
                        }
                    }
                }
            }
                return Tuple.Create(type, name, number);
        }
    }
}
