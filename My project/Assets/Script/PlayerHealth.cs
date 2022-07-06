using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어의 체력을 관리하고싶다.
// 필요속성 : 체력
public class PlayerHealth : MonoBehaviour
{
    // 필요속성 : 체력
    public int hp = 3;

    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            // 3. hp 를 감소시키고 싶다.
            hp = value;
            // 4. 만약 체력이 다 됐다면
            if (hp <= 0)
            {
                // 갸도 죽고
                Destroy(gameObject);
            }
        }
    }

    public void SetHP(int value)
    {
        // 3. hp 를 감소시키고 싶다.
        hp = value;
        // 4. 만약 체력이 다 됐다면
        if (hp <= 0)
        {
            // 갸도 죽고
            Destroy(gameObject);
        }
    }

    public int GetHP()
    {
        return hp;
    }

    public static PlayerHealth Instance = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
