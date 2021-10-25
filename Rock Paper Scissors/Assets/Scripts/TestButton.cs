using UnityEngine;

public class TestButton : MonoBehaviour
{
    [SerializeField] Animator _Player_animator;
    [SerializeField] Animator _AI_animator;

    public void _PlayAnimation()
    {
        _Player_animator.SetBool("Play", true);
        _AI_animator.SetBool("Play", true);
    }

    public void AnimatorSetBoolFalse()
    {
        _Player_animator.SetBool("Play", false);
        _AI_animator.SetBool("Play", false);
    }
}
