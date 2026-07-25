using UnityEngine;
using UnityEngine.InputSystem;

public class UIControl : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleMenu;
    [SerializeField] private GameObject uiCanvas;
    private bool uiActive = false;

    void Start()
    {
        toggleMenu.action.performed += ToggleMenuCanvas;
        uiCanvas.SetActive(false);
    }

    private void ToggleMenuCanvas(InputAction.CallbackContext context)
    {
        if(uiActive == false)
        {
            uiActive = true;
        }
        else
        {
            uiActive = false;
        }
        uiCanvas.SetActive(uiActive);
    }
}
