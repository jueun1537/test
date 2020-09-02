using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBehaviour : MonoBehaviour
{
    public Collider objectToClone;
    public Transform parent;
    Collider clone;

    void Awake() { clone = Object.Instantiate(objectToClone, parent, true); }

    // Start is called before the first frame update
    void Start()
    {
        Object.Destroy(clone, 3.0f);
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
