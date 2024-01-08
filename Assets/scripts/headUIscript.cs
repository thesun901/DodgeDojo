using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class headUIscript : MonoBehaviour {
    public moving mov;
    public ui_bots ub;
    public float UItimer;
    public int survived;
    public Text time;
    public Text surv;
    public GameObject enemy2;
    public int score;

    // Use this for initialization
    void Start () {
        enemy2.SetActive(false);
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
	}
	
	// Update is called once per frame
	void Update () {

        if (mov.Health <= 0)
        {
            endofgame();
        }

        UItimer += Time.deltaTime;
        survived = Mathf.RoundToInt(UItimer / PlayerPrefs.GetFloat("SpeedBoost"));
        time.text = survived.ToString();
        if (survived == 75)
        {
            enemy2.SetActive(true);
        }
	}

    void endofgame()
    {
        Time.timeScale = 0;
        ub.lose();
        score = ((survived + mov.points) * mov.points);
        surv.text = score.ToString();

    }
}
