using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Stage1MenuControl : MonoBehaviour
{
    [SerializeField] Button _buttonBack;
    void SetupButtonsDelegate(){

_buttonBack.onClick.AddListener ( delegate {BackToMainMenuButtonClick(_buttonBack);});

    }

    public void BackToMainMenuButtonClick(Button button) {
        SceneManager.UnloadSceneAsync("Stage1Scene");
        SceneManager.LoadScene("MainMenuScene");
    }
}
