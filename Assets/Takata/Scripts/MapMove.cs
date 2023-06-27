using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float sensitivity = 1f;
    public float speed;

    const float LOAD_WIDTH = 6f;
    const float LOAD_HEIGHT = 6f;
    float MOVE_MAX = 0.1f;
    const float MAP_MOVE_MAX = 30f;

    Vector3 previousPos, currentPos;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var wheel = Input.mouseScrollDelta.y;
        MOVE_MAX += wheel;
        if (MOVE_MAX <= 0)
        {
            MOVE_MAX = 0.1f;
        }
        //float wheel = Input.GetAxis("Mouse ScrollWheel");
        float newZ = Mathf.Clamp(transform.localPosition.z + wheel, -MAP_MOVE_MAX, -3);
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
        

        if (Input.GetMouseButtonDown(1))
        {
            previousPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            //�X���C�v�ɂ��ړ��������擾
            currentPos = Input.mousePosition;
            float diffDistanceW = (currentPos.x - previousPos.x) / Screen.width * LOAD_WIDTH;
            float diffDistanceH = (currentPos.y - previousPos.y) / Screen.height * LOAD_HEIGHT;

            diffDistanceW *= sensitivity;
            diffDistanceH *= sensitivity;

            //���̃��[�J��x���W��ݒ�@
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistanceW, -MOVE_MAX, MOVE_MAX);
            float newY = Mathf.Clamp(transform.localPosition.y + diffDistanceH, -MOVE_MAX, MOVE_MAX);
            
            transform.localPosition = new Vector3(newX, newY, newZ);

            //�^�b�v�ʒu���X�V
            previousPos = currentPos;
        }
    }
}
