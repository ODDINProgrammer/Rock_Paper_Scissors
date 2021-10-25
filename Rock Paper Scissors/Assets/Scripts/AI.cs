using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private GameObject AI_GO;
    GameManager.Choice AI_choice;

    public GameManager.Choice AI_make_choice()
    {
        int random = Random.Range(0, 3);

        switch(random)
        {
            case 0:
                AI_choice = GameManager.Choice.Rock;
                break;
            case 1:
                AI_choice = GameManager.Choice.Paper;
                break;
            case 2:
                AI_choice = GameManager.Choice.Scissors;
                break;
            default:
                break;
        }

        return AI_choice;
    }

}
