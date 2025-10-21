using UnityEngine;
using System.Threading;

public class OnTrigger : MonoBehaviour
{
    public GameObject dirLight;
    public GameObject sphere;
    
    private void OnTriggerEnter(Collider other)
    {
        dirLight.SetActive(true);
        sphere.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        sphere.SetActive(true);
        Thread.Sleep(5000);
        sphere.SetActive(false);
        Thread.Sleep(5000);
    }

    private void OnTriggerExit(Collider other)
    {
        dirLight.SetActive(false);
        sphere.SetActive(false);
    }
}
