using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ui_bots : MonoBehaviour {

    public bool menuon;
    public GameObject escapemenu;
    public GameObject endmenu;
    public moving mov;
    public Text diamonds_score;
    public GameObject hp1;
    public GameObject hp2;
    public GameObject hp3;
    public GameObject hp4;
    public GameObject lets_start;
  

    // Use this for initialization
    void Start () {

        Time.timeScale = 0;
        menuon = false;
        endmenu.active = false;
        escapemenu.active = false;
	}
	
	// Update is called once per frame
	void Update () {

        diamonds_score.text = mov.points.ToString();

        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale != 0)
        {
            menuon = !menuon;
        }

        if (Time.timeScale == 0)
        {
            menuon = false;
        }

        escapemenu.active = menuon;

        healthing();

    }

    public void backtogame()
    {
        menuon = false;
    }

    public void retry()
    {
        SceneManager.LoadScene(2);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void lose()
    {
        endmenu.active = true;
    }

    void healthing()
    {
        if (mov.Health == 4)
        {
            hp1.active = true;
            hp2.active = true;
            hp3.active = true;
            hp4.active = true;

        }

        if (mov.Health == 3)
        {
            hp1.active = true;
            hp2.active = true;
            hp3.active = true;
            hp4.active = false;
        }

        if (mov.Health == 2)
        {
            hp1.active = true;
            hp2.active = true;
            hp3.active = false;
            hp4.active = false;
        }

        if (mov.Health == 1)
        {
            hp1.active = true;
            hp2.active = false;
            hp3.active = false;
            hp4.active = false;
        }

        if (mov.Health == 0)
        {
            hp1.active = false;
            hp2.active = false;
            hp3.active = false;
            hp4.active = false;
        }

    }

    public void go()
    {
        Time.timeScale = 1 * PlayerPrefs.GetFloat("SpeedBoost");
        lets_start.SetActive(false);
    }
}
