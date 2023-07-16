using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static Image healthBar;

    
    float dmg = 0.3f;

    private void Start()
    {
        healthBar = GetComponent<Image>(); 
    }
    
    public void SetHealthBarValue(float value) { healthBar.fillAmount = value; }

    public  float GetHealthBarValue() { return healthBar.fillAmount; }

    public void Health()
    {
        
        SetHealthBarValue(GetHealthBarValue() - dmg);
        
        if (healthBar.fillAmount <= 0 )
        {
            Debug.Log("Lose");
        }
    }
}
