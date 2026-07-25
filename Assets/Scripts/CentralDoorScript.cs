using UnityEngine;

public class CentralDoorScript : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    private bool doorOpen = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;

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
