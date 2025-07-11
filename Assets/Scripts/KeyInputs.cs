using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Key Down & Up: Enter

        if (Input.GetKeyDown(KeyCode.Return))
            print("se ha pulsado enter");

        if (Input.GetKey(KeyCode.Return))
            print("se esta pulsando enter");

        if (Input.GetKeyUp(KeyCode.Return))
            print("se ha soltado enter");

        //Other Key 

        if (Input.GetKeyUp(KeyCode.A))
            print("se ha soltado A");

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            print("se ha soltado left");

        if (Input.GetKeyUp(KeyCode.F1))
            print("se ha soltado F1");

        if (Input.GetKeyUp(KeyCode.Space))
            print("se ha soltado F1");

        if (Input.GetKeyUp(KeyCode.Escape))
            print("se ha soltado Escape");

        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt))
            print("se ha soltado Alt ");

    }
}
