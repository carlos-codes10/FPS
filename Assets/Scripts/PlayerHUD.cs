using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.ProBuilder.MeshOperations;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;
    Gun gun; 

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        gun = FindObjectOfType<Gun>();
        maxAmmoText.text = "10";
        currentAmmoText.text = "10";
    }

    public void UpdateAmmoText(int ammoCount)
    {
        currentAmmoText.text = ammoCount.ToString();
    }

    public void UpdateAddedAmmoText(int ammoCount)
    {
        {
            currentAmmoText.text = ammoCount.ToString();
        }
    }
}
