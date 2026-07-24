using UnityEngine;

public class StorageDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    public EmergencyPowerButton epb;
    public bool powered;
    private bool doorOpen = false;

    public void OpenStoragelDoor()
    {

        powered = epb.emergencyPowerRestored;

        if (doorOpen == false && powered == true)
        {
            doorAnimator.Play("StorageDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseStorageDoor()
    {
        powered = epb.emergencyPowerRestored;

        if (doorOpen == true && powered == true)
        {
            doorAnimator.Play("StorageDoorClose");
            doorOpen = false;
        }
    }
}
