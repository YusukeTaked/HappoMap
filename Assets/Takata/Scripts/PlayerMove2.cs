using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    //public float speed;
    // public Rigidbody2D rb;
    public float sensitivity = 1f;
    private Animator anim;
    private bool move;
    //private Vector2 startPos, currentPos, differenceDisVector2;
    //[SerializeField] private float radian, differenceDisFloat;

    const float LOAD_WIDTH = 6f;
    const float LOAD_HEIGHT = 6f;
    const float MOVE_MAX = 2.5f;
    Vector3 previousPos, currentPos;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            previousPos = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            //スワイプによる移動距離を取得
            currentPos = Input.mousePosition;
            float diffDistanceW = (currentPos.x - previousPos.x) / Screen.width * LOAD_WIDTH;
            float diffDistanceH = (currentPos.y - previousPos.y) / Screen.height * LOAD_HEIGHT;

            diffDistanceW *= sensitivity;
            diffDistanceH *= sensitivity;

            //次のローカルx座標を設定　※道の外に出ないように
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistanceW, -MOVE_MAX, MOVE_MAX);
            float newY = Mathf.Clamp(transform.localPosition.y + diffDistanceH, -MOVE_MAX, MOVE_MAX);
            transform.localPosition = new Vector3(newX, newY, 0);

            //タップ位置を更新
            previousPos = currentPos;
        }

        move = true;
        //anim.SetBool("go", move);
        //Vector2 direction = new Vector2(0, 0);

        //if(Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    float x = touch.deltaPosition.x;
        //    float y = touch.deltaPosition.y;

        //移動する向きを求める
        //    direction = new Vector2(0, 0).normalized;

        //}

        //GetComponent<Rigidbody2D>().velocity = direction * speed;

        //MovementControll();
    }

    //private void FixedUpdate()
    //{
    //Movement();
    //}

    //void MovementControll()
    //{
        //移動
    //    if(Input.GetKeyDown(KeyCode.Mouse0))
    //    {
            //マウス左クリック時に始点座標を代入
   //         startPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
     //   }

   //     if(Input.GetKey(KeyCode.Mouse0))
    //    {
            //押している最中に今の座標を代入
    //        currentPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    //        differenceDisVector2 = currentPos - startPos;

            //スワイプ量によってspeedを変化させる。この時、絶対値にする。
    //        differenceDisFloat = differenceDisVector2.x * differenceDisVector2.y;
    //        differenceDisFloat /= 100;
    //        differenceDisFloat = Mathf.Abs(differenceDisFloat);

            //タップしただけで動いてしまうので、距離が短ければ動かないようにする。
    //        if(differenceDisFloat > 1)
    //        {
    //            move = true;

                //最高速度
     //           if(differenceDisFloat > 1.25f)
      //          {
     //               differenceDisFloat = 1.25f;
     //           }

                //最低速度
     //           if (differenceDisFloat < 0.25f)
     //           {
     //               differenceDisFloat = 0.25f;
     //           }

     //           speed = differenceDisFloat;
                //もしspeedが0以上であれば、アニメーションさせる
     //           if(speed > 0)
     //           {
                    //anim.SetBool("is_walking", true);
     //           }

                //回転する角度計算
     //           radian = Mathf.Atan2(differenceDisVector2.x, differenceDisVector2.y) * Mathf.Rad2Deg;
     //       }
     //       else
     //       {
     //           rotation = false;
     //       }

     //       if(Input.GetKeyUp(KeyCode.Mouse0))
     //       {
     //           speed = 0;
     //           move = false;
     //           rb.velocity = Vector3.zero;
     //           rb.angularVelocity = Vector3.zero;
                //anim.SetBool("is_walking", false);
     //       }
     //   }
   // }

    //void Movement()
   // {
   //     if(move == true)
   //     {
   //         rb.velocity = transform.forward * speed;
   //         rb.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, radian, 0), 10);
   //     }
   // }
}
