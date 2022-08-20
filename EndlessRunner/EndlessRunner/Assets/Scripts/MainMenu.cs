using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}