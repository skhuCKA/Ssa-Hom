using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickButton : MonoBehaviour
{
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

    public int RandomInt;


    NoticeUI _notice;

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }
    GameObject cointext;

    // Start is called before the first frame update
    void Start()
    {
        this.cointext = GameObject.Find("cointext");
    }

    // Update is called once per frame
    void Update()
    {
        RandomInt = Random.Range(1, 11);
        int coin = int.Parse(this.cointext.GetComponent<Text>().text);

        
        if (Input.GetMouseButtonDown(0))
        {
            if (coin >= 50) // 50���� ������ ��
            {
                // ���� �� �ٷ� �ﰢ������ ������ �ٲ��

                coin -= 50; // ���⼭ �����ŵ� -> 0���� coin���� �����ǰ�
                this.cointext.GetComponent<Text>().text = coin.ToString(); // coin���� 0���� ���ϱ� �� �ٵ� �̰� ������ �� �ٲٸ� �ؿ��� ������ ������ �ν��� �� ��
                Debug.Log(this.cointext);
            }
            else
            {


                _notice.SUB("������ �����մϴ�!");
            }
        }

    }

    public void OneDraw()
    {
        
            DrawShop.SetActive(false);
            DrawWindow.SetActive(true);

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
        
    }

    public void CloseDraw()
    {
        DrawImage.sprite = null;
        DrawShop.SetActive(true);
        DrawWindow.SetActive(false);
    }
  
}
