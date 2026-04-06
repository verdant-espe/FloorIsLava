using
System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GhadiusDiesRIP : MonoBehaviour
{
    [SerializeField] AudioClip ripghadius;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Ghadius")
        {
            audio.PlayOneShot(ripghadius);
        }
    }
}
