using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Public Variables

    [Header("Managers")] 
    public GameManager GameManager;
    
    [Header("UI Panels")] 
    public CanvasGroup StartPanel;
    public CanvasGroup InstructionPanel;
    public CanvasGroup EndGamePanel;

    [Header("Texts")] public TextMeshProUGUI WinnerText;

    #endregion

    #region Private Variables

    private float _animationDuration = 1f;

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
    /// Function which Shows Instructions and at the end of it
    /// starts the game
    /// </summary>
    public void ShowInstructionPanelAndStartGame()
    {
        // Hide Start Panel
        ToggleCanvasGroup(StartPanel, false);
        
        // Show Instructions Panel
        ToggleCanvasGroup(InstructionPanel, true);
    }

    public void ShowEndGamePanelWithWinner(string winner)
    {
        // Set Winner Name in text
        WinnerText.text = winner;
        
        // Show End Game Panel
        ToggleCanvasGroup(EndGamePanel, true);
    }
    
    /// <summary>
    /// Activates/Deactivates a CanvasGroup based on the bool value
    /// </summary>
    /// <param name="canvasGroup"></param>
    /// <param name="toggleValue"></param>
    private void ToggleCanvasGroup(CanvasGroup canvasGroup, bool toggleValue)
    {
        canvasGroup.blocksRaycasts = toggleValue;
        canvasGroup.interactable = toggleValue;

        canvasGroup.DOFade(toggleValue ? 1 : 0, _animationDuration);
    }
}
