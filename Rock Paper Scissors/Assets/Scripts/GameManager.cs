using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Choice { Rock, Paper, Scissors}

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject AI_GO;

    private AI AI_control;
    private Choice player_choice;
    public Choice ai_choice;

    private void Start()
    {
        AI_control = GetComponent<AI>();
    }
    public void Round_start(Choice received_player_choice)
    {
        ai_choice = AI_control.AI_make_choice();
        player_choice = received_player_choice;

        Player.GetComponent<_AnimationController>().Play_Animation();
        AI_GO.GetComponent<_AnimationController>().Play_Animation();

        Evaluate_results();
    }

    private void Evaluate_results()
    {
        if(player_choice == ai_choice)
        {
            Debug.Log("DRAW");
            return;
        }
        switch(player_choice)
        {
            //  IF PLAYER PLAYED ROCK
            case Choice.Rock:
                if(ai_choice == Choice.Paper)
                {
                    Debug.Log("AI won");
                    return;
                }
                else
                {
                    Debug.Log("Player won");
                    return;
                }

            //  IF PLAYER PLAYED PAPER
            case Choice.Paper:
                if (ai_choice == Choice.Scissors)
                {
                    Debug.Log("AI won");
                    return;
                }
                else
                {
                    Debug.Log("Player won");
                    return;
                }

            //  IF PLAYER PLAYED SCISSORS
            case Choice.Scissors:
                if (ai_choice == Choice.Rock)
                {
                    Debug.Log("AI won");
                    return;
                }
                else
                {
                    Debug.Log("Player won");
                    return;
                }
            default:
                break;
        }
    }
}
