using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
  // int health = 8; //8 bit = 1 byte, 1 int = 4 byte
  // string name = "Sallya";
  // bool grounded = false;
  // float gravity = 9.8f;
  // char myChar = 'f';

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {       

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.05f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.05f, 0);
        }
    }
}

