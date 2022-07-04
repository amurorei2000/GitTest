using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에 따라 상하좌우로 이동하고 싶다.
// 필요속성 : 이동속도
public class PlayerMove : MonoBehaviour
{
    public int num = 5;
    // 필요속성 : 이동속도
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력에 따라 상하좌우로 이동하고 싶다.
        // 1. 사용자의 입력에따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 방향이 필요하다.
        // (x, y, z) -> (1, 0, 0) * h => (h, 0, 0)
        // (0, 1, 0) * v => (0, v, 0)
        // h + v = (h, v, 0)
        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        // 3. 이동하고 싶다.
        // P = P0 + vt -> 등속운동
        transform.position += dir * speed * Time.deltaTime;
       // transform.Translate(dir * speed * Time.deltaTime);
    }
}
