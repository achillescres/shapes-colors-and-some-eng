using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Min : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("sum", PlayerPrefs.GetString("sum").Remove(PlayerPrefs.GetString("sum").Length-1));
    }
}
