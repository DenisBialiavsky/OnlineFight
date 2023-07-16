using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    public string nameNextScene = "Lobby";

    public GameObject progressBar;
    

    public Image progressBarImage;

    public TextMeshProUGUI progressText;

    AsyncOperation async_operation;

    void Start()
    {
        PlayerPrefs.SetString("current_scene", nameNextScene);
        SceneManager.LoadScene("Loading");
        if (SceneManager.GetActiveScene().name == "Loading") StartCoroutine("Async_COR", PlayerPrefs.GetString("current_scene")); 
    }
    IEnumerator Async_COR(string nameScene)
    {
        float loadingProgress;
        async_operation = SceneManager.LoadSceneAsync(nameScene);
        progressBar.SetActive(true);

        async_operation.allowSceneActivation = false;
        while (!async_operation.isDone) 
        {
            loadingProgress = Mathf.Clamp01(async_operation.progress / 0.9f);
            progressText.text = $"Loading...{(loadingProgress * 100).ToString("0")}%";
            progressBarImage.fillAmount = loadingProgress;
           
            yield return null;
        }

    }
}

  
