using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public float turnSpeed = 60f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Default_Running" || other.gameObject.name == "Jake")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}