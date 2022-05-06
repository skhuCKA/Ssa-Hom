using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class StatInfo : MonoBehaviour
{
    public StatData statData;

    [ContextMenu("To Json Data")]
    public void SaveStatDataToJson()
    {
        Debug.Log(statData.name);
        string jsonData = JsonUtility.ToJson(statData);
        string path = Path.Combine(Application.dataPath, "statData.json");
        File.WriteAllText(path, jsonData);
     
    }

    [ContextMenu("From Json Data")]
    public void LoadStatDataToJson()
    {
        string path = Path.Combine(Application.dataPath, "statData.json");
        string jsonData = File.ReadAllText(path);
        statData = JsonUtility.FromJson<StatData>(jsonData);
    }

    void Start()
    {
        StatInfo statInfo = GetComponent<StatInfo>();


    }

}
[System.Serializable]
public class StatData
{
    public int id;
    public string name;
    public int level;
    public int ad;
    public int ap;
    public int hp;
    public int mp;

}

