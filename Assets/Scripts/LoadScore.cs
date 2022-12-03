using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadScore : MonoBehaviour
{

public TextMeshProUGUI text;
public int numOfCorrectNotes;
   
    void Update()
    {
       text.text = PlayerPrefs.GetInt("Notes", numOfCorrectNotes).ToString();
       
    }
}




