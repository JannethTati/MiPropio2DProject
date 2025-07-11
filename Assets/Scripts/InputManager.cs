using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Attributes
    public Transform cubeTransform;
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Mouse axis debug
        //Debug.DrawLine(cubeTransform.position, Vector3.right * Input.GetAxis("Mouse Y"), Color.red);
        //Debug.DrawLine(cubeTransform.position, Vector3.forward * Input.GetAxis("Mouse X"), Color.blue);
        
        
        //Keyboar axis debug
        Debug.DrawLine(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawLine(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);

        //Button
        if (Input.GetButtonUp("Fire1"))
        { 
            print("Fire!!");
        }

        //Mouse wheel
        print("Mouse wheel: " + Input.GetAxis("Mouse ScrollWheel"));

        //Movement by Mouse
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);

        //Movement by keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
