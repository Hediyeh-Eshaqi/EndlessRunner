using UnityEngine;

public class PlayerCollectCoin : MonoBehaviour
{
    public int points = 0;
    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(20, 20, 2000, 40), "Score:");
        if(points != 0)
            GUI.Label(new Rect(60, 20, 2000, 40), points.ToString());
    }
}