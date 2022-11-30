using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public Transform noteObj;
    public string timerReset = "y";
    public float xPos;
    public float numOfNotes = 0;
    public float numOfCorrectNotes = 0;

    // Update is called once per frame
    void Update()
    {
        if (timerReset == "y")
        {
            StartCoroutine(spawnNote());
            timerReset = "n";
        }
    }

    IEnumerator spawnNote()
    {
        yield return new WaitForSeconds(0.61856f);
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
}
