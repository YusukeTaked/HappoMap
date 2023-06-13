using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject fadeObj;
    //�@�t�F�[�h�C���̂����悻�̕b��
    [SerializeField]
    private float fadeInTime;
    //�@�w�iImage
    private Image image;

    void Start()
    {
        image = fadeObj.GetComponent<Image>();
        //�@�R���[�`���Ŏg�p����҂����Ԃ��v��
        fadeInTime = 1f * fadeInTime / 10f;
        StartCoroutine("FadeInS");
    }

    IEnumerator FadeInS()
    {

        //�@Color�̃A���t�@��0.1�������Ă���
        for (var i = 1f; i >= 0; i -= 0.01f)
        {
            image.color = new Color(0f, 0f, 0f, i);
            //�@�w��b���҂�
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

    //    //�@Color�̃A���t�@��0.1�������Ă���
    //    for (var i = 1f; i >= 0; i -= 0.1f)
    //    {
    //        image.color = new Color(0f, 0f, 0f, i);
    //        //�@�w��b���҂�
    //        yield return new WaitForSeconds(fadeInTime);
    //    }
    //}
}
