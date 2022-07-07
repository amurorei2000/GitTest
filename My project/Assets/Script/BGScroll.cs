using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� ��ũ�� �ϰ� �ʹ�.
// �ʿ�Ӽ� : �ӵ�, ���͸���
public class BGScroll : MonoBehaviour
{
    // �ʿ�Ӽ� : �ӵ�, ���͸���
    public float speed = 0.2f;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        // ���͸����� ã�� �ʹ�.
        // 1. MeshRenderer �� �־���Ѵ�.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        // ����� ��ũ�� �ϰ� �ʹ�.
        // P = P0 + vt
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
