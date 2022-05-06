using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad1 : MonoBehaviour
{
    public Slider progressbar;
    public Text loadtext;
    GameObject PressAnyKey;
    GameObject slider;

    private void Start()
    {
        
        StartCoroutine(LoadScene());
        slider = GameObject.Find("Slider");
        PressAnyKey = GameObject.Find("PressAnyKey");
        PressAnyKey.SetActive(false);

    }
    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync("Play");
        operation.allowSceneActivation = false;

        while(!operation.isDone)
        {
            yield return null;
            if(progressbar.value < 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 0.9f, Time.deltaTime);
            }

            else if(operation.progress >= 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);
            }

            if(progressbar.value >= 1f)
            {
                slider.SetActive(false);
                if (true)
                {
                    if (Input.anyKey && progressbar.value >= 1f && operation.progress >= 0.9f)
                    {
                        operation.allowSceneActivation = true;
                    }



                    PressAnyKey.SetActive(true);
                    yield return new WaitForSeconds(0.5f);

                    if (Input.anyKey && progressbar.value >= 1f && operation.progress >= 0.9f)
                    {
                        operation.allowSceneActivation = true;
                    }


                    PressAnyKey.SetActive(false);
                    yield return new WaitForSeconds(0.5f);



                    if (Input.anyKey && progressbar.value >= 1f && operation.progress >= 0.9f)
                    {
                        operation.allowSceneActivation = true;
                    }
                }
            
            }
        }
    }
}