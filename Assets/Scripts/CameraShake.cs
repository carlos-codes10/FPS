using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class CameraShake : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vcam;
    bool isShaking;
    float elapsed = 0f;
    float stoptimer = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0.5f;
        isShaking = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isShaking)
        {
            elapsed += Time.deltaTime;

            if (elapsed > stoptimer)
            {
                vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
                elapsed = 0;
                isShaking = false;
            }
        }

        
    }
}
