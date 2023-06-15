using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShouDownGuide : MonoBehaviour
{
    [Header("メインオブジェクト")]
    public GameObject MapButton, Makimono, GuideTex, StartButton;
     RectTransform ButtonPos,MakimonoPos;
    [Header("その他のボタン")]
    public GameObject otherBtn1, otherBtn2, otherBtn3, otherBtn4;
    private bool actMakimono=false;
    private bool BackSelect = false;
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonPos = MapButton.GetComponent<RectTransform>();
        MakimonoPos = Makimono.GetComponent<RectTransform>();
        Makimono.SetActive(false);
        GuideTex.SetActive(false);
        StartButton.SetActive(false);
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
                    actMakimono = false;
                }
            }
        }
        else if (BackSelect)
        {
            GuideTex.SetActive(false);
            StartButton.SetActive(false);
            if (MakimonoPos.localPosition.y < 1000)
            {
                MakimonoPos.localPosition += new Vector3(0, 300 * Time.deltaTime, 0);
            }
            else if (MakimonoPos.localPosition.y >= 1000)
            {
                if (ButtonPos.localPosition.y > 550)
                {
                    ButtonPos.localPosition += new Vector3(0, 300 * Time.deltaTime, 0);
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
    }
    public void OnBack()
    {
        actMakimono = false;
    }
}
