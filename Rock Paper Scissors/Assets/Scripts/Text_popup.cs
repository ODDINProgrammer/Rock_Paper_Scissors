using UnityEngine;

public class Text_popup : MonoBehaviour
{
    [SerializeField] Animator animator;
    private void OnEnable()
    {
        animator.SetBool("Play", true);
    }
    public void Stop_animation_and_disable_object()
    {
        animator.SetBool("Play", false);
        this.gameObject.SetActive(false);
    }
}
