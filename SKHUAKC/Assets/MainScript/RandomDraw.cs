using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomDraw : MonoBehaviour
{
    GameObject stat_info;
    public GameObject DrawShop;
    public GameObject DrawWindow;

    public Image DrawImage;

    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;
    public Sprite Image11;
    public Sprite Image12;

    public int RandomInt;
    public int c;
    public bool on = false;

    NoticeUI _notice;

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }
    GameObject cointext;

    // Start is called before the first frame update
    void Start()
    {
        DrawWindow.SetActive(false);
        this.cointext = GameObject.Find("cointext"); // 이게 이제 코인 값을 찾아서 텍스트를 여기다 쓰는 코드
        stat_info = GameObject.Find("stat_info");
        
        if(stat_info != null)
        {
            this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RandomInt = Random.Range(1, 11);
        //int coin = int.Parse(this.cointext.GetComponent<Text>().text); // 이런 식으로 받아서 해줘야해
        // t//his.c = coin;
        //if (on)
        //{
        //   DrawShop.SetActive(false);
        //    this.c = coin;
        //   coin -= 50;
        //       
        //   this.cointext.GetComponent<Text>().text = coin.ToString();
        // Debug.Log(this.cointext.GetComponent<Text>().text = coin.ToString());
        //   this.on = false;
        //  _notice.SUB("엽전이 부족합니다!");

        //  }
        // else if(this.c < 50)
        // {

        //     DrawShop.SetActive(true);
        //   _notice.SUB("엽전이 부족합니다!");
        //
        //  }//

    }

    public void OneDraw()
    {
        RandomInt = Random.Range(1, 11);
        this.c = int.Parse(this.cointext.GetComponent<Text>().text); // 이런 식으로 받아서 해줘야해
        

        Debug.Log(this.c);
        if (this.c >= 50)
        {
            
            
            this.on = true;
            DrawShop.SetActive(false);
            DrawWindow.SetActive(true);
            this.c -= 50;
            this.cointext.GetComponent<Text>().text = this.c.ToString();
            Debug.Log(this.cointext.GetComponent<Text>().text = this.c.ToString());
        
           

            if (RandomInt == 1)
            {
                DrawImage.sprite = Image1;
            }
            else if (RandomInt == 2)
            {
                DrawImage.sprite = Image2;
            }
            else if (RandomInt == 3)
            {
                DrawImage.sprite = Image3;
            }
            else if (RandomInt == 4)
            {
                DrawImage.sprite = Image4;
            }
            else if (RandomInt == 5)
            {
                DrawImage.sprite = Image5;
            }
            else if (RandomInt == 6)
            {
                DrawImage.sprite = Image6;
            }
            else if (RandomInt == 7)
            {
                DrawImage.sprite = Image7;
            }
            else if (RandomInt == 8)
            {
                DrawImage.sprite = Image8;
            }
            else if (RandomInt == 9)
            {
                DrawImage.sprite = Image9;
            }
            else if (RandomInt == 10)
            {
                DrawImage.sprite = Image10;
            }
            

            Invoke("CloseDraw", 2.0f);
            this.on = false;
        }
        else
        {
            this.on = false;
            DrawShop.SetActive(true);
            _notice.SUB("엽전이 부족합니다!");

        }
            
    }
    public void OneDrawStat()
    {

        RandomInt = Random.Range(1, 13);
        this.c = int.Parse(this.cointext.GetComponent<Text>().text); // 이런 식으로 받아서 해줘야해


        Debug.Log(this.c);
        if (this.c >= 50)
        {


            this.on = true;
            DrawShop.SetActive(false);
            DrawWindow.SetActive(true);
            this.c -= 50;
            this.cointext.GetComponent<Text>().text = this.c.ToString();
            Debug.Log(this.cointext.GetComponent<Text>().text = this.c.ToString());



            if (RandomInt == 1)
            {
                DrawImage.sprite = Image1;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 2)
            {
                DrawImage.sprite = Image2;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 3)
            {
                DrawImage.sprite = Image3;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 4)
            {
                DrawImage.sprite = Image4;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 5)
            {
                DrawImage.sprite = Image5;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 6)
            {
                DrawImage.sprite = Image6;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 7)
            {
                DrawImage.sprite = Image7;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 8)
            {
                DrawImage.sprite = Image8;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 3;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 9)
            {
                DrawImage.sprite = Image9;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 3;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 10)
            {
                DrawImage.sprite = Image10;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 4;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 11)
            {
                DrawImage.sprite = Image11;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 4;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 12)
            {
                DrawImage.sprite = Image12;
                
                int i = PlayerPrefs.GetInt("stat_info");
                i += 5;
                Debug.Log(i + "개 획득");
                PlayerPrefs.SetInt("stat_info", i);
            }
            this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
            Invoke("CloseDraw", 2.0f);
            this.on = false;
        }

        else
        {
            this.on = false;
            DrawShop.SetActive(true);
            _notice.SUB("엽전이 부족합니다!");

        }
    }

        public void CloseDraw()
    {
        DrawImage.sprite = null;
        DrawShop.SetActive(true);
        DrawWindow.SetActive(false);
    }

}
