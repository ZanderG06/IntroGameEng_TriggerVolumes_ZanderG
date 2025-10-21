using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Light dirLight;
    public GameObject sphere;
    public float timer = 1.0f;
    
    private void OnTriggerEnter(Collider other)
    {
        dirLight.enabled = true;
        sphere.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        
        if(timer >= 0.5f)
        {
            dirLight.color = Random.ColorHSV();
        }
        if(timer >= 1.0f)
        {
            dirLight.color = Random.ColorHSV();
            timer = 0f;
            return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        dirLight.enabled = false;
        sphere.SetActive(false);
    }
}
