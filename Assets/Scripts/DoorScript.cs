using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;

    public void OpenDoor()
    {
        if (doorOpen == false)
        {
            doorAnimator.Play("DoorOpen");
            doorOpen = true;
        }

    }

    public void CloseDoor()
    {
        if (doorOpen == true)
        {
            doorAnimator.Play("DoorClose");
            doorOpen = false;
        }
    }
}
