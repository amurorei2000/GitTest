using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
// �ʿ�Ӽ� : �Ѿ˰���, �ѱ���ġ(���ΰ���ġ)
// źâ���� �Ѿ��� �߻��ϵ��� �ϰ� �ʹ�.
// �ʿ�Ӽ� : źâ, źâ�� ���� �Ѿ� ����
public class PlayerFire : MonoBehaviour
{
    // �ʿ�Ӽ� : �Ѿ˰���
    public GameObject bulletFactory;
    // �ʿ�Ӽ� : źâ, źâ�� ���� �Ѿ� ����
    public int bulletPoolSize = 10;
    GameObject[] bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� źâ�� �Ѿ��� ���� �ְ� �ʹ�.
        // 1. źâ�� �־���Ѵ�.
        bulletPool = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            // 2. �Ѿ��� �־���Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. źâ�� �Ѿ��� �ְ�ʹ�.
            bulletPool[i] = bullet;
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.

        // 1. ����ڰ� �߻��ư�� �������ϱ�
        // -> ���� ����ڰ� �߻��ư�� �����ٸ�
        if (Input.GetButtonDown("Fire1"))
        {
            //�Ѿ� �߻� �� źâ���� �Ѿ��� ������ �߻��ϰ� �ʹ�.
            for (int i = 0; i < bulletPoolSize; i++)
            {
                // ��, ��Ȱ��ȭ �Ǿ� �ִ� �Ѿ��� ã�Ƽ� �߻��ϰ� �ʹ�.
                // 2. �Ѿ��� �־���Ѵ�.
                GameObject bullet = bulletPool[i];
                // ���� �Ѿ��� ��Ȱ��ȭ �Ǿ� �ִٸ�
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    // 3. �Ѿ��� �ѱ��տ� ����
                    bullet.transform.position = transform.position;
                    break;
                }
            }
        }
    }
}
