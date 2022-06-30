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
        dir = target.position - transform.position;
        dir.Normalize();
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
}
