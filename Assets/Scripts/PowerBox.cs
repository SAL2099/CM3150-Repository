using UnityEngine;

public class PowerBox : MonoBehaviour
{
    public bool fullPower;
    public GameObject regularLighting;
    public GameObject emergencyLighting;
    public GameObject staticPowerCell;
    public AudioSource audioSource;
    public AudioClip soundEffect;
    public GameObject endCanvas;

    public void OnTriggerEnter(Collider entity)
    {
        if(entity.gameObject.tag == "PowerCell")
        {
            Destroy(entity.gameObject);
            staticPowerCell.SetActive(true);
            fullPower = true;
            audioSource.PlayOneShot(soundEffect);
            emergencyLighting.SetActive(false);
            regularLighting.SetActive(true);
            endCanvas.SetActive(true);
        }
    }
}
