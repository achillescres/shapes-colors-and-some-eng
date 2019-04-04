using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEuler : MonoBehaviour {
    Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        Lv();
	}

	void Lv() {
        print(3.75f / PlayerPrefs.GetFloat("Time"));
        Invoke("SceneGo", 3.625f/PlayerPrefs.GetFloat("Time"));
    }
    private void SceneGo()
    {
        rigid.AddForce(new Vector2(Random.Range(1, 10), Random.Range(1, 10)), ForceMode2D.Impulse);
        Invoke("scene", 0.1575f);
    }
    void scene()
    {
        Application.LoadLevel("NewResult");
    }
}
