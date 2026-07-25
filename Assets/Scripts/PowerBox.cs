using UnityEngine;

public class PowerBox : MonoBehaviour
{
    public bool fullPower;
    [SerializeField] private GameObject regularLighting;
    [SerializeField] private GameObject emergencyLighting;
    [SerializeField] private GameObject staticPowerCell;
    [SerializeField] private AudioSource messageSource;
    [SerializeField] private AudioClip messageEffect;
    [SerializeField] private AudioSource powerSource;
    [SerializeField] private AudioClip powerEffect;

    public void OnTriggerEnter(Collider entity)
    {
        if(entity.gameObject.tag == "PowerCell")
        {
            Destroy(entity.gameObject);
            staticPowerCell.SetActive(true);
            fullPower = true;
            messageSource.PlayOneShot(messageEffect);
            powerSource.PlayOneShot(powerEffect);
            emergencyLighting.SetActive(false);
            regularLighting.SetActive(true);
        }
    }
}
