using UnityEngine;
using TMPro; 

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PlayerScoreText;
    [SerializeField] private TextMeshProUGUI AIScoreText;

    public int Player_Score;
    public int AI_Score;

    public void UpdateScore()
    {
        PlayerScoreText.SetText(Player_Score.ToString());
        AIScoreText.SetText(AI_Score.ToString());
    }
}
