using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region Public Variables

    [Header("Managers")] 
    public GameManager GameManager;
    
    [Header("Color")] 
    public Color32 FilledPointColor;

    [Header("Player")] 
    public string PlayerName;
    public TextMeshProUGUI PlayerScoreText;
    public Image[] PlayerPointsImages;

    [Header("Enemy")] 
    public string EnemyName;
    public TextMeshProUGUI EnemyScoreText;
    public Image[] EnemyPointsImages;

    #endregion

    #region Private Variables

    // Reference to store current Scores
    private int _playerCurrentScore;
    private int _enemyCurrentScore;

    private int _pointsRequiredToWin;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // Set Points Required To Win based on Player's Number of Point Images
        _pointsRequiredToWin = PlayerPointsImages.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Function which increases the Player's score by 1 and updates
    /// the Player's Points in UI
    /// </summary>
    public void UpdatePlayerScore()
    {
        if (_playerCurrentScore < _pointsRequiredToWin)
        {
            // Update Points Image
            PlayerPointsImages[_playerCurrentScore].color = FilledPointColor;
            
            // Increase the score by 1
            _playerCurrentScore++;
        
            // Update Score Text
            PlayerScoreText.text = _playerCurrentScore.ToString();
        }
        
        if (_pointsRequiredToWin == _playerCurrentScore)
        {
            GameEnd(PlayerName);
        }
    }
    
    /// <summary>
    /// Function which increases the Enemy's score by 1 and updates
    /// the Enemy's Points in UI
    /// </summary>
    public void UpdateEnemyScore()
    {
        if (_enemyCurrentScore < _pointsRequiredToWin)
        {
            // Update Points Image
            EnemyPointsImages[_enemyCurrentScore].color = FilledPointColor;
        
            // Increase the score by 1
            _enemyCurrentScore++;
        
            // Update Score Text
            EnemyScoreText.text = _enemyCurrentScore.ToString();
        }
        
        if (_pointsRequiredToWin == _enemyCurrentScore)
        {
            GameEnd(EnemyName);
        }
    }

    private void GameEnd(string winner)
    {
        GameManager.EndGame(winner);
    }
}
