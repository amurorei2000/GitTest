using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �̵��ӵ�
public class PlayerMove : MonoBehaviour
{
    public int num = 5;
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
        float v = Input.GetAxis("Vertical");
        // 2. ������ �ʿ��ϴ�.
        // (x, y, z) -> (1, 0, 0) * h => (h, 0, 0)
        // (0, 1, 0) * v => (0, v, 0)
        // h + v = (h, v, 0)
        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        // 3. �̵��ϰ� �ʹ�.
        // P = P0 + vt -> ��ӿ
        transform.position += dir * speed * Time.deltaTime;
       // transform.Translate(dir * speed * Time.deltaTime);
    }
}
