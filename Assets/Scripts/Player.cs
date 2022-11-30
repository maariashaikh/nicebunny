using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Player : MonoBehaviour
{
    public GameObject player;
    int positionIndex = 1;
    float leftPositionX = -1.2f;
    float middlePositionX = 0f;
    float rightPositionX = 1.2f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;

            if (positionIndex == 1)
            {
                position.x = leftPositionX;
                positionIndex = 0;
                transform.DOMove(position, 0.5f);
            }
            else if (positionIndex == 2)
            {
                position.x = middlePositionX;
                positionIndex = 1;
                transform.DOMove(position, 0.5f);
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;

            if (positionIndex == 1)
            {
                position.x = rightPositionX;
                positionIndex = 2;
                transform.DOMove(position, 0.5f);
            }
            else if (positionIndex == 0)
            {
                position.x = middlePositionX;
                positionIndex = 1;
                transform.DOMove(position, 0.5f);
            }
        }
    }
}
