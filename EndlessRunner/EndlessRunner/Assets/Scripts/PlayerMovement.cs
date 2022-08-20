using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    public Animator animator;
    public Canvas canvas;
    float Speed = 5.0f;
    int n = 60;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (Pause.pause())
            Time.timeScale = 0f;
        else
        {
            canvas.GetComponent<Canvas>().enabled = false;
            Time.timeScale = 1f;
        }
        controller.Move(Vector3.left * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            n = 0;
            Vector3 temp = transform.position;
            temp.y += 1f;
            transform.position = temp;
            GetComponent<PlayerAnimationControler>().AnimateJump();
        }
        else
        {
            if (n < 16)
            {
                Vector3 temp = transform.position;
                temp.y += 0.25f;
                n++;
                transform.position = temp;
            }
            else if (n >= 16 && n < 24)
            {
                n++;
            }
            else if (n >= 24 && n < 48)
            {
                Vector3 temp1 = transform.position;
                temp1.y -= 0.25f;
                n++;
                transform.position = temp1;
                GetComponent<PlayerAnimationControler>().AnimateRun();
            }
            else
            {
                Vector3 temp1 = transform.position;
                temp1.y = 4.2825f;
                transform.position = temp1;
                n++;
                GetComponent<PlayerAnimationControler>().AnimateRun();
            }
        }
        if (animator.transform.position.z < 535 && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.5f, 0f, 0f);
        }
        if (526.7 < animator.transform.position.z && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.5f, 0f, 0f);
        }
    }
}