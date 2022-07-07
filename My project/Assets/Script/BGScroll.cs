using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경을 스크롤 하고 싶다.
// 필요속성 : 속도, 매터리얼
public class BGScroll : MonoBehaviour
{
    // 필요속성 : 속도, 매터리얼
    public float speed = 0.2f;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        // 매터리얼을 찾고 싶다.
        // 1. MeshRenderer 가 있어야한다.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        // 배경을 스크롤 하고 싶다.
        // P = P0 + vt
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
