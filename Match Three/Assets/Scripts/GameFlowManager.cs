using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    #region singleton

    private static GameFlowManager _instance;

    public static GameFlowManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameFlowManager>();
            }

            return _instance;
        }
    }

    #endregion

    [Header("UI")]
    public UIGameOver GameOverUI;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
    }

    private bool isGameOver = false;

    private void Start()
    {
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreManager.Instance.SetHighScore();
        GameOverUI.Show();
    }
}
