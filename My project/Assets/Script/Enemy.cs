using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ʒ��� ��� �̵��ϰ� �ʹ�.
//Ÿ�ٹ������� ��� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : Ÿ��
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    // �ʿ�Ӽ� : Ÿ��
    public Transform target;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        // ���� �÷��̾ �ִٸ�
        // 70% �� Ȯ���� ������ �����ϰ� �ʹ�.
        // 1. Ȯ���� ���ؾ��Ѵ�.
        int rand = Random.Range(0, 10);
        // 2. ���� Ȯ���� 70% �ȿ� ������
        //  -> �Ʒ��� ������ ����
        // 3. �׷��� ������
        //  -> Ÿ�������� �������� ����
        //if (player != null)
        // �÷��̾ �ְ� Ȯ���� 30 % �ȿ� ������
        if(player && rand >= 7)
        {
            // Ÿ�� �������� �̵��ϵ��� �Ѵ�.
            target = player.transform;
            dir = target.position - transform.position;
            dir.Normalize();
        }
        // �׷��� ������
        else
        {
            // �׳� �Ʒ��� �̵���Ű��
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Ÿ�ٹ������� ��� �̵��ϰ� �ʹ�.
        // 1. ������ �ʿ�
        // -> Ÿ�� - ��
        // 2. �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }

    // �ٸ���ü�� �ε����� ���� �װ�, ���� �װ���
    // Enter, Stay, Exit
    private void OnCollisionEnter(Collision collision)
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
        // ���� �װ�
        Destroy(gameObject);
    }
}
