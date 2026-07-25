using UnityEngine;

public class EmergencyPowerButton : MonoBehaviour
{
    [SerializeField] private bool arrayAligned;
    public bool emergencyPowerRestored;
    [SerializeField] private SolarPanelAlign spa;
    [SerializeField] private GameObject emergencyLighting;
    [SerializeField] private AudioSource emergencyEffect;
    [SerializeField] private AudioSource emergencyMessage;
    [SerializeField] private AudioClip powerEffect;
    [SerializeField] private AudioClip messageEffect;

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
