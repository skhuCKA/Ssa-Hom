using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;


public class TestJson : MonoBehaviour
{
    public TextAsset dataStatList;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(dataStatList);
        string path = Path.Combine(Application.dataPath, "data.json");
        string path2 = Path.Combine(Application.dataPath, "data1.json");
        Debug.Log(File.ReadAllText(path));
        JsonData myData = JsonMapper.ToObject(dataStatList.text);
        Debug.Log(myData);
        Debug.Log(String.Join(",", myData));
        //string json = JsonConvert.SerializeObject(myData, Formatting.Indented);
       
        //Debug.Log(json);
        //string myData1 = PlayerPrefs.SetString(,myData);
        // string myData1 = JsonConvert.SerializeObject(myData, Formatting.Indented);
        // Debug.Log(myData1);
        // Debug.Log(myData1.ToString());
        myData[0]["level"] = "3";

        
        
        
        //File.WriteAllText(path2, myData2.ToString());
        Debug.Log(myData[0]["level"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

public class DataJsonInfo
{
    public int[] id;
    public string[] name;
    public string[] type;
    public int[] level;
    public int[] ad;
    public int[] ap;
    public int[] hp;
    public int[] mp;
    public int[] skillindex1;
    public int[] skillindex2;

}
