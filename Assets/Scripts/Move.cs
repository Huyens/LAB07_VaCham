using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public float moveSpeed = 5f;

    void Update()
    {
        // Nhận đầu vào từ bàn phím
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D hoặc Mũi tên trái/phải
        float moveVertical = Input.GetAxis("Vertical"); // W/S hoặc Mũi tên lên/xuống

        // Tạo vector di chuyển
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Di chuyển đối tượng
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
