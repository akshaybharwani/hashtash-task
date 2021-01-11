using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    #region Public Variables

    [Header("Hoop Tags To Compare With")]
    public string PlayerTag;
    public string EnemyTag;

    #endregion
    
    #region Private Variables

    // Reference to store ScoreManager component
    private ScoreManager _scoreManagerComponent;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // Get Score Manager Component from Hierarchy
        _scoreManagerComponent = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(PlayerTag))
        {
            _scoreManagerComponent.UpdatePlayerScore();
        }
        else if (collider.CompareTag(EnemyTag))
        {
            _scoreManagerComponent.UpdateEnemyScore();
        }
    }
}
