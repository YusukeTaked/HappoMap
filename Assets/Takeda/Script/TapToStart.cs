using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TapToStart : MonoBehaviour
{
    public static int Root;
    public static int getRoot()
    {
        return Root;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("スタートボタンがタップされた");
        SceneManager.LoadScene("Takata");
    }
}
