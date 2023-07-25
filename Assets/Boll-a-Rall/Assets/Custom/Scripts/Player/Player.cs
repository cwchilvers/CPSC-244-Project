using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public Transform playerTransform;
    public GameObject scripts;

    private float _force = Constants.PLAYER_SPEED;

    void Update()
    {
        CheckOutOfBounds();
    }

    void FixedUpdate()
    {
        float x = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - _force;
        }

        if (Input.GetKey(KeyCode.D))
        {
            x = x + _force;
        } 

        float z = 0.0f;
        if (Input.GetKey(KeyCode.S))
        {
            z = z - _force;
        }

        if (Input.GetKey(KeyCode.W))
        {
            z = z + _force;
        }

        playerRigidbody.AddForce(x, 0, z);
    }

    public void CheckOutOfBounds()
    {
        if (playerTransform.transform.position.y < 0)
        {
            scripts.GetComponent<Game>().Fail();
        }
    }
}
