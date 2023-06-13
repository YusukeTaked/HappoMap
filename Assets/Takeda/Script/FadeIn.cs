using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject fadeObj;
    //　フェードインのおおよその秒数
    [SerializeField]
    private float fadeInTime;
    //　背景Image
    private Image image;

    void Start()
    {
        image = fadeObj.GetComponent<Image>();
        //　コルーチンで使用する待ち時間を計測
        fadeInTime = 1f * fadeInTime / 10f;
        StartCoroutine("FadeInS");
    }

    IEnumerator FadeInS()
    {

        //　Colorのアルファを0.1ずつ下げていく
        for (var i = 1f; i >= 0; i -= 0.01f)
        {
            image.color = new Color(0f, 0f, 0f, i);
            //　指定秒数待つ
            yield return new WaitForSeconds(fadeInTime);
        }
        if (image.color ==new Color(0f, 0f, 0f, 0f))
        {
            fadeObj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //IEnumerator FadeInS()
    //{

    //    //　Colorのアルファを0.1ずつ下げていく
    //    for (var i = 1f; i >= 0; i -= 0.1f)
    //    {
    //        image.color = new Color(0f, 0f, 0f, i);
    //        //　指定秒数待つ
    //        yield return new WaitForSeconds(fadeInTime);
    //    }
    //}
}
