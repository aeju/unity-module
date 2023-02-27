using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자 입력(상/하, 좌/우)에 따라 상하좌우로 이동
// 필요속성 : 이동속도
public class PlayerMove2d : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;
    
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
}
