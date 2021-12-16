using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;


    // Update is called once per frame
    void Update()
    {
        var movementX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movementX * speed;
        var movementY = Input.GetAxis("Vertical");
        transform.position += Vector3.up * movementY * speed;
    }
}
