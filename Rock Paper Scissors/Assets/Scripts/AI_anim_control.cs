using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_anim_control : _AnimationController
{
    [Header("Visuals")]
    [SerializeField] private Sprite Rock;
    [SerializeField] private Sprite Paper;
    [SerializeField] private Sprite Scissors;

    public override void ChangeVisual()
    {
        switch(GM.ai_choice)
        {
            //  CHANGE TO ROCK
            case GameManager.Choice.Rock:
                this.visual.sprite = Rock;
                break;

            //  CHANGE TO PAPER
            case GameManager.Choice.Paper:
                this.visual.sprite = Paper;
                break;

            //  CHANGE TO SCISSORS
            case GameManager.Choice.Scissors:
                this.visual.sprite = Scissors;
                break;

            default:
                break;
        }
    }
}
