using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingObj : MonoBehaviour
{
    public GameObject setting;
    // Start is called before the first frame update
    void Start()
    {
        setting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("�ݒ肪�^�b�v���ꂽ");
        setting.SetActive(true);
    }
    
}
