using UnityEngine;

public class CentralDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool doorOpen = false;

    public void OpenCentralDoor()
    {
        if (doorOpen == false)
        {
            doorAnimator.Play("CentralDoorOpen");
            doorOpen = true;
        }

    }

    public void CloseCentralDoor()
    {
        if (doorOpen == true)
        {
            doorAnimator.Play("CentralDoorClose");
            doorOpen = false;
        }
    }
}
