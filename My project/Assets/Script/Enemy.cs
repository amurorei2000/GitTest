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

    GameObject explosionFactory;
    // Start is called before the first frame update
    void Start()
    {
        //explosionFactory = (GameObject)Resources.Load("Prefabs/Explosion");
        explosionFactory = Resources.Load("Prefabs/Explosion") as GameObject;

        GameObject player = GameObject.Find("Player");
        // 만약 플레이어가 있다면
        // 70% 의 확률로 방향을 설정하고 싶다.
        // 1. 확률을 구해야한다.
        int rand = Random.Range(0, 10);
        // 2. 만약 확률이 70% 안에 들어오면
        //  -> 아래로 방향을 설정
        // 3. 그렇지 않으면
        //  -> 타겟쪽으로 방향으로 설정
        //if (player != null)
        // 플레이어가 있고 확률이 30 % 안에 들어오면
        if(player && rand >= 7)
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
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        // 만약 부딪힌 녀석이 총알이라면
        if (collision.gameObject.name.Contains("Bullet"))
        {
            // -> 탄창에 넣어주고 싶다.
            // 1. Player 가 있어야한다.
            GameObject player = GameObject.Find("Player");
            // 2. PlayerFire 가 있어야한다.
            PlayerFire pf = player.GetComponent<PlayerFire>();
            // 3. 탄창이 있어야한다.
            pf.bulletPool.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        // 그렇지 않으면
        else
        {
            // 플레이어의 hp 를 감소시키고 싶다.
            // 1. Player 가 있어야한다.
            // -> 부딪힌 녀석이 플레이어라면
            //if (collision.gameObject.name.Contains("Player"))
            //if (collision.gameObject.tag == "Player")
            //if (collision.gameObject.layer == 8)
            //if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            // 야 너 PlayerHealth 있으면 줘봐
            // 2. PlayerHealth 가 있어야한다.
            PlayerHealth.Instance.HP--;
        }
        // 나도 죽고
        Destroy(gameObject);
    }
}
