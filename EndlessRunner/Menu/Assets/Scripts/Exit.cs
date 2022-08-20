using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        UnityEditor.EditorApplication.Exit(0);
    }
}