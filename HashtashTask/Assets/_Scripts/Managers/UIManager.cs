using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Public Variables

    [Header("UI Panels")] 
    public CanvasGroup StartPanel;
    public CanvasGroup InstructionPanel;

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
