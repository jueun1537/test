using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveCube : MonoBehaviour
{
    public Vector3 direction;

    void Start() {
        direction = Random.onUnitSphere; //반지름 1의 구 표면의 한 점을 무작위로 반환
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); // 색깔을 무작위로 정한다
    }

    void Update()
    {
        transform.Translate(direction * 10.0f * Time.deltaTime);
        transform.Rotate(direction, 360.0f * Time.deltaTime);
    }
}
