using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Private Variables

    // Reference to store RigidbodyBooster component
    private RigidbodyBooster _rigidbodyBooster;

    // How many steps have been for rigidbodyBooster till now
    private int _numberOfSteps;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // Get RigidibodyBooster component
        _rigidbodyBooster = GetComponent<RigidbodyBooster>();
        
        InvokeRepeating("BoostRandomly", .5f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void BoostRandomly() 
    {
        if (_numberOfSteps < 4)
        {
            _rigidbodyBooster.BoostLeft();
        }
        else if (_numberOfSteps > 5)
        {
            _rigidbodyBooster.BoostRight();
        }

        if (_numberOfSteps < 9)
            _numberOfSteps++;
        else
            _numberOfSteps = 0;
        
        Debug.Log(_numberOfSteps);
    }
}
