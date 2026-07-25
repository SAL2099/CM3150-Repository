using UnityEngine;

public class MenuManagement : MonoBehaviour
{
    [SerializeField] private GameObject leftController;
    [SerializeField] private GameObject rightController;
    [SerializeField] private bool disabled;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToggleTooltips()
    {
        if(disabled == false)
        {
            leftController.SetActive(false);
            rightController.SetActive(false);
            disabled = true;
        }

        else
        {
            leftController.SetActive(true);
            rightController.SetActive(true);
            disabled = false;
        }
    }
    

}
