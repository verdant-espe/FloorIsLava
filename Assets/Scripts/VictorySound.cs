using UnityEngine;

public class VictorySound : MonoBehaviour
{
    [SerializeField] AudioClip victorysfx;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Ball")
        {
            audio.PlayOneShot(victorysfx);
        }
    }
}
