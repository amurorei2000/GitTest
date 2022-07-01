using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아래로 계속 이동하고 싶다.
//타겟방향으로 계속 이동하고 싶다.
// 필요속성 : 타겟
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    // 필요속성 : 타겟
    public Transform target;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        // 만약 플레이어가 있다면
        //if (player != null)
        if(player)
        {
            // 타겟 방향으로 이동하도록 한다.
            target = player.transform;
            dir = target.position - transform.position;
            dir.Normalize();
        }
        // 그렇지 않으면
        else
        {
            // 그냥 아래로 이동시키자
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //타겟방향으로 계속 이동하고 싶다.
        // 1. 방향이 필요
        // -> 타겟 - 미
        // 2. 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }

    // 다른물체와 부딪히면 갸도 죽고, 나도 죽고자
    // Enter, Stay, Exit
    private void OnCollisionEnter(Collision collision)
    {
        // 갸도 죽고
        Destroy(collision.gameObject);
        // 나도 죽고
        Destroy(gameObject);
    }
}
