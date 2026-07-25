using UnityEngine;

public class StorageDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    public EmergencyPowerButton epb;
    public bool powered;
    private bool doorOpen = false;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void OpenStoragelDoor()
    {

        powered = epb.emergencyPowerRestored;

        if (doorOpen == false && powered == true)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("StorageDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseStorageDoor()
    {
        powered = epb.emergencyPowerRestored;

        if (doorOpen == true && powered == true)
        {
            audioSource.PlayOneShot(soundEffect);
            doorAnimator.Play("StorageDoorClose");
            doorOpen = false;
        }
    }
}
