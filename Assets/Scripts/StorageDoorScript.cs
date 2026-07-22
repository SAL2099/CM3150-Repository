using UnityEngine;

public class StorageDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;

    public void OpenStoragelDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == false)
        {
            doorAnimator.Play("StorageDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseStorageDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == true)
        {
            doorAnimator.Play("StorageDoorClose");
            doorOpen = false;
        }
    }
}
