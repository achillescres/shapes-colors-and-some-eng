using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneFalse : MonoBehaviour {
    private Destroy script;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "red")
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+1);
            collision.gameObject.tag = "v";
        }
        if (collision.gameObject.tag == "green")
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 1);
            collision.gameObject.tag = "v";
        }
        if (PlayerPrefs.GetInt("Score") < 0)
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        script = GetComponent<Destroy>();
        script.Setup(collision.gameObject);
    }
}
