using UnityEngine;

public class MalletThud : MonoBehaviour
{
    [SerializeField] AudioClip Thud;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Domino")
        {
            audio.PlayOneShot(Thud);
        }
    }
}