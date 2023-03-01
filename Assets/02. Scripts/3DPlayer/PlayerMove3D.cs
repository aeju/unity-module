using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
// <이동>
// 사용자의 입력에따라 앞뒤좌우 이동하고 싶다.
// 필요속성 : 이동속도

// <점프>
// 중력을 적용시키고 싶다.
// 필요속성 : 중력, 수직속도
// 사용자가 점프버튼을 누르면 점프하고 싶다.
// 필요속성 : 점프파워
public class PlayerMove3D : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;

    CharacterController cc;
    
    // 필요속성 : 중력, 수직속도
    public float gravity = -20;
    float yVelocity = 0;
    // 필요속성 : 점프파워
    public float jumpPower = 5;

    // 점프중인지 여부 기억
    bool isJumping = false;
    int jumpCount = 0;
    public int jumpCountMax = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력에따라 앞뒤좌우 이동하고 싶다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        dir = Camera.main.transform.TransformDirection(dir);
        // v = v0 + at
        yVelocity += gravity * Time.deltaTime;
        
        // 사용자가 점프버튼을 누르면 점프하고 싶다.
        if (jumpCount < jumpCountMax && Input.GetKeyDown(KeyCode.A))
        //if (Input.GetButtonDown("Jump"))
        {
            print("jump");
            // -> 수직속도에 변화를 주고싶다.
            yVelocity = jumpPower;
            jumpCount++;
            //isJumping = true;
        }

        dir.y = yVelocity;
        
        // P = P0 + vt
        cc.Move(dir * speed * Time.deltaTime);
    }
}
