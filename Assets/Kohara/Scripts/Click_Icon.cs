using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Click_Icon : MonoBehaviour,IPointerClickHandler
{
    public GameObject Info;
    public GameObject vRd;
    public GameObject tTako;
    public GameObject cButton;
    public Button closebutton;

    void Start()
    {
        this.closebutton.onClick.AddListener(() =>
        {
            StartCoroutine("Infoclose");
        });

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        

        //RectTransform rInfo = this.Info.GetComponent<RectTransform>();
        //rInfo.DOSizeDelta(new Vector2(100, 100), 1.5f);

        StartCoroutine("Infoopen");
        Debug.Log("This is clicked");


    }

    IEnumerator Infoopen()
    {
        Info.SetActive(true);
        RectTransform rInfo = this.Info.GetComponent<RectTransform>();
        rInfo.DOSizeDelta(new Vector2(100, 100), 1.5f);

        yield return new WaitForSeconds(1.5f);
        
        vRd.SetActive(true);
        tTako.SetActive(true);
        cButton.SetActive(true);
    }

    IEnumerator Infoclose()
    {
        vRd.SetActive(false);
        tTako.SetActive(false);
        cButton.SetActive(false);

        RectTransform rInfo = this.Info.GetComponent<RectTransform>();
        rInfo.DOSizeDelta(new Vector2(100, 0), 1.5f);

        yield return new WaitForSeconds(1.5f);

        Info.SetActive(false);

    }
}
