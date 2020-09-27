using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    float movementSpeed = 3f;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    public void Controller()
    {
        float moveFB = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        //float moveXB = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        float h = horizontalSpeed * Input.GetAxis("Horizontal");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Translate(0f, 0f, moveFB);
        transform.Rotate(0, h, 0);
    }
}
