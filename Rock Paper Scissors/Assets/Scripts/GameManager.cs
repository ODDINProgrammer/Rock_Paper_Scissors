using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Choice { Rock, Paper, Scissors }

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject AI_GO;

    private AI AI_Manager;
    internal Score ScoreManager;

    private Choice player_choice;
    public Choice ai_choice;

    private void Start()
    {
        AI_Manager = GetComponent<AI>();
        ScoreManager = GetComponent<Score>();
    }
    public void Round_start(Choice received_player_choice)
    {
        ai_choice = AI_Manager.AI_make_choice();
        player_choice = received_player_choice;

        Player.GetComponent<_AnimationController>().Play_Animation();
        AI_GO.GetComponent<_AnimationController>().Play_Animation();

        StartCoroutine(Results_and_display_after_timer(1f));
    }

    public void Evaluate_results()
    {
        if (player_choice == ai_choice)
        {
            Debug.Log("DRAW");
            return;
        }
        switch (player_choice)
        {
            //  IF PLAYER PLAYED ROCK
            case Choice.Rock:
                if (ai_choice == Choice.Paper)
                {
                    Debug.Log("1");
                    ScoreManager.AI_Score++;
                    return;
                }
                else
                {
                    Debug.Log("2");
                    ScoreManager.Player_Score++;
                    return;
                }

            //  IF PLAYER PLAYED PAPER
            case Choice.Paper:
                if (ai_choice == Choice.Scissors)
                {
                    Debug.Log("3");
                    ScoreManager.AI_Score++;
                    return;
                }
                else
                {
                    Debug.Log("4");
                    ScoreManager.Player_Score++;
                    return;
                }

            //  IF PLAYER PLAYED SCISSORS
            case Choice.Scissors:
                if (ai_choice == Choice.Rock)
                {
                    Debug.Log("5");
                    ScoreManager.AI_Score++;
                    return;
                }
                else
                {
                    Debug.Log("6");
                    ScoreManager.Player_Score++;
                    return;
                }
            default:
                break;
        }
    }

    IEnumerator Results_and_display_after_timer(float sec)
    {
        yield return new WaitForSeconds(sec);
        Evaluate_results();
        ScoreManager.UpdateScore();
    }
}
