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
        if (collision.gameObject.tag == "Platform1")
        {
            audio.PlayOneShot(klonoawahoo);
        }
        if (collision.gameObject.tag == "Popka")
        {
            audio.PlayOneShot(klonoahurt);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.PlayOneShot(klonoawahoo);
        }
    }
}