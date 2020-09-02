using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardPosition : MonoBehaviour
{

    public float speed = 0.25f;
    private Transform target;

    void Awake()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // 실린더 생성
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane); // 바닥 생성
        floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f); // 바닥의 위치
        floor.transform.localScale = new Vector3(5.0f, 1.0f, 5.0f);  // 바닥의 크기 변환
        target = cylinder.transform; // 실린더의 위치를 타겟으로 정함

        target.localScale = new Vector3(0.25f, 1.0f, 0.25f); //실린더의 크기를 변환
        target.position = new Vector3(10.0f, 0.0f, 10.0f); // 실린더의 위치를 변환
        Camera.main.transform.position = new Vector3(0.85f, 5.0f, -25.0f); // 메인 카메라의 위치를 변환
        Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f); // (회전 정보 오일러(로컬 좌표계), 오일러 각도) 카메라의 각도를 변환함
    }
    void Update()
    {
        float step = speed * Time.deltaTime; // speed * 1/60
        transform.position = Vector3.MoveTowards(transform.position, target.position, step); // transform 에서 target으로 이동하기 위한 새 점 벡터를 반환 거리는 step을 넘지 않는다
        if (Vector3.Distance(transform.position, target.position) < 0.2f) // transform와 target 사이의 거리를 반환
            target.position *= -1.0f; 
    }
}
