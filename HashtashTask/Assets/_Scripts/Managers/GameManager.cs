using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Public Variables

    [Header("Managers")] 
    public UIManager UIManager;

    [Header("Controllers")] 
    public EnemyController EnemyControllerComponent;

    [Header("Animators")] 
    public Animator InstructionPanelAnimator;

    [Header("AnimationClips")] public AnimationClip InstructionPanelAnimationClip;

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
    /// Performs Start functions after Instructions
    /// </summary>
    public void OnClick_StartGame()
    {
        // Show Instruction Panel
        UIManager.ShowInstructionPanelAndStartGame();
        
        // Enable Instruction Animator
        InstructionPanelAnimator.enabled = true;

        StartCoroutine(WaitAndStartEnemy());
    }

    private IEnumerator WaitAndStartEnemy()
    {
        // Wait for Instructions to finish
        yield return new WaitForSeconds(InstructionPanelAnimationClip.length);
        
        // Activate Enemy's movements
        EnemyControllerComponent.StartEnemy();
    }
    
    /// <summary>
    /// Performs End functions showing End Game Panel and Winner
    /// </summary>
    public void EndGame(string winner)
    {
        // Stop Enemy 
        EnemyControllerComponent.StopEnemy();
        
        UIManager.ShowEndGamePanelWithWinner(winner);
    }

    /// <summary>
    /// Restarts the Game
    /// </summary>
    public void OnClick_RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
