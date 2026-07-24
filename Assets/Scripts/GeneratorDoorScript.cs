using UnityEngine;

public class GeneratorDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    public Keycard key;
    public bool keyAllowed;
    private bool doorOpen = false;

    public void OnTriggerEnter(Collider entity)
    {

        keyAllowed = key.authorised;

        if (entity.gameObject.tag == "Keycard" && doorOpen == false && keyAllowed == true)
        {
            doorAnimator.Play("GeneratorDoorOpen");
            doorOpen = true;
        }

    }

}
