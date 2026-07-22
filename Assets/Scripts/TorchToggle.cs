using UnityEngine;

public class TorchToggle : MonoBehaviour
{
    public GameObject torch;

  public void TorchOn()
    {
        torch.SetActive(true);
    }

    public void TorchOff() 
    {
        torch.SetActive(false);
    }
}
