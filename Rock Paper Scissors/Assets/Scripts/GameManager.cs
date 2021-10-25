using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Choice { Rock, Paper, Scissors }

    [Header("Game Objects")]
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject AI_GO;
    [Header("POP UPS")]
    [SerializeField] private GameObject Win_popup;
    [SerializeField] private GameObject Lose_popup;
    [SerializeField] private GameObject Draw_popup;

    private AI AI_Manager;
    internal Score ScoreManager;

    private Choice Player_choice;
    public Choice AI_choice;

    private void Start()
    {
        AI_Manager = GetComponent<AI>();
        ScoreManager = GetComponent<Score>();
    }
    public void Round_start(Choice received_player_choice)
    {
        AI_choice = AI_Manager.AI_generate_choice();
        Player_choice = received_player_choice;

        Player.GetComponent<_AnimationController>().Play_Animation();
        AI_GO.GetComponent<_AnimationController>().Play_Animation();

        StartCoroutine(Results_and_display_after_timer(1f));
    }

    private void Evaluate_results()
    {
        //  PLAYER LOSE...
        switch (Player_choice)
        {
            //  IF PLAYER PLAYED ROCK VS PAPER
            case Choice.Rock:
                if (AI_choice == Choice.Paper)
                {
                    Lose_popup.SetActive(true);
                    ScoreManager.AI_Score++;
                    return;
                }
                break;

            //  IF PLAYER PLAYED PAPER VS SCISSORS
            case Choice.Paper:
                if (AI_choice == Choice.Scissors)
                {
                    Lose_popup.SetActive(true);
                    ScoreManager.AI_Score++;
                    return;
                }
                break;

            //  IF PLAYER PLAYED SCISSORS VS ROCK
            case Choice.Scissors:
                if (AI_choice == Choice.Rock)
                {
                    Lose_popup.SetActive(true);
                    ScoreManager.AI_Score++;
                    return;
                }
                break;

            default:
                break;
        }

        //  DRAW
        if (Player_choice == AI_choice)
        {
            Draw_popup.SetActive(true);
            return;
        }

        //  PLAYER WIN
        else
        {
            Win_popup.SetActive(true);
            ScoreManager.Player_Score++;
            return;
        }
    }

    IEnumerator Results_and_display_after_timer(float sec)
    {
        yield return new WaitForSeconds(sec);
        Evaluate_results();
        ScoreManager.UpdateScore();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
