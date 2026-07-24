using UnityEngine;

public class Keycard : MonoBehaviour
{
    public bool authorised;
    public bool powered;
    public EmergencyPowerButton epb;

    public void OnTriggerEnter(Collider entity)
    {
        powered = epb.emergencyPowerRestored;
        if (entity.gameObject.tag == "Keycard" && powered == true && authorised == false)
        {
            authorised = true;
        }
    }

}
