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

    GameObject explosionFactory;
    // Start is called before the first frame update
    void Start()
    {
        //explosionFactory = (GameObject)Resources.Load("Prefabs/Explosion");
        explosionFactory = Resources.Load("Prefabs/Explosion") as GameObject;

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
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

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
            // �÷��̾��� hp �� ���ҽ�Ű�� �ʹ�.
            // 1. Player �� �־���Ѵ�.
            // -> �ε��� �༮�� �÷��̾���
            //if (collision.gameObject.name.Contains("Player"))
            //if (collision.gameObject.tag == "Player")
            //if (collision.gameObject.layer == 8)
            //if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            // �� �� PlayerHealth ������ ���
            // 2. PlayerHealth �� �־���Ѵ�.
            PlayerHealth.Instance.HP--;
        }
        // ���� �װ�
        Destroy(gameObject);
    }
}
