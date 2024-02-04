using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        //engine = this.gameObject.GetComponent<AudioSource>();
    }

    public void Update()
    {
        //isDriving = false;


        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            //isDriving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            //isDriving = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            //isDriving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            //isDriving = true;
        }


        //if (isDriving && !engine.isPlaying)
        //{
        //    engine.Play();
        //}
        //else if (!isDriving && engine.isPlaying)
        //{
        //    engine.Stop();
        //}
    }
}
