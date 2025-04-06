using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{


    public float rotationSpeed = 5f;
    float rotateInput;


    // Update is called once per frame
    void Update()
    {

        rotateInput = Input.GetAxis("Rotate");
        print (rotateInput);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        //THIS MAKES IT ROTATE 
        //transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);

    }
}
