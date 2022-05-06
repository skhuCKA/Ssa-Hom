using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LitJson;
using System.Xml;

public class LoadStat : MonoBehaviour
{
    GameObject level;
    GameObject _name;
    GameObject ad;
    GameObject ap;
    GameObject hp;
    GameObject mp;
    GameObject stat_info;
    public void LoadStatInfo()
    {
        this.stat_info = GameObject.Find("stat_info");
        this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();

        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.dataPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];

        this.level = GameObject.Find("level");
        this.level.GetComponent<Text>().text = character.SelectSingleNode("level").InnerText.ToString();

        this._name = GameObject.Find("name");
        this._name.GetComponent<Text>().text = character.SelectSingleNode("name").InnerText.ToString();

        this.ad = GameObject.Find("ad");
        this.ad.GetComponent<Text>().text = character.SelectSingleNode("ad").InnerText.ToString();

        this.ap = GameObject.Find("ap");
        this.ap.GetComponent<Text>().text = character.SelectSingleNode("ap").InnerText.ToString();

        this.hp = GameObject.Find("hp");
        this.hp.GetComponent<Text>().text = character.SelectSingleNode("hp").InnerText.ToString();

        this.mp = GameObject.Find("mp");
        this.mp.GetComponent<Text>().text = character.SelectSingleNode("mp").InnerText.ToString();
        /*string fileName = "statData";
        string path = Application.dataPath + "/" + fileName + ".Json";
        FileStream fileStream = new FileStream(path, FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string Json = Encoding.UTF8.GetString(data);
        infoStat = JsonUtility.FromJson<InfoStat>(Json);*/




    }
    public void StatUp()
    {
        
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        string stat = clickObject.name;

        Debug.Log(stat);

        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.dataPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];


        if (stat == "±Ù·ÂUP")
        {
            int i = int.Parse(character.SelectSingleNode("ad").InnerText);
            i += 1;
            character.SelectSingleNode("ad").InnerText = i.ToString();
            xmlDoc.Save("./Assets/StatDataTest.xml");
            this.ad = GameObject.Find("ad");
            this.ad.GetComponent<Text>().text = character.SelectSingleNode("ad").InnerText.ToString();
            /*int data = int.Parse(this.ad.GetComponent<Text>().text);
            data += 1;
            Debug.Log(data);
            this.ad.GetComponent<Text>().text = data.ToString();
            this.infoStat.ad = data;

            Debug.Log(infoStat.ad);
            string jsonData = JsonUtility.ToJson(infoStat);
            string path = Path.Combine(Application.dataPath, "statData.json");
            File.WriteAllText(path, jsonData);*/







        }
        else if(stat == "Áö·ÂUP")
        {
            int i = int.Parse(character.SelectSingleNode("ap").InnerText);
            i += 1;
            character.SelectSingleNode("ap").InnerText = i.ToString();
            xmlDoc.Save("./Assets/StatDataTest.xml");
            this.ad = GameObject.Find("ap");
            this.ad.GetComponent<Text>().text = character.SelectSingleNode("ap").InnerText.ToString();

        }
       else if(stat == "Ã¼·ÂUP")
        {
            int i = int.Parse(character.SelectSingleNode("hp").InnerText);
            i += 1;
            character.SelectSingleNode("hp").InnerText = i.ToString();
            xmlDoc.Save("./Assets/StatDataTest.xml");
            this.ad = GameObject.Find("hp");
            this.ad.GetComponent<Text>().text = character.SelectSingleNode("hp").InnerText.ToString();
        }
       else if(stat == "¸¶·ÂUP")
        {
            int i = int.Parse(character.SelectSingleNode("mp").InnerText);
            i += 1;
            character.SelectSingleNode("mp").InnerText = i.ToString();
            xmlDoc.Save("./Assets/StatDataTest.xml");
            this.ad = GameObject.Find("mp");
            this.ad.GetComponent<Text>().text = character.SelectSingleNode("mp").InnerText.ToString();

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadStatInfo();
        Debug.Log("½ºÅÈ ¾ÀÀÇ ÇÁ¸®ÆÞ id :" + PlayerPrefs.GetInt("id"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public class InfoStat
{
    public string name;
    public int id;
    public int level;
    public int ad;
    public int ap;
    public int hp;
    public int mp;
}
