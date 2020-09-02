using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    GameObject cylinder;
    void Start() { cylinder = GameObject.Find("Cylinder"); }
    void Update() { cylinder.transform.Rotate(0.0f, 0.0f, 5.0f); }
}
