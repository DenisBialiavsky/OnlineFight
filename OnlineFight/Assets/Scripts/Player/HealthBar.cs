using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static Image healthBar;

    float value;

    private void Start()
    {
        healthBar = GetComponent<Image>(); 
    }

    public void SetHealthBarValue(float value) { healthBar.fillAmount = value;}

    public static float GetHealthBarValue() { return healthBar.fillAmount; }

    public void Health()
    {
        SetHealthBarValue(GetHealthBarValue() - 0.03f);
        if (healthBar.fillAmount <= 0 )
        {
            Debug.Log("Lose");
        }
    }
}
