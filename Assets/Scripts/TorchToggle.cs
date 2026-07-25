using UnityEngine;

public class TorchToggle : MonoBehaviour
{
    public GameObject torch;
    public AudioSource audioSource;
    public AudioClip soundEffect;

  public void TorchOn()
    {
        torch.SetActive(true);
        audioSource.PlayOneShot(soundEffect);
    }

    public void TorchOff() 
    {
        torch.SetActive(false);
        audioSource.PlayOneShot(soundEffect);
    }
}
