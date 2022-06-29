using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �̵��ӵ�
public class PlayerMove : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
        // 1. ������� �Է¿�����
        float h = Input.GetAxis("Horizontal");
        // 2. ������ �ʿ��ϴ�.
        Vector3 dir = Vector3.right * h;
        // 3. �̵��ϰ� �ʹ�.
        // P = P0 + vt -> ��ӿ
        transform.Translate(dir * speed * Time.deltaTime);
    }
}