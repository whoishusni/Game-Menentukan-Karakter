using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main");
    }
    public void loadSceneLoading()
    {
        SceneManager.LoadScene("Loading");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
