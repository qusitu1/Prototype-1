using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f;
    private float rotationSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;

    public Vector3 RotationSpeed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
        
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput
            );
        // We turn the vehicle
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * forwardInput);
    }
}
