using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    public float speed;
    private bool isMoving;
    private AudioSource Laugh;

    private void Start()
    {
        Laugh = this.gameObject.GetComponent<AudioSource>();
    }

    public void Update()
    {
        isMoving = false;


        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            isMoving = true;
        }


        if (isMoving && !Laugh.isPlaying)
        {
            Laugh.Play();
        }
        else if (!isMoving && Laugh.isPlaying)
        {
            Laugh.Stop();
        }
    }
}
