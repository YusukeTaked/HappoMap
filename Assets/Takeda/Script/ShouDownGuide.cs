using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShouDownGuide : MonoBehaviour
{
    //オブジェクト取得用の変数
    [Header("メインオブジェクト")]
    public GameObject MapButton;
    public GameObject Makimono;
    public GameObject GuideTex;
    public GameObject StartButton;
    public GameObject BackButton;

    public int typeButton;

    public static int typeSelect;


    //ボタンの位置情報取得用の変数
    RectTransform ButtonPos ;
    RectTransform MakimonoPos;

    //選択されないボタンたち
    [Header("その他のボタン")]
    public GameObject otherBtn1;
    public GameObject otherBtn2;
    public GameObject otherBtn3;
    public GameObject otherBtn4;

    private bool actMakimono=false;


    // Start is called before the first frame update
    void Start()
    {
        ButtonPos = MapButton.GetComponent<RectTransform>();
        MakimonoPos = Makimono.GetComponent<RectTransform>();
        Makimono.SetActive(false);
        GuideTex.SetActive(false);
        StartButton.SetActive(false);
        BackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(actMakimono){
            if (ButtonPos.localPosition.y <550)
            {
                ButtonPos.localPosition += new Vector3(0, 300*Time.deltaTime, 0);
            }
            else if (ButtonPos.localPosition.y >= 550)
            {
                if (MakimonoPos.localPosition.y > 100)
                {
                    MakimonoPos.localPosition -= new Vector3(0,300*Time.deltaTime,0);
                }
                else if (MakimonoPos.localPosition.y <= 100)
                {
                    GuideTex.SetActive(true);
                    StartButton.SetActive(true);
                    BackButton.SetActive(true);
                    actMakimono = false;
                }
            }
        }
      
    }
    public void OnShow()
    {
        otherBtn1.SetActive(false);
        otherBtn2.SetActive(false);
        otherBtn3.SetActive(false);
        otherBtn4.SetActive(false);
        Makimono.SetActive(true);
        actMakimono = true;
        typeSelect = typeButton;
    }
    public void OnBack()
    {
        actMakimono = false;
    }    
    public int TypeOfButton()
    {
        return typeSelect;
    }

}
