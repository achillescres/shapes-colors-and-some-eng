using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMenu : MonoBehaviour {
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
		PlayerPrefs.SetInt("lvl", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
