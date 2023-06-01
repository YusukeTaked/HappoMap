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
            //�X���C�v�ɂ��ړ��������擾
            currentPos = Input.mousePosition;
            float diffDistanceW = (currentPos.x - previousPos.x) / Screen.width * LOAD_WIDTH;
            float diffDistanceH = (currentPos.y - previousPos.y) / Screen.height * LOAD_HEIGHT;

            diffDistanceW *= sensitivity;
            diffDistanceH *= sensitivity;

            //���̃��[�J��x���W��ݒ�@�����̊O�ɏo�Ȃ��悤��
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistanceW, -MOVE_MAX, MOVE_MAX);
            float newY = Mathf.Clamp(transform.localPosition.y + diffDistanceH, -MOVE_MAX, MOVE_MAX);
            transform.localPosition = new Vector3(newX, newY, 0);

            //�^�b�v�ʒu���X�V
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

        //�ړ�������������߂�
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
        //�ړ�
    //    if(Input.GetKeyDown(KeyCode.Mouse0))
    //    {
            //�}�E�X���N���b�N���Ɏn�_���W����
   //         startPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
     //   }

   //     if(Input.GetKey(KeyCode.Mouse0))
    //    {
            //�����Ă���Œ��ɍ��̍��W����
    //        currentPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    //        differenceDisVector2 = currentPos - startPos;

            //�X���C�v�ʂɂ����speed��ω�������B���̎��A��Βl�ɂ���B
    //        differenceDisFloat = differenceDisVector2.x * differenceDisVector2.y;
    //        differenceDisFloat /= 100;
    //        differenceDisFloat = Mathf.Abs(differenceDisFloat);

            //�^�b�v���������œ����Ă��܂��̂ŁA�������Z����Γ����Ȃ��悤�ɂ���B
    //        if(differenceDisFloat > 1)
    //        {
    //            move = true;

                //�ō����x
     //           if(differenceDisFloat > 1.25f)
      //          {
     //               differenceDisFloat = 1.25f;
     //           }

                //�Œᑬ�x
     //           if (differenceDisFloat < 0.25f)
     //           {
     //               differenceDisFloat = 0.25f;
     //           }

     //           speed = differenceDisFloat;
                //����speed��0�ȏ�ł���΁A�A�j���[�V����������
     //           if(speed > 0)
     //           {
                    //anim.SetBool("is_walking", true);
     //           }

                //��]����p�x�v�Z
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
