using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Station : MonoBehaviour
{
    bool isInRange;
    public KeyCode interactKey;
    public UnityEvent<int> interactAction;
    public UnityEvent<int> UpdateAmmo;
    Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = FindObjectOfType<Gun>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if(gun.ammo == 0)
                {
                    interactAction?.Invoke(gun.maxAmmo);
                    UpdateAmmo?.Invoke(gun.maxAmmo);
                }
                
            }

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<FPSController>() != null)
        {
            isInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<FPSController>() != null)
        {
            isInRange = false;
        }
    }
}
