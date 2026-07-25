using UnityEngine;

public class GeneratorDoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    public Keycard key;
    public bool keyAllowed;
    private bool doorOpen = false;
    public AudioSource doorSource;
    public AudioSource terminalSource;
    public AudioSource messageSource;
    public AudioClip acceptedEffect;
    public AudioClip doorEffect;
    public AudioClip messageEffect;

    public void OnTriggerEnter(Collider entity)
    {

        keyAllowed = key.authorised;

        if (entity.gameObject.tag == "Keycard" && doorOpen == false && keyAllowed == true)
        {
            terminalSource.PlayOneShot(acceptedEffect);
            doorSource.PlayOneShot(doorEffect);
            messageSource.PlayOneShot(messageEffect);
            doorAnimator.Play("GeneratorDoorOpen");
            doorOpen = true;
        }

    }

}
