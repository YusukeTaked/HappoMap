using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    float s;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v += Time.deltaTime * 0.1f;

        s = 0.1f + v;

        transform.localScale = new Vector3(s, s, s);

        Destroy(this.gameObject, 5.0f);
    }


    
        
}
