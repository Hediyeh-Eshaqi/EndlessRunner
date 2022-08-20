using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Animator player;
    private float offset;
    void Start()
    {
        offset = transform.position.x - player.transform.position.x;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + offset, 6.702027f, 527.777f);
    }
}
