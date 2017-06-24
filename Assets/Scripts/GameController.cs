using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Test1");
        if (col.gameObject.tag == "Trap")
        {

            Debug.Log("Test2");
            SceneManager.LoadScene(1);
        }
    }

}
