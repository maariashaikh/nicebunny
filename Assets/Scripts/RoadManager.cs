using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RoadManager : MonoBehaviour

{
    public Transform noteObj;
    public GameObject canvas;
    public int level;
    public AudioSource audioSource;
    public bool gameStart = false;
    public string countdownTimerReset = "y";
    public int countdownTime = 3;
    public string timerReset = "y";
    public float xPos;
    public float numOfNotes = 0;
    public int numOfCorrectNotes = 0;


 // Update is called once per frame
    void Update()

    {
        if (countdownTimerReset == "y")
        {
            if (countdownTime > 0)
            {
                StartCoroutine(countdown());
            }
            else
            {
                gameStart = true;
                canvas.transform.GetChild(3).gameObject.SetActive(false);
                playAudio();
            }

            countdownTimerReset = "n";
        }

        if (gameStart && timerReset == "y")
       {
            StartCoroutine(spawnNote()); 
            timerReset = "n";
        }

    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(1);
        countdownTime -= 1;
        canvas.transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>().SetText(countdownTime.ToString());
        countdownTimerReset = "y";
    }

    public void savePrefs()
    {
        PlayerPrefs.SetInt("Notes", numOfCorrectNotes);
        PlayerPrefs.Save();
    }


    IEnumerator spawnNote()
    {
        float secondPerBeat;

        if (level == 1)
        {
            secondPerBeat = 0.61856f;
        }
        else if (level == 2)
        {
            secondPerBeat = 0.65217f;
        }
        else
        {
            secondPerBeat = 0.73171f;
        }

        yield return new WaitForSeconds(secondPerBeat);
        int randomIndex = Random.Range(0, 3);

        if (randomIndex == 0)
        {
            xPos = -1.2f;
        }

        if (randomIndex == 1)
        {
            xPos = 0f;
        }

        if (randomIndex == 2)
        {
            xPos = 1.2f;
        }

        timerReset = "y";
        Instantiate(noteObj, new Vector3(xPos, -0.57f, 12f), noteObj.rotation);
        numOfNotes += 1;
    }

     public void EndGame()
     {
        StartCoroutine(endGame()); 
     }   

     IEnumerator endGame()
    {
        float delay;

        if (level == 1)
        {
            delay = 3f;
        }
        else if (level == 2)
        {
            delay = 3f;
        }
        else
        {
            delay = 3f;
        }

        yield return new WaitForSeconds(delay);
   
        SceneManager.LoadScene("Main Menu");
    }

    public void increaseScore()
    {
        numOfCorrectNotes += 1;
        canvas.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().SetText("BADNESS SCORE: " + numOfCorrectNotes);
    }

    public void playAudio()
    {
        Debug.Log(audioSource);
        audioSource.Play();
    }

    public void pauseGame()
    {
        audioSource.Pause();
    }

    public void resumeGame()
    {
        audioSource.Play();
    }

}
