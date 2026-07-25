using UnityEngine;

public class AudioMessage : MonoBehaviour
{
    public bool hasPlayed;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void OnTriggerEnter()
    {
        if (hasPlayed == false)
        {
            audioSource.PlayOneShot(soundEffect);
            hasPlayed = true;
        }
             
    }
}
