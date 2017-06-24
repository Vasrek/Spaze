using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme : MonoBehaviour {

    public Transform canvas;
    public Collider Yellow;
    public Collider Green;
    public Collider Red;

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "End")
        {
            Debug.Log("Question activated");
            canvas.gameObject.SetActive(true);
        }
        if (Player.gameObject.tag == "Red")
        {
            Debug.Log("Red");
        }
        if (Player.gameObject.tag == "Yellow")
        {
            Debug.Log("Yellow");
        }
        if (Player.gameObject.tag == "Green")
        {
            Debug.Log("Green");
        }
    }
}
