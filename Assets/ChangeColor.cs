using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    new MeshRenderer[] renderers; 

    void Start() {
        renderers = gameObject.GetComponentsInChildren<MeshRenderer>(); // 자식객체 포함
    }

    void Update() {
        float lerp = Mathf.PingPong(Time.time, 1.0f);
        foreach (MeshRenderer r in renderers)
        { r.material.color = Color.Lerp(Color.red, Color.blue, lerp);
        }
    }

}
