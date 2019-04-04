using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeBlock : MonoBehaviour {
    public int Level;
    public GameObject[] ott;
    private int[] temp = new int[5];
    // Use this for initialization
    private void Awake()
    {
        PlayerPrefs.SetString("sum", "");
    }
    void Start () {
        Level = PlayerPrefs.GetInt("lvl");
        print(PlayerPrefs.GetInt("lvl"));
        if (Level == 6)
        {
            print("APPl");
            Level = 1;
            Application.LoadLevel("MainMenu");
        }
        else
        {
            ForInst();
        }
	}

    public void ForInst()
    {
        for (int i = 0; i < 5; i++)
        {
            temp[i] = (int)Mathf.Round(Random.Range(1f, 6f));
        }
        switch (Level){
            case 1:
                print("case1");
                Instantiate(ott[temp[1]], new Vector3(-4, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[2]], new Vector3(4, 0, 0), Quaternion.identity);
                PlayerPrefs.SetString("Ans1", (System.Convert.ToInt32(ott[temp[1]].name)+ System.Convert.ToInt32(ott[temp[2]].name)).ToString());
                break;
            case 2:
                print("case2");
                Instantiate(ott[temp[0]], new Vector3(-4, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[4]], new Vector3(4, 0, 0), Quaternion.identity);
                PlayerPrefs.SetString("Ans1", (System.Convert.ToInt32(ott[temp[0]].name) + System.Convert.ToInt32(ott[temp[4]].name)).ToString());
                break;
            case 3:
                print("case3");
                Instantiate(ott[temp[1]], new Vector3(-4, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[3]], new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[2]], new Vector3(4, 0, 0), Quaternion.identity);
                PlayerPrefs.SetString("Ans1", (System.Convert.ToInt32(ott[temp[1]].name) + System.Convert.ToInt32(ott[temp[3]].name) + System.Convert.ToInt32(ott[temp[2]].name)).ToString());
                break;
            case 4:
                print("case4");
                Instantiate(ott[temp[0]], new Vector3(-6, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[1]], new Vector3(-2, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[3]], new Vector3(2, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[2]], new Vector3(6, 0, 0), Quaternion.identity);
                PlayerPrefs.SetString("Ans1", (System.Convert.ToInt32(ott[temp[0]].name) + System.Convert.ToInt32(ott[temp[1]].name) + 
                    System.Convert.ToInt32(ott[temp[3]].name) + System.Convert.ToInt32(ott[temp[2]].name)).ToString());
                break;
            case 5:
                print("case5");
                Instantiate(ott[temp[1]], new Vector3(-6, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[3]], new Vector3(-3, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[2]], new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[4]], new Vector3(3, 0, 0), Quaternion.identity);
                Instantiate(ott[temp[0]], new Vector3(6, 0, 0), Quaternion.identity);
                PlayerPrefs.SetString("Ans1", (System.Convert.ToInt32(ott[temp[1]].name) + System.Convert.ToInt32(ott[temp[3]].name) + 
                    System.Convert.ToInt32(ott[temp[2]].name) + System.Convert.ToInt32(ott[temp[4]].name) + System.Convert.ToInt32(ott[temp[0]].name)).ToString());
                break;
        }
    }
}