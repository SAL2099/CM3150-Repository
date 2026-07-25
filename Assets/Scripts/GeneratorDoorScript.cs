using UnityEngine;

public class GeneratorDoorScript : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    public Keycard key;
    public bool keyAllowed;
    private bool doorOpen = false;
    [SerializeField] private AudioSource doorSource;
    [SerializeField] private AudioSource terminalSource;
    [SerializeField] private AudioSource messageSource;
    [SerializeField] private AudioClip acceptedEffect;
    [SerializeField] private AudioClip doorEffect;
    [SerializeField] private AudioClip messageEffect;

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
