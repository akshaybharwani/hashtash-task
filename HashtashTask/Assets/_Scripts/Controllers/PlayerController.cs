using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Private Variables

    private Rigidbody _rigidbody;
    
    // Reference to store RigidbodyBooster component
    private RigidbodyBooster _rigidbodyBooster;

    // Bool to check if Player has clicked on a control
    private bool _hasPlayerClickedAControl;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody
        _rigidbody = GetComponent<Rigidbody>();
        
        // Get RigidibodyBooster component
        _rigidbodyBooster = GetComponent<RigidbodyBooster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// Function which boosts Player Up in combination to Right
    /// </summary>
    public void OnClick_BoostPlayerRight()
    {
        CheckAndEnablePlayerGravity();
        
        _rigidbodyBooster.BoostRight();
    }
    
    /// <summary>
    /// Function which boosts Player Up in combination to Left
    /// </summary>
    public void OnClick_BoostPlayerLeft()
    {
        CheckAndEnablePlayerGravity();
        
        _rigidbodyBooster.BoostLeft();
    }

    private void CheckAndEnablePlayerGravity()
    {
        if (!_hasPlayerClickedAControl)
        {
            _rigidbody.useGravity = true;
            _hasPlayerClickedAControl = true;
        }
    }
}
