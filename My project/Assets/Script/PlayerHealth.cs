using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �÷��̾��� ü���� �����ϰ�ʹ�.
// �ʿ�Ӽ� : ü��
public class PlayerHealth : MonoBehaviour
{
    // �ʿ�Ӽ� : ü��
    public int hp = 3;

    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            // 3. hp �� ���ҽ�Ű�� �ʹ�.
            hp = value;
            // 4. ���� ü���� �� �ƴٸ�
            if (hp <= 0)
            {
                // ���� �װ�
                Destroy(gameObject);
            }
        }
    }

    public void SetHP(int value)
    {
        // 3. hp �� ���ҽ�Ű�� �ʹ�.
        hp = value;
        // 4. ���� ü���� �� �ƴٸ�
        if (hp <= 0)
        {
            // ���� �װ�
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
