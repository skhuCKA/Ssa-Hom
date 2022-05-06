using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Data : MonoBehaviour
{

    public Dictionary<int, StatTest> statDict = new Dictionary<int, StatTest>();
    // Start is called before the first frame update
    public void Start()
    {
        statDict = LoadJson<StatDataTest, int, StatTest>("StatDataTest").MakeDict();
    }

    Load LoadJson<Load, Key, Value>(string path) where Load : Loader<Key, Value>
    {
        TextAsset textAsset = Resources.Load<TextAsset>(path);
        return JsonUtility.FromJson<Load>(textAsset.text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class StatTest
{
    public List<StatTest> stats = new List<StatTest>();
    public void Init()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("StatDataTest");
        StatDataTest data = JsonUtility.FromJson<StatDataTest>(textAsset.text);

    }

   
    public int id;
    public string name;
    public string type;
    public int level;
    public int ad;
    public int ap;
    public int hp;
    public int mp;
    public int skillIndex1;
    public int skillIndex2;


}

[Serializable]
public class StatDataTest : Loader<int, StatTest>
{
    public List<StatTest> stats = new List<StatTest>();
    
    public Dictionary<int, StatTest> MakeDict()
    {
        Dictionary<int, StatTest> dict = new Dictionary<int, StatTest>();
        foreach (StatTest s in stats)
        {
            if (!dict.ContainsValue(s))
            {
                dict.Add(s.id, s);
            }

        }
        return dict;
    }

}

public interface Loader<Key, Value>
{
    public Dictionary<Key, Value> MakeDict();
}