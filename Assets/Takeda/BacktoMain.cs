using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoMain : MonoBehaviour
{
    public GameObject Setting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick() 
    {
        Setting.SetActive(false);
    }
}
