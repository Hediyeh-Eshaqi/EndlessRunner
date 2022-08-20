using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 60f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Default_Running" || other.gameObject.name=="Jake")
        {
            other.GetComponent<PlayerCollectCoin>().points++;
            GameOver.points++;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
