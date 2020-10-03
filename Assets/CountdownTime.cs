using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTime : MonoBehaviour
{
    
        float currentTime = 0f;
        float StartTime = 30f;

     



        [SerializeField] Text CountdownText;
    void Start()
    {
        currentTime = StartTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");
        if(currentTime <=0){
            currentTime = 0;
            
        }
    }
}
