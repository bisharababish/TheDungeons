using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorC : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "keyRed")
        {
            GameObject.FindGameObjectsWithTag("ball");
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (other.tag == "keyBlack")
        {
            GameObject.FindGameObjectsWithTag("ball");
            GetComponent<Renderer>().material.color = Color.black ;
        }
    }
}
