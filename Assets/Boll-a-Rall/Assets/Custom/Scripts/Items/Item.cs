using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject plusOne;
    public GameObject scripts;

    private Transform _location;

    void Update()
    {
        Rotate();
    }

    public void OnTriggerEnter(Collider other)
    {
        Instantiate(plusOne, transform.position, Quaternion.identity);
        scripts.GetComponent<Items>().AddItem();
        Destroy(gameObject);
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
