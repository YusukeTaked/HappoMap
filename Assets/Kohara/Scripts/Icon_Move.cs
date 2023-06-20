using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon_Move : MonoBehaviour
{

    public GameObject Que;
    public GameObject Castle;
    public GameObject Shadow;
    bool isDiscCastle = false;

    // Start is called before the first frame update
    void Start()
    {
        Que.transform.DOLocalMoveY(+0.3f, 1.0f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F) && !isDiscCastle)
        {
            //Discover();
            StartCoroutine("kirikae");
            isDiscCastle = true;
        }

    }
    /*void Discover()
    {
        Que.transform.DOLocalRotate(new Vector3(0, 0, 1080f), 3f, RotateMode.FastBeyond360);
        Que.SetActive(false);

    }*/

    IEnumerator kirikae()
    {
        Que.transform.DOLocalRotate(new Vector3(0, 0, 1080f), 2f, RotateMode.FastBeyond360);
        Que.transform.DOScale(new Vector3(0, 0, 0), 2f);
        Shadow.transform.DOScale(new Vector3(0, 0, 0), 1f);

        yield return new WaitForSeconds(2f);

        Que.SetActive(false);
        Shadow.SetActive(false);
        Castle.SetActive(true);

        Castle.transform.DOScale(new Vector3(0.5f, 0.5f, 1), 1f);
    }
    
}
