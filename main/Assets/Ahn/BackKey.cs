using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackKey : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
