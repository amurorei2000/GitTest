using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 나랑 부딪힌 녀석은 없애고 싶다.
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        // 만약 부딪힌 녀석이 총알이라면
        if (collision.gameObject.name.Contains("Bullet"))
        {
            // -> 탄창에 넣어주고
            collision.gameObject.SetActive(false);
        }
        // 그렇지 않으면
        else
        {
            // 갸도 죽고
            Destroy(collision.gameObject);
        }
    }
}
