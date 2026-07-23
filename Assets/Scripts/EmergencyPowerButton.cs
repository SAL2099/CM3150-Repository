using UnityEngine;

public class EmergencyPowerButton : MonoBehaviour
{
    public bool arrayAligned;
    public bool emergencyPowerRestored;
    public SolarPanelAlign spa;
    public GameObject emergencyLighting;

    public void RestoreEmergencyPower()
    {
        arrayAligned = spa.panelsAligned; 

        if (arrayAligned == true)
        {
            emergencyPowerRestored = true;
            emergencyLighting.SetActive(true);

        }
    }
}
