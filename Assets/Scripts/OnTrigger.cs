using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Light dirLight;
    public GameObject sphere;
    
    private void OnTriggerEnter(Collider other)
    {
        dirLight.enabled = true;
        sphere.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        dirLight.color = Random.ColorHSV();
    }

    private void OnTriggerExit(Collider other)
    {
        dirLight.enabled = false;
        sphere.SetActive(false);
    }
}
