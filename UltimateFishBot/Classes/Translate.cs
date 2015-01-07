using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UltimateFishBot.Classes
{
    class Translate
    {
        static private XmlElement m_elements = null;

        static private void ExtractElements()
        {
            if (m_elements == null)
            {
                XmlDocument doc = new XmlDocument();

                try
                {
                    doc.Load("./Resources/" + Properties.Settings.Default.Language + ".xml");
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                }

                m_elements = doc.DocumentElement;
            }
        }

        static public string GetTranslate(string form, string nodeName, params Object[] list)
        {
            ExtractElements();
            string returnText = "MISSING TRANSLATION";

            if (m_elements == null)
                return returnText;

            try
            {
                XmlNodeList formList = m_elements.GetElementsByTagName(form);

                foreach (XmlNode mainNode in formList)
                    foreach (XmlNode node in mainNode.ChildNodes)
                        if (node.Name == nodeName)
                            returnText = node.InnerText;

                returnText = string.Join("\n", returnText.Split('\n').Select(s => s.Trim()));
                returnText = String.Format(returnText, list);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            return returnText;
        }
    }
}
