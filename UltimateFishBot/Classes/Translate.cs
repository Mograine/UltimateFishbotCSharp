﻿using System;
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
                    // Example : ./Resources/English.xml
                    doc.Load("./Resources/" + Properties.Settings.Default.Language + ".xml");
                    m_elements = doc.DocumentElement;
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                }
            }
        }

        static public string GetTranslate(string formName, string nodeName, params Object[] list)
        {
            ExtractElements();
            string returnText = "MISSING TRANSLATION";

            // If we can't open the Translation file, everything will appear as "MISSING TRANSLATION"
            if (m_elements == null)
                return returnText;

            try
            {
                XmlNodeList formList = m_elements.GetElementsByTagName(formName);

                // Try to find the correct translation for formName and nodeName
                foreach (XmlNode mainNode in formList)
                    foreach (XmlNode node in mainNode.ChildNodes)
                        if (node.Name == nodeName)
                        {
                            returnText = node.InnerText;
                            break;
                        }

                // Remove the extras spaces from each lines
                returnText = string.Join("\n", returnText.Split('\n').Select(s => s.Trim()));

                // Replace {int} in text by variables. Ex : "Waiting for Fish ({0}/{1}s) ..."
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
