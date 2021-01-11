using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region Public Variables

    [Header("Color")] 
    public Color32 FilledPointColor;
    
    [Header("Player UI")] 
    public TextMeshProUGUI PlayerScoreText;
    public Image[] PlayerPointsImages;
    
    [Header("Player UI")] 
    public TextMeshProUGUI EnemyScoreText;
    public Image[] EnemyPointsImages;

    #endregion

    #region Private Variables

    // Reference to store current Scores
    private int _playerCurrentScore;
    private int _enemyCurrentScore;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (_playerCurrentScore < PlayerPointsImages.Length)
        {
            // Update Points Image
            PlayerPointsImages[_playerCurrentScore].color = FilledPointColor;
            
            // Increase the score by 1
            _playerCurrentScore++;
        
            // Update Score Text
            PlayerScoreText.text = _playerCurrentScore.ToString();
        }
    }
    
    /// <summary>
    /// Function which increases the Enemy's score by 1 and updates
    /// the Enemy's Points in UI
    /// </summary>
    public void UpdateEnemyScore()
    {
        if (_enemyCurrentScore < EnemyPointsImages.Length)
        {
            // Update Points Image
            EnemyPointsImages[_enemyCurrentScore].color = FilledPointColor;
        
            // Increase the score by 1
            _enemyCurrentScore++;
        
            // Update Score Text
            EnemyScoreText.text = _enemyCurrentScore.ToString();
        }
    }
}
