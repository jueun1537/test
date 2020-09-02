using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suning : MonoBehaviour
{
    public Transform sunrise;
    public Transform sunset;

    public float time = 10.0f;
    private float startTime;

    void Start() { startTime = Time.time; }
    void Update()
    {
        Vector3 center = (sunrise.position + sunset.position) * 0.5f; // 중간점
        center -= new Vector3(0, 1, 0);
        Vector3 rise = sunrise.position - center;
        Vector3 set = sunset.position - center;
        float t = (Time.time - startTime) / time;
        transform.position = Vector3.Slerp(rise, set, t); // 방향벡터를 t(0~1)를 이용하여 구면보간하여 반환한다
        transform.position += center;
    }
}
