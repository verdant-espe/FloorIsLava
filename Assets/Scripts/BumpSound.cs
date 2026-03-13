System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip klonoawahoo;
    [SerializeField] AudioClip klonoahurt;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "panel")
        {
            audio.PlayOneShot(klonoawahoo);
        }
        if (collision.gameObject.tag == "domino")
        {
            audio.PlayOneShot(klonoahurt);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.PlayOneShot(bump);
        }
    }
}