using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static int points = 0;
    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(20, 20, 2000, 40), "Score: " + points);
    }
}
