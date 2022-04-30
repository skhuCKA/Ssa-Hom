using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;
using System.IO;

public class TestXML : MonoBehaviour
{

    string xmlFileName = "StatDataTest";

    // Start is called before the first frame update
    void Start()
    {
        LoadXML(xmlFileName);
    }

    private void LoadXML(string _fileName)
    {
        string path = Path.Combine(Application.dataPath, "StatDataTest.xml");
        Debug.Log(File.ReadAllText(path));
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList all_nodes = xmlDoc.SelectNodes("rows/row");
        foreach(XmlNode node in all_nodes)
        {
            Debug.Log(node.SelectSingleNode("id").InnerText);
            Debug.Log(node.SelectSingleNode("name").InnerText);
            Debug.Log(node.SelectSingleNode("type").InnerText);
            Debug.Log(node.SelectSingleNode("ad").InnerText);
            Debug.Log(node.SelectSingleNode("ap").InnerText);
            Debug.Log(node.SelectSingleNode("hp").InnerText);
            Debug.Log(node.SelectSingleNode("mp").InnerText);
            //Debug.Log(node.SelectSingleNode("skillindex1").InnerText);
            //Debug.Log(node.SelectSingleNode("skillindex2").InnerText);

        }
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];

        character.SelectSingleNode("name").InnerText = "¥Ÿ¿‚¿Ã";

        xmlDoc.Save("./Assets/Resources/Character.xml");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
