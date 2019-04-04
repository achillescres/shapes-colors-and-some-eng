using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        this.GetComponent<Text>().text = PlayerPrefs.GetString("sum");
        if (this.GetComponent<Text>().text == PlayerPrefs.GetString("Ans1")){
            Invoke("Check", 0.375f);
        }
	}
    public void Check()
    {
        if (this.GetComponent<Text>().text == PlayerPrefs.GetString("Ans1"))
        {
            Application.LoadLevel("Win");
        }
    }
}