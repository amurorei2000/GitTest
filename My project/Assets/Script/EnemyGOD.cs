using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 생성하고 싶다.
// 필요속성 : 생성시간, 경과시간, 적공장
public class EnemyGOD : MonoBehaviour
{
    // 필요속성 : 생성시간, 경과시간, 적공장
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
        // 일정시간에 한번씩 적을 생성하고 싶다.
        // 1. 시간이 흘렀으니까
        // -> 경과시간이 누적된다. 더해진다
        currentTime += Time.deltaTime;
        // 2. 생성시간이 됐으니까
        // -> 만약 경과시간이 생성시간을 초과하였다면
        if (currentTime > createTime)
        {
            // 3. 적을 생성하고 싶다.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. 적을 배치
            enemy.transform.position = transform.position;

            currentTime = 0;
        }
    }
}
