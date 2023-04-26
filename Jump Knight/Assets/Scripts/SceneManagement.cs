using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   public static SceneManagement instance;
   [HideInInspector] public string currentScene;


    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().name.ToString();
        Debug.Log(currentScene);
        DontDestroyOnLoad(gameObject);
        

        if (SceneManagement.instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene()
    {
        SceneManagement.instance.LoadScene(currentScene) ;
    }
}
