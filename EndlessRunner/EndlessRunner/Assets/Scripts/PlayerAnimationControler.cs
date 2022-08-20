using UnityEngine;

public class PlayerAnimationControler : MonoBehaviour
{
    #region Attributes
    private Animator animator;

    string RUN_ANIMATION_BOOL = "Run";
    string jump_ANIMATION_BOOL = "Jump";
    string die_ANIMATION_BOOL = "Die";

    #endregion
    #region Animate Function
    public void AnimateRun()
    {
        Animate(RUN_ANIMATION_BOOL);
    }
    public void AnimateJump()
    {
        Animate(jump_ANIMATION_BOOL);
    }
    public void AnimateDie()
    {
        Animate(die_ANIMATION_BOOL);
    }



    #endregion
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Animate(string boolName)
    {
        DisableOtherAnimations(animator, boolName);
        animator.SetBool(boolName, true);
    }
    private void DisableOtherAnimations(Animator animator, string animation)
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.name != animation)
            {
                animator.SetBool(parameter.name, false);
            }
        }
    }
}
