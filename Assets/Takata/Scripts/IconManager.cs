using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconManager : MonoBehaviour
{
    public GameObject WCUI;
    public GameObject PhotoUI;
    public bool wcbool = false, phbool = false;

    //AudioSource audios;
    //public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        //audios = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickWCBtn()
    {
        if (wcbool == true)
        {
            wcbool = false;
        }
        else if(wcbool == false)
        {
            wcbool = true;
        }
        WCUI.SetActive(wcbool);
        //audios.PlayOneShot(se);
    }

    public void ClickPhotoBtn()
    {
        if (phbool == true)
        {
            phbool = false;
        }
        else if (phbool == false)
        {
            phbool = true;
        }
        PhotoUI.SetActive(phbool);
        //audios.PlayOneShot(se);
    }
}
