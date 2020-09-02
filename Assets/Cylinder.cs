using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    GameObject cylinder;
    void Awake()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // 게임 오브젝트를 생성한다
        obj.name = "New Cylinder";
        obj.transform.position = new Vector3(-5.0f, 0.0f, 3.0f);
    }
    void Start() {
        cylinder = GameObject.Find("New Cylinder"); // 새로 만든 오브젝트를 찾는다
    }

    void Update() {
        cylinder.transform.Rotate(0.0f, 0.0f, 5.0f); // 새로만든 오브젝트를 회전시킨다
    }
   
}
