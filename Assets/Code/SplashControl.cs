using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Button _MainMenuButton;
    void Start()
    {
        _MainMenuButton.onClick.AddListener
        (delegate{ MainMenuButtonClick(_MainMenuButton); });
    }

    // Update is called once per frame

    
    public void MainMenuButtonClick(Button button) {
        SceneManager.UnloadSceneAsync("SplashScene");
       SceneManager.LoadScene("MainMenuScene");
    }  
    
}
