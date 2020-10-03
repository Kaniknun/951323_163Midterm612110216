using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuControl : MonoBehaviour
{
     [SerializeField] Button buttonSelectStage;
 [SerializeField] Button buttonOptions; 
 [SerializeField] Button buttonCredits;
 [SerializeField] Button buttonExit;


    void Start()
    {
      
 }

     void SetupButtonsDelegate(){
    buttonSelectStage.onClick.AddListener(delegate{SelectStageButtonClick(buttonSelectStage);});
    buttonOptions.onClick.AddListener ( delegate {OptionsButtonClick(buttonOptions);});
    buttonCredits.onClick.AddListener ( delegate {CreditsButtonClick(buttonCredits);});
    buttonExit.onClick.AddListener ( delegate {ExitButtonClick(buttonExit);});

 }

        public void SelectStageButtonClick(Button button) {
        SceneManager.LoadScene("SelectStageScene");
 }

        public void OptionsButtonClick(Button button) {
    if (!GameApplicationManager.Instance.IsOptionMenuActive)
 {
        SceneManager.LoadScene("OptionsScene", LoadSceneMode.Additive);
        GameApplicationManager.Instance.IsOptionMenuActive = true;
  }
 }

        public void CreditsButtonClick(Button button) 
        {
        SceneManager.LoadScene("CreditsScene");
 }

        public void ExitButtonClick(Button button) 
        {
        Application.Quit();

}



}
