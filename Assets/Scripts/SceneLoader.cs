using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

   
    public void LoadScene(string NiceBunny)
    {
        SceneManager.LoadScene(NiceBunny);
       // SceneManager.LoadScene(CoolBunny);
        //SceneManager.LoadScene(BadBunny);
    }
    
    
    // Start is called before the first frame update
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
