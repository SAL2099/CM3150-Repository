using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    private bool doorOpen = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;

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
