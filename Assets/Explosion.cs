using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ExplosiveCube cube;

    void OnMouseDown()
    {
        for (int i = 0; i < 100; i++)
        {
            ExplosiveCube obj = Instantiate<ExplosiveCube>(cube, transform.position, transform.rotation); // Instantiate() : 객체(게임 객체 또는 컴포넌트)를 복제하여 생성하고 반환한다.
            Destroy(obj.gameObject, 3.0f);
        }
    }
}
