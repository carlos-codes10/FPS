using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damager : MonoBehaviour
{
    public UnityEvent onCollsion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        onCollsion?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
