using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectStageControl : MonoBehaviour
{
    [SerializeField] Button buttonStage1;
    [SerializeField] Button buttonStage2; 
    [SerializeField] Button buttonBack;
     void SetupButtonsDelegate(){
    buttonStage1.onClick.AddListener(delegate{SelectStage1ButtonClick(buttonStage1);});
    buttonStage2.onClick.AddListener ( delegate {SelectStage2ButtonClick(buttonStage2);});
    buttonBack.onClick.AddListener ( delegate {BackToMainMenuButtonClick(buttonBack);});
 }

    
    public void SelectStage1ButtonClick(Button button) {
        SceneManager.LoadScene("Stage1Scene");
    }


    public void SelectStage2ButtonClick(Button button) {
        SceneManager.LoadScene("Stage2Scene");
    }

    public void BackToMainMenuButtonClick(Button button) {
        SceneManager.UnloadSceneAsync("SelectStageScene");
       SceneManager.LoadScene("MainMenuScene");
    }
}


