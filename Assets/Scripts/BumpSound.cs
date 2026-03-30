using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip klonoawahoo;
    [SerializeField] AudioClip klonoahurt;
    [SerializeField] AudioClip klonoarupa;
    [SerializeField] AudioClip klonoamourn;
    [SerializeField] AudioClip klonoatap;
    [SerializeField] AudioClip Clink;
    [SerializeField] AudioClip PlatformImpact;
    [SerializeField] AudioClip PipePing;
    [SerializeField] AudioClip TilePing;
    [SerializeField] AudioClip PlatformImpact2;
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

        if (collision.gameObject.tag == "Platform3")
        {
            audio.PlayOneShot(klonoamourn);
        }

        if (collision.gameObject.tag == "Whirlpool")
        {
            audio.PlayOneShot(klonoatap);
        }

        if (collision.gameObject.tag == "Panel")
        {
            audio.PlayOneShot(Clink);
        }

        if (collision.gameObject.tag == "SpinnyCube")
        {
            audio.PlayOneShot(Clink);
        }

        if (collision.gameObject.tag == "Platform")
        {
            audio.PlayOneShot(PlatformImpact);
        }

        if (collision.gameObject.tag == "Ball")
        {
            audio.PlayOneShot(PipePing);
        }

        if (collision.gameObject.tag == "Platform2")
        {
            audio.PlayOneShot(TilePing);
        }

        if (collision.gameObject.tag == "Platform4")
        {
            audio.PlayOneShot(PlatformImpact2);
        }
    }
}