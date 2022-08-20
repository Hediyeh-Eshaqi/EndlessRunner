using UnityEngine;

public class InfiniteBackground2 : MonoBehaviour
{
    public static int FrameCounter = 0;
    public Animator animator;
    float finish = -97.1f;
    void Start()
    {

    }
    void Update()
    {
        FrameCounter++;
        if (animator.transform.position.x < finish - 30)
        {
            finish -= 120f;
            transform.position = new Vector3(finish, 0, 524.1f);
        }
        if (FrameCounter == 200)
        {
            SpawnCoins();
            SpawnBlocks();
            FrameCounter = 0;
        }
    }
    public GameObject coinPrefab;
    public GameObject blockPrefab;
    public GameObject player;
    public GameObject floor;
    public void SpawnCoins()
    {
        int coinsToSpawn = 1;
        for (int i = 0; i < coinsToSpawn; i++)
        {

            GameObject temp = Instantiate(coinPrefab);
            temp.transform.position = GetRandomPointInCollider(floor.GetComponent<Collider>());
        }
    }
    public void SpawnBlocks()
    {
        int coinsToSpawn = 1;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(blockPrefab);
            temp.transform.position = GetRandomPointInColliderForBlock(floor.GetComponent<Collider>());
        }
    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 Point = new Vector3(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y), Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        Point.y = 6;
        Point.x = player.transform.position.x - 50;

        return Point;
    }
    Vector3 GetRandomPointInColliderForBlock(Collider collider)
    {
        int c = Random.Range(1, 4);
        Vector3 Point = new Vector3();
        Point.y = 4.2825f;
        Point.x = player.transform.position.x - 50;
        if (c == 1)
        {
            Point.z = 528f;
        }
        else if (c == 2)
        {
            Point.z = 524;
        }
        else
        {
            Point.z = 520;
        }

        return Point;
    }
}