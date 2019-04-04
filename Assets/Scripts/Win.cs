using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl")+1);
        Invoke("SceneGo", 1.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SceneGo()
    {
        SceneManager.LoadScene("double2");
    }
}
