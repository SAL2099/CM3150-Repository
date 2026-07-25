using UnityEngine;

public class TorchToggle : MonoBehaviour
{
    [SerializeField] private GameObject torch;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;

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
