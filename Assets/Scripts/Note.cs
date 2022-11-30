using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Note : MonoBehaviour
{
    public bool isMoveable;

    private void Start()
    {
        if (isMoveable)
        {
            transform.DOMoveZ(-4, 1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isMoveable && other.tag == "Player")
        {
            Debug.Log("hit player");
            this.gameObject.SetActive(false);
        }
    }
}
