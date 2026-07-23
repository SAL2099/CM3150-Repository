using UnityEngine;

public class SolarPanelAlign : MonoBehaviour
{
    public bool panelsAligned;

    private void OnTriggerEnter(Collider entity)
    {
        if (entity.gameObject.tag == "SolarPanel")
        {
            panelsAligned = true;
        }
    }

    private void OnTriggerExit(Collider entity)
    {
        if (entity.gameObject.tag == "SolarPanel")
        {
            panelsAligned = false;
        }
    }

}
