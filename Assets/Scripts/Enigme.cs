using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme : MonoBehaviour {

    public Transform canvas;

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Debug.Log("Question activated");
            canvas.gameObject.SetActive(true);
        }
    }
}
