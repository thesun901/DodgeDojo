using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ui_dodge : MonoBehaviour {
    public moving mov;
    public GameObject gameover;
    public GameObject escape;
    public bool escaped;
    public Text survived;
    public head_dodge_script hds;
    public float surv;
    public Text dodged;
    public int dgd;
    public GameObject GoButton;
    public Text realtime;
    public Text score;
    public int finalscore;
    public Text Out_score;

    public GameObject Hp1;
    public GameObject Hp2;
    public GameObject Hp3;
    public GameObject Hp4;

 
    // Use this for initialization
    void Start () {
        gameover.active = false;
        escaped = false;
        PlayerPrefs.SetInt("Dodged", 0);
     
	}
	
	// Update is called once per frame
	void Update () {

        finalscore = Mathf.RoundToInt((hds.head_timer + mov.points) * mov.points);
        Out_score.text = finalscore.ToString();

        dgd = PlayerPrefs.GetInt("Dodged");
        surv = hds.head_timer;
    

        HealthPoints();
        end();
        esc();

        realtime.text = Mathf.Round(surv / PlayerPrefs.GetFloat("SpeedBoost")).ToString();

        score.text = mov.points.ToString();
    }

    void HealthPoints()
    {
        switch (mov.Health)
        {
            case 0:
                Hp1.active = false;
                Hp2.active = false;
                Hp3.active = false;
                Hp4.active = false;
                break;


            case 1:
                Hp1.active = true;
                Hp2.active = false;
                Hp3.active = false;
                Hp4.active = false;
                break;

            case 2:
                Hp1.active = true;
                Hp2.active = true;
                Hp3.active = false;
                Hp4.active = false;
                break;

            case 3:
                Hp1.active = true;
                Hp2.active = true;
                Hp3.active = true;
                Hp4.active = false;
                break;

            case 4:
                Hp1.active = true;
                Hp2.active = true;
                Hp3.active = true;
                Hp4.active = true;
                break;

        }
    }

        void end()
    {
        if(mov.Health < 1)
        {
            Time.timeScale = 0;
            gameover.active = true;
            mov.alive = false;
       //     survived.text = surv.ToString() + " seconds";
       //     dodged.text = PlayerPrefs.GetInt("Dodged").ToString();
          
        }
    }

   public void exit()
    {
        Application.Quit();
    }

   public void retry()
    {
        Application.LoadLevel(1);
    }


    public void menu()
    {
        Application.LoadLevel(0);
    }

    void esc()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            escaped = !escaped;
        }

        if(escaped == false)
        {
            escape.active = false;
        }

        if (escaped == true)
        {
            escape.active = true;
        }
    }

    public void back()
    {
        escaped = false;
    }

    public void go()
    {
        Time.timeScale = 1 * PlayerPrefs.GetFloat("SpeedBoost");

        GoButton.SetActive(false);

    }
}
