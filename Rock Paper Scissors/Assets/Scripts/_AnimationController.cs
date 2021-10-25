using UnityEngine;
using UnityEngine.UI;

public class _AnimationController : MonoBehaviour
{
    [Header("Visuals")]
    public Image visual;
    public Image prepare_new_visual;
    [SerializeField] private Sprite defaul_visual;
    [Header("=========================")]
    [SerializeField] private GameObject Selection_Blocker;
    [SerializeField] internal GameManager GM;
    [SerializeField] private Animator animator;

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
