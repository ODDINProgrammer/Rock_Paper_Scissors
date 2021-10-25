using UnityEngine;
using UnityEngine.UI;

public class _AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] public Image visual;
    [SerializeField] public Image prepare_new_visual;
    [SerializeField] public Sprite defaul_visual;
    [SerializeField] private GameObject Selection_Blocker;
    [SerializeField] internal GameManager GM;

    private void Start()
    {
        animator = GetComponent<Animator>();
        GM = FindObjectOfType<GameManager>();
    }

    public void Play_Animation()
    {
        visual.sprite = defaul_visual;
        animator.SetBool("Play", true);
    }

    public void Stop_Animation()
    {
        animator.SetBool("Play", false);
    }

    public virtual void ChangeVisual()
    {
        this.visual.sprite = this.prepare_new_visual.sprite;
    }

    public void BlockSelection()
    {
        if (Selection_Blocker != null)
            Selection_Blocker.SetActive(true);
        return;
    }
    public void unBlockSelection()
    {
        if (Selection_Blocker != null)
            Selection_Blocker.SetActive(false);
        return;
    }
}
