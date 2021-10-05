using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    #region singleton
    private static ScoreManager _instance = null;

    public static ScoreManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();
            }

            return _instance;
        }
    }
    #endregion

    public int tileRatio;
    public int comboRatio;

    public int HighScore
    {
        get
        {
            return highScore;
        }
    }

    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
    }

    private int highScore;
    private int currentScore;

    private void Start()
    {
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void IncrementCurrentScore(int tileCount, int comboCount)
    {
        currentScore += (tileCount * tileRatio) * (comboCount * comboRatio);
        
        SoundManager.Instance.PlayScore(comboCount > 1);
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }
}


