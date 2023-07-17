using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CoinsCollect : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public static int coin;

    void Update()
    {
        coinText.text = "Score: " + coin + "$";
    }

}
