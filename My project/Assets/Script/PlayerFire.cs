using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
// 필요속성 : 총알공장, 총구위치(주인공위치)
// 탄창에서 총알을 발사하도록 하고 싶다.
// 필요속성 : 탄창, 탄창에 넣을 총알 개수
public class PlayerFire : MonoBehaviour
{
    // 필요속성 : 총알공장
    public GameObject bulletFactory;
    // 필요속성 : 탄창, 탄창에 넣을 총알 개수
    public int bulletPoolSize = 10;
    GameObject[] bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 탄창에 총알을 만들어서 넣고 싶다.
        // 1. 탄창이 있어야한다.
        bulletPool = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            // 2. 총알이 있어야한다.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. 탄창에 총알을 넣고싶다.
            bulletPool[i] = bullet;
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.

        // 1. 사용자가 발사버튼을 눌렀으니까
        // -> 만약 사용자가 발사버튼을 눌렀다면
        if (Input.GetButtonDown("Fire1"))
        {
            //총알 발사 시 탄창에서 총알을 가져와 발사하고 싶다.
            for (int i = 0; i < bulletPoolSize; i++)
            {
                // 단, 비활성화 되어 있는 총알을 찾아서 발사하고 싶다.
                // 2. 총알이 있어야한다.
                GameObject bullet = bulletPool[i];
                // 만약 총알이 비활성화 되어 있다면
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    // 3. 총알을 총구앞에 놓기
                    bullet.transform.position = transform.position;
                    break;
                }
            }
        }
    }
}
