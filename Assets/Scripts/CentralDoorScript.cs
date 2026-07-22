using UnityEngine;

public class CentralDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;

    public void OpenCentralDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == false)
        {
            doorAnimator.Play("CentralDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseCentralDoor()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        if (doorOpen == true)
        {
            doorAnimator.Play("CentralDoorClose");
            doorOpen = false;
        }
    }
}
