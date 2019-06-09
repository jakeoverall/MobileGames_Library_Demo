using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Controllers/ScoreKeeper")]
public class ScoreKeeper : ScriptableObject
{
    public int CurrentScore = 0;
    public int HighScore = 0;
    public string ScoreName;

    private void OnEnable()
    {
        CurrentScore = 0;
        HighScore = PlayerPrefs.GetInt(ScoreName, 0);
    }

    public void IncrementScore()
    {
        CurrentScore++;
        CheckHighScore();
    }

    public void SetCurrentScore(int value)
    {
        CurrentScore = value;
        CheckHighScore();
    }

    void CheckHighScore()
    {
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
            PlayerPrefs.SetInt(ScoreName, HighScore);
        }
    }



}
