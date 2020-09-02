using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
    }

    // Update is called once per frame
    void Update() {

        //transform.Translate(0, 0, 2.0f * Time.deltaTime);
        //transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(0, Time.deltaTime, 0, Space.World);
        // transform.Rotate(0.0f, 0.0f, 90.0f * Time.deltaTime, Space.Self); //자전
        transform.RotateAround(Vector3.zero, Vector3.up, 30.0f * Time.deltaTime); // 공전
    }

}
