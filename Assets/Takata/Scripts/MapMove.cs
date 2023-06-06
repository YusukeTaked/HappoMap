using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float sensitivity = 1f;

    const float LOAD_WIDTH = 6f;
    const float LOAD_HEIGHT = 6f;
    const float MOVE_MAX = 2.5f;

    Vector3 previousPos, currentPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

            //���̃��[�J��x���W��ݒ�@�����̊O�ɏo�Ȃ��悤��
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistanceW, -MOVE_MAX, MOVE_MAX);
            float newY = Mathf.Clamp(transform.localPosition.y + diffDistanceH, -MOVE_MAX, MOVE_MAX);
            transform.localPosition = new Vector3(newX, newY, -10);

            //�^�b�v�ʒu���X�V
            previousPos = currentPos;
        }
    }
}
