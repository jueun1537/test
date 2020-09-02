using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentAdd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rotate rot = gameObject.AddComponent(typeof(Rotate)) as Rotate;
       // FirstBehaviour obj = gameObject.AddComponent<FirstBehaviour>();
        BoxCollider collider = gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
