using UnityEngine;

public class StorageDoorScript : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    public EmergencyPowerButton epb;
    public bool powered;
    private bool doorOpen = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;

    public void OpenStoragelDoor()
    {

        powered = epb.emergencyPowerRestored;

        if (doorOpen == false && powered == true)
        {
            doorAnimator.Play("StorageDoorOpen");
            doorOpen = true;
            audioSource.PlayOneShot(soundEffect);
        }

    }

    public void CloseStorageDoor()
    {
        powered = epb.emergencyPowerRestored;

        if (doorOpen == true && powered == true)
        {
            doorAnimator.Play("StorageDoorClose");
            doorOpen = false;
            audioSource.PlayOneShot(soundEffect);
        }
    }
}
