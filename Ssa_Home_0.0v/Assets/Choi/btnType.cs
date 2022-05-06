using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class btnType : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public GameObject PopupSet;
    public GameObject StartCredit;
    public GameObject TextSound;
    public GameObject BackGroup;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    bool isSound;
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case BTNType.New:
                SceneLoad.LoadSceneHandle("GameScene", 0);
                break;
            case BTNType.Continue:
                SceneLoad.LoadSceneHandle("GameScene", 1);
                break;
            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Sound:
                if(isSound)
                {
                    TextSound.GetComponent<Text>().text = "Sound On";
                    Debug.Log("사운드OFF");
                    AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
                }
                else
                {
                    Debug.Log("사운드ON");
                    TextSound.GetComponent<Text>().text = "Sound Off";
                    AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
                }
                isSound = !isSound;
                break;
            case BTNType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("종료하기");
                break;
        }
    }


    public void OnClickNext()
    {
        PopupSet.SetActive(true);
    }

    public void OnClickStage()
    {
        
    }

    public void OnClickExit()
    {
        StartCredit.SetActive(true);
        BackGroup.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneLoad.LoadSceneHandle("GameScene", 0);
        }
    }
    public void CanvasGroupOn(CanvasGroup cg)
     {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.03f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
