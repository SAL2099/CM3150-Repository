using UnityEngine;

public class EmergencyPowerButton : MonoBehaviour
{
    public bool arrayAligned;
    public bool emergencyPowerRestored;
    public SolarPanelAlign spa;
    public GameObject emergencyLighting;
    public AudioSource emergencyEffect;
    public AudioSource emergencyMessage;
    public AudioClip powerEffect;
    public AudioClip messageEffect;

    public void RestoreEmergencyPower()
    {
        arrayAligned = spa.panelsAligned; 

        if (arrayAligned == true)
        {
            emergencyEffect.PlayOneShot(powerEffect);
            emergencyMessage.PlayOneShot(messageEffect);
            emergencyPowerRestored = true;
            emergencyLighting.SetActive(true);

        }
    }
}
