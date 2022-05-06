using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaDirector : MonoBehaviour
{
    GameObject cointext;
    // Start is called before the first frame update
    void Start()
    {
        this.cointext = GameObject.Find("cointext");
        int length = 100;
        this.cointext.GetComponent<Text>().text = length.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
