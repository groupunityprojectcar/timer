using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;




public class timer : MonoBehaviour
{
    public float totalTime = 60.0f;
    public TextMeshProUGUI countdownText;



    private float timeLeft;



    private void Start()
    {
        timeLeft = totalTime; 
        UpdateCountdownText(); 
    }



    private void Update()
    {
        timeLeft -= Time.deltaTime;



        if (timeLeft <= 0)
        {
            timeLeft = 0;
            Debug.Log("DDDDD");
            SceneManager.LoadScene(0);




        }



        UpdateCountdownText(); 
    }



    private void UpdateCountdownText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        string timeString = string.Format("{0:0}:{1:00}", minutes, seconds);
        countdownText.text = "Time Left: " + timeString;
    }




}