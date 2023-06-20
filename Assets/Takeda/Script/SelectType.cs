using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectType : MonoBehaviour
{
    public static int typeSelect;
    public ShouDownGuide shouDownGuide;

    // Start is called before the first frame update
    void Start()
    {
        typeSelect= shouDownGuide.TypeOfButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int TypeSelect()
    {
        return typeSelect;
    }
}
