using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManag : MonoBehaviour
{
    public int loadGame;
    public void StartGame()
    {
        SceneManager.LoadScene(loadGame); 
    }

   
}
