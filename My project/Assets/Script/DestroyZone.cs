using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �ε��� �༮�� ���ְ� �ʹ�.
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        // ���� �ε��� �༮�� �Ѿ��̶��
        if (collision.gameObject.name.Contains("Bullet"))
        {
            // -> źâ�� �־��ְ� �ʹ�.
            // 1. Player �� �־���Ѵ�.
            GameObject player = GameObject.Find("Player");
            // 2. PlayerFire �� �־���Ѵ�.
            PlayerFire pf = player.GetComponent<PlayerFire>();
            // 3. źâ�� �־���Ѵ�.
            pf.bulletPool.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        // �׷��� ������
        else
        {
            // ���� �װ�
            Destroy(collision.gameObject);
        }
    }
}
