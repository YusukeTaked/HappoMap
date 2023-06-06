using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootPon : MonoBehaviour
{
    int hantei;
    public GameObject Root1, Root2, Root3, Root4, Root5;

    // Start is called before the first frame update
    void Start()
    {
        hantei = TapToStart.getRoot();
    }

    // Update is called once per frame
    void Update()
    {
        if(hantei == 1)
        {
            Root1.SetActive(true);
            Root2.SetActive(true);
            Root3.SetActive(true);
            Root4.SetActive(true);
            Root5.SetActive(true);
        }
        else if(hantei == 2)
        {
            Root1.SetActive(true);
        }
        
    }
}
