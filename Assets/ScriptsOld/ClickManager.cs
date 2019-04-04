using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour {
    public Text[] Texts;
    public string[] Ans;
    private string[] Anscopy = new string[18];
    public GameObject ImgController;

    public Sprite[] Imgs;

    private int maxi = 17;
    // Use this for initialization
    private void Awake()
    {
        PlayerPrefs.SetInt("I", 0);
        PlayerPrefs.SetInt("WordScore", 0);
    }
    void Start() {
        Change();
    }

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("I") == 18)
        {
            Application.LoadLevel(7);
        }
    }

    void Change()
    {
        for (int g=0; g<18; g++)
        {
            Anscopy[g] = Ans[g];
        }
        
        ImgController.GetComponent<SpriteRenderer>().sprite = Imgs[PlayerPrefs.GetInt("I")];
        
        for (int i=0; i<4; i++)
        {
            int Num = (int)Mathf.Round(Random.Range(1f, maxi));
            
            Texts[i].text = Anscopy[Num];
            if (Num != maxi)
            {
                Anscopy[Num] = Anscopy[maxi];
            }
            maxi -= 1;
            
            maxi--;
        }
        int RandB = (int)Mathf.Round(Random.Range(1f, 4f))-1;
        Texts[RandB].text = Imgs[PlayerPrefs.GetInt("I")].name;

        PlayerPrefs.SetInt("I", PlayerPrefs.GetInt("I") + 1);
        maxi = 17;
    }

    public void OnClick(int Number)
    {
        if (Texts[Number].text == ImgController.GetComponent<SpriteRenderer>().sprite.name)
        {
            PlayerPrefs.SetInt("WordScore", PlayerPrefs.GetInt("WordScore")+1);
            Change();
        }
        else
        {
            if ((PlayerPrefs.GetInt("WordScore") - 1) > -1)
            {
                PlayerPrefs.SetInt("WordScore", PlayerPrefs.GetInt("WordScore") - 1);
            }
            Change();

        }
    }
}