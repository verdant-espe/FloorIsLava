using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound2 : MonoBehaviour
{
    [SerializeField] AudioClip loloexplodes;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "LEC")
        {
            audio.PlayOneShot(loloexplodes);
        }
    }
}
