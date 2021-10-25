using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    [SerializeField] private Image visual;
    [SerializeField] private GameObject player;
    [SerializeField] private GameManager.Choice player_choice;

    public void prepare_player_visual()
    {
        player.GetComponent<_AnimationController>().prepare_new_visual = this.visual;
    }

    public void _Pass_a_choice_to_game_manager()
    {
        FindObjectOfType<GameManager>().Round_start(player_choice);
    }
}
