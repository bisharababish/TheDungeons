using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{
    public static string haveKey = "n";
    public static string havekeyy = "no";
    public static string havecoin = "n";
    public static string havecoinn = "n";
    public static string havecoinnn = "n";
    
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 2, Input.GetAxis("Vertical") * 2);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Key")
        {
            haveKey = "y";
        }

        if(other.tag == "key2")
        {
            havekeyy = "yes";
        }

        if(other.tag == "coin")
        {
            havecoin = "y";
        }

        if (other.tag == "keyRed")
        {
            haveKey = "y";
        }

        if (other.tag == "keyBlack")
        {
            havekeyy = "yes";
        }

        if (other.tag == "coin2")
        {
            havecoinn = "y";
        }

        if (other.tag == "coin3")
        {
            havecoinnn = "y";
        }

    }

    private void OnCollisionEnter2D(Collision2D door)
    {
        if ((door.gameObject.tag == "door") && (haveKey == "y"))
        {
            SceneManager.LoadScene("level_2");
        }

        if ((door.gameObject.tag == "door2") && (haveKey == "y"))
        {
            SceneManager.LoadScene("level_3");
        }

        if ((door.gameObject.tag == "door3") && (haveKey == "y") && (havekeyy == "yes") && (havecoin == "y") && (havecoinn == "y") && (havecoinnn == "y"))
        {
            SceneManager.LoadScene("credits");
        }

        if ((door.gameObject.tag == "door4") && (haveKey == "y"))
        {
            SceneManager.LoadScene("home");
        }

    }

}
