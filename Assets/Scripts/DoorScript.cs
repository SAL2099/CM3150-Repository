using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void OpenDoor()
    {
        if (doorOpen == false)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("DoorOpen");
            doorOpen = true;
        }

    }

    public void CloseDoor()
    {
        if (doorOpen == true)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("DoorClose");
            doorOpen = false;
        }
    }
}
