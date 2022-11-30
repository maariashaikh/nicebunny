using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    List<float> whichNote = new List<float>() { 1, 2, 3, 3, 2, 1, 2, 1 };

    public int noteMark = 0;

    public Transform noteObj;

    public string timerReset = "y";

    public float xPos;

    // Start is called before the first frame update
    void Start()
    {

    }

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
        yield return new WaitForSeconds(1);

        if (whichNote[noteMark] == 1)
        {
            xPos = -1.2f;
        }

        if (whichNote[noteMark] == 2)
        {
            xPos = 0f;
        }

        if (whichNote[noteMark] == 3)
        {
            xPos = 1.2f;
        }

        noteMark += 1;
        timerReset = "y";
        Instantiate(noteObj, new Vector3(xPos, -0.57f, 12f), noteObj.rotation);
    }
}
