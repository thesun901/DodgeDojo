using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour {

    public float timer;
    private float[] reaction_time = new float[5];
    public float rand;
    public float min = 1;
    public float max;
    public Image face;
    public Sprite good;
    public Sprite bad;
    public int i;
    public float sr;
    public Text average;
    public Text maximum;
    public Text minimum;
    public GameObject ready;
    public GameObject stats;
    public GameObject minmenu;

	void Start () {
        rand = Random.Range(0.7f, 3.3f);
        i = 0;
        stats.SetActive(false);
        minmenu.SetActive(false);
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= rand)
        {
            face.sprite = bad;
            reaction_time[i] += Time.deltaTime;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                face.sprite = good;
                timer = 0;
                rand = Random.Range(0.7f, 3.3f);
                i++;
            }
        }
        if(i == 5)
        {
            Time.timeScale = 0;
            stats.SetActive(true);
            minmenu.SetActive(true);

            sr = (reaction_time[0] + reaction_time[1] + reaction_time[2] + reaction_time[3] + reaction_time[4]) / 5 * 1000;
            average.text = "your average time of reaction: " + Mathf.Round(sr).ToString() + "ms";
            for (int a = 0; a < 4; a++) //wczytanie pozostałych n-1 liczb
            {
                if (min > reaction_time[a])
                    //podmieniamy, gdy znajdziemy mniejszą niz min
                    min = reaction_time[a];
            }

            minimum.text = "The least time of reaction: " + Mathf.Round(min * 1000).ToString() + " ms";

            for (int b = 0; b < 4; b++) //wczytanie pozostałych n-1 liczb
            {
                if (max < reaction_time[b])
                    //podmieniamy, gdy znajdziemy mniejszą niz min
                    max = reaction_time[b];
            }

            maximum.text = "The highest time of reaction: " + Mathf.Round(max * 1000).ToString() + " ms";

        }

        if (Input.GetKeyDown(KeyCode.Escape) && i < 5) 
        {
            minmenu.SetActive(!minmenu.active);
        }
    }

    public void retry()
    {
        Application.LoadLevel(3);
    }

    public void menu()
    {
        Application.LoadLevel(0);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void go()
    {
        Time.timeScale = 1;
        ready.SetActive(false);
    }
        
}
