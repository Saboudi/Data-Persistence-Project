using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Persistence : MonoBehaviour
{

    public static Persistence Instance;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        }


    }

    public void MainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
