using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyBooster : MonoBehaviour
{
    #region Public Variables

    [Header("Force Value")] 
    public float ForceAmount = 100f;

    #endregion

    #region Private Variables

    // Reference to store the Rigidbody Component 
    private Rigidbody _rigidbody;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody Component
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Function which boosts a rigidbody Up after existing velocity reset
    /// using ForceAmount
    /// </summary>
    private void BoostUp()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.AddForce(Vector3.up * ForceAmount);
    }
    
    /// <summary>
    /// Function which boosts a rigidbody Up in combination to Right
    /// </summary>
    public void BoostRight()
    {
        BoostUp();
        _rigidbody.AddForce(Vector3.right * ForceAmount);
    }
    
    /// <summary>
    /// Function which boosts a rigidbody Up in combination to Left
    /// </summary>
    public void BoostLeft()
    {
        BoostUp();
        _rigidbody.AddForce(Vector3.right * -ForceAmount);
    }
}
