using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip klonoawahoo;
    [SerializeField] AudioClip klonoahurt;
    [SerializeField] AudioClip klonoarupa;
    [SerializeField] AudioClip Clink;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Platform1")
        {
            audio.PlayOneShot(klonoawahoo);
        }
        if (collision.gameObject.tag == "Yeowch")
        {
            audio.PlayOneShot(klonoahurt);
        }
        if (collision.gameObject.tag == "Ramp")
        {
            audio.PlayOneShot(klonoarupa);
        }

        if (collision.gameObject.tag == "Panel")
        {
            audio.PlayOneShot(Clink);
        }
    }
}