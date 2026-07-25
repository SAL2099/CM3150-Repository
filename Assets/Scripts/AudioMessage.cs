using UnityEngine;

public class AudioMessage : MonoBehaviour
{
    [SerializeField] private bool hasPlayed;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;

    public void OnTriggerEnter()
    {
        if (hasPlayed == false)
        {
            audioSource.PlayOneShot(soundEffect);
            hasPlayed = true;
        }
             
    }
}
