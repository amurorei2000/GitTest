using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
// �ʿ�Ӽ� : �Ѿ˰���, �ѱ���ġ(���ΰ���ġ)
// źâ���� �Ѿ��� �߻��ϵ��� �ϰ� �ʹ�.
// �ʿ�Ӽ� : źâ, źâ�� ���� �Ѿ� ����
// List �� �̿��ϵ��� źâ�� �ٲ㺸��
public class PlayerFire : MonoBehaviour
{
    // �ʿ�Ӽ� : �Ѿ˰���
    public GameObject bulletFactory;
    // �ʿ�Ӽ� : źâ, źâ�� ���� �Ѿ� ����
    public int bulletPoolSize = 10;
    //GameObject[] bulletPool;
    public List<GameObject> bulletPool = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� źâ�� �Ѿ��� ���� �ְ� �ʹ�.
        // 1. źâ�� �־���Ѵ�.
        //bulletPool = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            // 2. �Ѿ��� �־���Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. źâ�� �Ѿ��� �ְ�ʹ�.
            bulletPool.Add(bullet);
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
            // -> źâ�� �Ѿ��� �ִٸ� ������ �ִ� �ѹ� �߻��ϰ� �ʹ�.
            if(bulletPool.Count > 0)
            {
                // ��, ��Ȱ��ȭ �Ǿ� �ִ� �Ѿ��� ã�Ƽ� �߻��ϰ� �ʹ�.
                // 2. �Ѿ��� �־���Ѵ�.
                GameObject bullet = bulletPool[0];
                bullet.SetActive(true);
                // 3. �Ѿ��� �ѱ��տ� ����
                bullet.transform.position = transform.position;

                // źâ���� �Ѿ��� �����ϱ�
                bulletPool.RemoveAt(0);
            }
        }
    }
}
