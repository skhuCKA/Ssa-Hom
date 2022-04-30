using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public Button yesButton;
    public delegate void Onclick();
    public event Onclick onYesClick;

    // Start is called before the first frame update
    void Start()
    {
        yesButton.onClick.AddListener(PopupYesAction);
    }

    void SetYesListener(Onclick action)
    {
        onYesClick = action;
    }
    public void PopupYesAction()
    {
        onYesClick();
    }
}
