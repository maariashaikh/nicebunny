using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;

            if (position.x > -1.2f)
            {
                position.x += -1.2f;
                this.transform.position = position;
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;

            if (position.x < 1.2f)
            {
                position.x += 1.2f;
                this.transform.position = position;
            }
        }
    }
}
