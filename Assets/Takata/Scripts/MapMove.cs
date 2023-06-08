using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float sensitivity = 1f;
    public float speed;

    const float LOAD_WIDTH = 6f;
    const float LOAD_HEIGHT = 6f;
    const float MOVE_MAX = 2.5f;
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
        //float wheel = Input.GetAxis("Mouse ScrollWheel");
        float newZ = Mathf.Clamp(transform.localPosition.z + wheel, -MAP_MOVE_MAX, -3);
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
        

        if (Input.GetMouseButtonDown(1))
        {
            previousPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            //スワイプによる移動距離を取得
            currentPos = Input.mousePosition;
            float diffDistanceW = (currentPos.x - previousPos.x) / Screen.width * LOAD_WIDTH;
            float diffDistanceH = (currentPos.y - previousPos.y) / Screen.height * LOAD_HEIGHT;

            diffDistanceW *= sensitivity;
            diffDistanceH *= sensitivity;

            //次のローカルx座標を設定　
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistanceW, -MOVE_MAX, MOVE_MAX);
            float newY = Mathf.Clamp(transform.localPosition.y + diffDistanceH, -MOVE_MAX, MOVE_MAX);
            
            transform.localPosition = new Vector3(newX, newY, newZ);

            //タップ位置を更新
            previousPos = currentPos;
        }
    }
}
