using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð��� �ѹ��� ���� �����ϰ� �ʹ�.
// �ʿ�Ӽ� : �����ð�, ����ð�, ������
public class EnemyGOD : MonoBehaviour
{
    // �ʿ�Ӽ� : �����ð�, ����ð�, ������
    public float createTime = 2;
    float currentTime = 0;
    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ð��� �ѹ��� ���� �����ϰ� �ʹ�.
        // 1. �ð��� �귶���ϱ�
        // -> ����ð��� �����ȴ�. ��������
        currentTime += Time.deltaTime;
        // 2. �����ð��� �����ϱ�
        // -> ���� ����ð��� �����ð��� �ʰ��Ͽ��ٸ�
        if (currentTime > createTime)
        {
            // 3. ���� �����ϰ� �ʹ�.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. ���� ��ġ
            enemy.transform.position = transform.position;

            currentTime = 0;
        }
    }
}
