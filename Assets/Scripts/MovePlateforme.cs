using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateforme : MonoBehaviour 
    { 
    Rigidbody rigidbody;
    Vector3 direction= new Vector3(0f, 0f, 1f);
    void Start()
        {
        rigidbody = GetComponent<Rigidbody>();

        }
    void FixedUpdate()
        {
        Vector3 currentPosition = transform.position;
        float speed = 1f;

        if (transform.position.z <= -2f ) 
            {
            direction = new Vector3(0f, 0f, 1f);
        }
        else if (transform.position.z >= 4f ) 
            {
            direction = new Vector3(0f, 0f, -1f);
        }
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        rigidbody.MovePosition(newPosition);
    }
    }
