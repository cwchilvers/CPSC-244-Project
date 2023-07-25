using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOne: MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 1);
    }
}
