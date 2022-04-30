using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    public Button YB;
    public delegate void OnClick();
    private event OnClick yesClick;
    // Start is called before the first frame update
    void Start()
    {
        YB.onClick.AddListener(X);
    }
    public void YesClickAction(OnClick x)
    {
        yesClick = x;
    }
    void X()
    {
        yesClick();
    }

 
}
