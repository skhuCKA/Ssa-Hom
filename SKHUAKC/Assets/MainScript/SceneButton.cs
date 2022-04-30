using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class SceneButton : MonoBehaviour
{
    GameObject GachaButton;
    GameObject StatBtn;
    GameObject SkillBtn;

    public void GachaInfoScene()
    {

        GachaButton.SetActive(false);
        StatBtn.SetActive(true);
        SkillBtn.SetActive(true);
        
        // SceneManager.LoadScene("GachaScene");
    }

    public void CharacterInfoScene()
    {
        
        Debug.Log("버튼 눌림");
        SceneManager.LoadScene("CharacterInfoScene");
    }

    public void GoGachaSkillScene()
    {

        Debug.Log("버튼 눌림");
        SceneManager.LoadScene("GachaScene");
    }

    public void GoGachaStatScene()
    {

        Debug.Log("버튼 눌림");
        SceneManager.LoadScene("GachaSceneII");
    }

    public void GoMainScene()
    {
        Debug.Log("버튼 눌림");
        SceneManager.LoadScene("GameScene");
    }

    public void GoStatScene()
    {
        

        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        string C_N = clickObject.name;
        switch (C_N)
        { 
            case "C1":
                PlayerPrefs.SetInt("id", 0);
                break;
            case "C2":
                PlayerPrefs.SetInt("id", 1);
                break;
            case "C3":
                PlayerPrefs.SetInt("id", 2);
                break;
            case "C4":
                PlayerPrefs.SetInt("id", 3);
                break;
            case "C5":
                PlayerPrefs.SetInt("id", 4);
                break;
            case "C6":
                PlayerPrefs.SetInt("id", 5);
                break;
            case "C7":
                PlayerPrefs.SetInt("id", 6);
                break;
            case "C8":
                PlayerPrefs.SetInt("id", 7);
                break;
            case "C9":
                PlayerPrefs.SetInt("id", 8);
                break;
            case "C10":
                PlayerPrefs.SetInt("id", 9);
                break;
            case "C11":
                PlayerPrefs.SetInt("id", 10);
                break;
            case "C12":
                PlayerPrefs.SetInt("id", 11);
                break;
            case "C13":
                PlayerPrefs.SetInt("id", 12);
                break;
            case "C14":
                PlayerPrefs.SetInt("id", 13);
                break;
            case "C15":
                PlayerPrefs.SetInt("id", 14);
                break;
        }
        
        Debug.Log(PlayerPrefs.GetFloat("id"));
        SceneManager.LoadScene("CharaterStatScene");

    }

    // Start is called before the first frame update
    void Start()
    {
        GachaButton = GameObject.Find("GachaButton");
        StatBtn = GameObject.Find("StatBtn");
        SkillBtn = GameObject.Find("SkillBtn");
        if (GachaButton != null)
        {
            GachaButton.SetActive(true);
            StatBtn.SetActive(false);
            SkillBtn.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
