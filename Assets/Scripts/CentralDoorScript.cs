using UnityEngine;

public class CentralDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void OpenCentralDoor()
    {
        if (doorOpen == false)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("CentralDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseCentralDoor()
    {
        if (doorOpen == true)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("CentralDoorClose");
            doorOpen = false;
        }
    }
}
