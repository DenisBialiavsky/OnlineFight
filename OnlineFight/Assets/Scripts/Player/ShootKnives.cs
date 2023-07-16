using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShootKnives : MonoBehaviour
{
    public GameObject knives;

    public Transform shotPoint;

    public Button ShootButtom;
    private float timeBtwShorts;
    public float startimeBtwShorts;

    private void Update()
    {
        
            if (Input.GetKeyUp(KeyCode.Space)) { ShootKnivesButton(); }
    }
    public void ShootKnivesButton()
    {
        Instantiate(knives, shotPoint.position, transform.rotation);
        
    }
}
  
