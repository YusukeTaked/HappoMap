using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToSelect : MonoBehaviour
{
    public bool Cancel;
    public GameObject CancelButton;
    public bool Cancels()
    {
        return Cancel;
    }

    //オブジェクト取得用の変数
//    [Header("メインオブジェクト")]
//    public GameObject Makimono;
//    public GameObject GuideTex;
//    public GameObject StartButton;
//    public GameObject BackButton;

//    //ボタンの位置情報取得用の変数
//    RectTransform ButtonPos1, ButtonPos2, ButtonPos3, ButtonPos4, ButtonPos5;
//    RectTransform MakimonoPos;

//    //選択されないボタンたち
//    [Header("ボタン")]
//    public GameObject otherBtn1;
//    public GameObject otherBtn2;
//    public GameObject otherBtn3;
//    public GameObject otherBtn4;
//    public GameObject otherBtn5;

//    public  SelectType selectType;
//int typeButton;
//    bool BackSelects=false;
    // Start is called before the first frame update
    void Start()
    {

        //typeButton = selectType.TypeSelect();

        //MakimonoPos = Makimono.GetComponent<RectTransform>();
        //ButtonPos1 = otherBtn1.GetComponent<RectTransform>();
        //ButtonPos2 = otherBtn2.GetComponent<RectTransform>();
        //ButtonPos3 = otherBtn3.GetComponent<RectTransform>();
        //ButtonPos4 = otherBtn4.GetComponent<RectTransform>();
        //ButtonPos5 = otherBtn5.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    //    if (BackSelects)
    //    {
    //            GuideTex.SetActive(false);
    //            StartButton.SetActive(false);
    //            BackButton.SetActive(false);

    //        if (MakimonoPos.localPosition.y < 1000)
    //        {
    //            MakimonoPos.localPosition += new Vector3(0, 300 * Time.deltaTime, 0);
    //        }
    //        else if (MakimonoPos.localPosition.y >= 1000)
    //        {                        
    //            Makimono.SetActive(false);

    //            if (typeButton == 1)
    //            {
    //                if (ButtonPos1.localPosition.y > 550)
    //                {
    //                    ButtonPos1.localPosition -= new Vector3(0, 300 * Time.deltaTime, 0);
    //                }
    //                else
    //                {
    //                    otherBtn5.SetActive(true);
    //                    otherBtn2.SetActive(true);
    //                    otherBtn3.SetActive(true);
    //                    otherBtn4.SetActive(true);
    //                    BackSelects = false;
    //                }
    //            }
    //            else if (typeButton == 2)
    //            {
    //                if (ButtonPos2.localPosition.y > 350)
    //                {
    //                    ButtonPos2.localPosition -= new Vector3(0, 300 * Time.deltaTime, 0);
    //                }
    //                else
    //                {
    //                    otherBtn5.SetActive(true);
    //                    otherBtn1.SetActive(true);
    //                    otherBtn3.SetActive(true);
    //                    otherBtn4.SetActive(true);
    //                    BackSelects = false;
    //                }
    //            }
    //            else if (typeButton == 3)
    //            {
    //                if (ButtonPos3.localPosition.y > 150)
    //                {
    //                    ButtonPos3.localPosition -= new Vector3(0, 300 * Time.deltaTime, 0);
    //                }
    //                else
    //                {
    //                    otherBtn5.SetActive(true);
    //                    otherBtn2.SetActive(true);
    //                    otherBtn1.SetActive(true);
    //                    otherBtn4.SetActive(true);
    //                    BackSelects = false;
    //                }
    //            }
    //            else if (typeButton == 4)
    //            {
    //                if (ButtonPos4.localPosition.y > -150)
    //                {
    //                    ButtonPos4.localPosition -= new Vector3(0, 300 * Time.deltaTime, 0);
    //                }
    //                else
    //                {
    //                    otherBtn5.SetActive(true);
    //                    otherBtn2.SetActive(true);
    //                    otherBtn3.SetActive(true);
    //                    otherBtn1.SetActive(true);
    //                    BackSelects = false;
    //                }
    //            }
    //            else if (typeButton == 5)
    //            {
    //                if (ButtonPos5.localPosition.y > -350)
    //                {
    //                    ButtonPos5.localPosition -= new Vector3(0, 300 * Time.deltaTime, 0);
    //                }
    //                else
    //                {
    //                    otherBtn1.SetActive(true);
    //                    otherBtn2.SetActive(true);
    //                    otherBtn3.SetActive(true);
    //                    otherBtn4.SetActive(true);
    //                    BackSelects = false;
    //                }
    //            }
    //        }

    //    }
    }

    public void OnClick()
    {
        Cancel = true;
        CancelButton.SetActive(false);
    }
}
