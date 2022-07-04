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
            // -> źâ�� �־��ְ�
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
