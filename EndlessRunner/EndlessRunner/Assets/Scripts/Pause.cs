using UnityEngine;

public class Pause : MonoBehaviour
{
    static public bool temp = false;
	public Canvas canvas;
    static public bool pause()
    {
        return temp;
    }
    public void pauseMenu()
    {
        canvas.GetComponent<Canvas>().enabled = true;
        temp = true;
    }
}
