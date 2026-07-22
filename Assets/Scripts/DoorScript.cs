using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;

    public void OpenDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == false)
        {
            doorAnimator.Play("DoorOpen");
            doorOpen = true;
        }

    }

    public void CloseDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == true)
        {
            doorAnimator.Play("DoorClose");
            doorOpen = false;
        }
    }
}
