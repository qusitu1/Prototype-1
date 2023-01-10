using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float RotationSpeed;
    public float VerticalInput;
    public float HorizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        VerticalInput = Input.GetAxis("Vertical");

        // get the user's horizontal input
        HorizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime * HorizontalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * RotationSpeed * Time.deltaTime * VerticalInput);
    }
}
