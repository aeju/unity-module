using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자 입력(상/하, 좌/우)에 따라 상하좌우로 이동
// 필요속성 : 이동속도

// 점프 버튼 누르면 점프
// 필요속성 : 점프파워, Rigidbody2D
[RequireComponent(typeof(Rigidbody))]
public class PlayerMove2d : MonoBehaviour
{
    // 필요 속성 : 이동속도
    public float speed = 5;
    
    // 필요 속성 : 점프파워
    public float jumpPower = 2;
    //Rigidbody2D rb;
    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자 입력에 따라 상하좌우로 이동
        // 1. 사용자 입력에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 방향이 필요
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        dir.Normalize();

        // 3. 이동하고 싶다.
        // P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    void Jump()
    {
        // 사용자가 점프버튼을 누르면 점프하고 싶다.
        // 1. 점프버튼을 눌렀으니까
        if (Input.GetButtonDown("Jump"))
        {
            // 2. 점프하고 싶다.
            rb.velocity = Vector2.up * jumpPower;
        }
    }
}
