using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   public static SceneManagement Instance;
   [HideInInspector] public string currentScene;


    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().name.ToString();

        DontDestroyOnLoad(gameObject);

        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
            return;
        }

    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene()
    {
        SceneManagement.Instance.LoadScene(currentScene) ;
    }
}
