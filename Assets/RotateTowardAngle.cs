using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardAngle : MonoBehaviour
{

    public Transform target;
    public float speed = 90.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 direction = target.position - transform.position; 
        float step = speed * Time.deltaTime;
        direction = Vector3.RotateTowards(transform.forward, direction, speed * Time.deltaTime, 0.0f); // transform에서 direction으로 회전하기 위한 새로운 방향벡터 회전각도는 speed * Time.deltaTime 을 넘지 않도록 하고 이게 음수라면 direction에서 멀어지는 방향으로 회전 
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
