using System.Configuration;
using System.IO;
using System.Web;
using System.Xml;

namespace FS.OA.Common
{
    public class XmlHelper
    {
        private readonly static string XML_FILE = ConfigurationManager.AppSettings["MessageFils"];

        public static string GetMessage(string key)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();

            var filePath = HttpContext.Current.Server.MapPath(XML_FILE);

            if (File.Exists(filePath))
            {
                doc.Load(filePath);

                XmlNodeList nodes = doc.GetElementsByTagName("NODE");

                for (int i = 0; i < nodes.Count; i++)
                {
                    XmlAttribute att = nodes[i].Attributes["KEY"];

                    if (att.Value == key)
                    {
                        return nodes[i].FirstChild.Value;
                    }
                }
            }

            return string.Empty;
        }

        public static bool GetDeleteFlg()
        {
            return bool.Parse(ConfigurationManager.AppSettings["DeleteFlg"].ToLower());
        }
    }
}
