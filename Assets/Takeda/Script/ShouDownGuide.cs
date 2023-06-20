using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShouDownGuide : MonoBehaviour
{
    //�I�u�W�F�N�g�擾�p�̕ϐ�
    [Header("���C���I�u�W�F�N�g")]
    public GameObject MapButton;
    public GameObject Makimono;
    public GameObject GuideTex;
    public GameObject StartButton;
    public GameObject BackButton;

    public int typeButton;

    public static int typeSelect;


    //�{�^���̈ʒu���擾�p�̕ϐ�
    RectTransform ButtonPos ;
    RectTransform MakimonoPos;

    //�I������Ȃ��{�^������
    [Header("���̑��̃{�^��")]
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
