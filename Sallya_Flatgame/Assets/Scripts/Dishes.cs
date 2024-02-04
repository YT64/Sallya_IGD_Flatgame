using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dishes : MonoBehaviour
{
    private AudioSource Play;
    private void Start()
    {
        Play = this.gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Play.isPlaying)
        {
            Play.Play();
        }
        else if (Play.isPlaying)
        {
            Play.Stop();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Play.isPlaying)
        {
            Play.Stop();
        }
    }

}
