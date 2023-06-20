using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerIcon : MonoBehaviour
{
    public GameObject player;
    public GameObject[] Icon;
    public GameObject effect;
    public float[] dis;
    public int[] efbool;
    //public bool onof;
    // Start is called before the first frame update
    void Start()
    {
        dis = new float[5];
        efbool = new int[5];

        for (int i = 0; i < 5; i++)
        {
            //dis[i] = Vector3.Distance(Icon[i].transform.position, player.transform.position);
            dis[i] = (Icon[i].transform.position - player.transform.position).sqrMagnitude;
            efbool[i] = 0;
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (dis[i] < dis[j])
                {
                    efbool[i] += 1;
                }
                else if (dis[i] > dis[j])
                {
                    i = j;
                    //j = i + 1;
                    efbool[i] += 1;
                }
            }

        }


        if (efbool[0] == 4)
        {
            this.transform.position = Icon[0].transform.position;
            StartCoroutine("EfMove");
        }
        else if (efbool[1] == 4)
        {
            this.transform.position = Icon[1].transform.position;
            StartCoroutine("EfMove");
        }
        else if (efbool[2] == 3)
        {
            this.transform.position = Icon[2].transform.position;
            StartCoroutine("EfMove");
        }
        else if (efbool[3] == 2)
        {
            this.transform.position = Icon[3].transform.position;
            StartCoroutine("EfMove");
        }
        else if (efbool[4] == 1)
        {
            this.transform.position = Icon[4].transform.position;
            StartCoroutine("EfMove");
        }
    }

    void Update()
    {
        

        

        
    }

    IEnumerator EfMove()
    {
        for (int i= 0;i < 3;i++)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(effect, this.transform.position, Quaternion.identity);
            
        }
        
    }
}
