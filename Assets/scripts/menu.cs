using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public Animator anim;
    public GameObject lbp;
    public GameObject chosing;
    public bool choosequality_start;
    public bool choosequality_options;
    public float timerquality;
    public GameObject Opt;

	// Use this for initialization
	void Start () {
        //Screen.SetResolution(Mathf.RoundToInt(Screen.currentResolution.width/1.5f), Mathf.RoundToInt(Screen.currentResolution.height/1.5f), false);
        Time.timeScale = 1;
        chosing.active = false;
        Opt.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	if (choosequality_start == true)
        {
            timerquality += Time.deltaTime;
            if(timerquality > 1.40f)
            {
                timerquality = 0;
                choosequality_start = false;
                chosing.active = true;
            }
        }



        if (choosequality_options == true)
        {
            timerquality += Time.deltaTime;
            if (timerquality > 0.9f)
            {
                timerquality = 0;
                choosequality_options = false;
                Opt.SetActive(true);
            }
        }
    }

    public void startin()
    {
        anim.SetTrigger("anplay");
        lbp.active = false;
        choosequality_start = true;
    }

    public void chaoticd()
    {
        SceneManager.LoadScene(1);
    }

    public void backin()
    {
        anim.SetTrigger("backplay");
        lbp.SetActive(true);
        chosing.SetActive(false);
        Opt.SetActive(false);
    }

    public void vsBot()
    {
        SceneManager.LoadScene(2);
    }

    public void options()
    {
        anim.SetTrigger("Options");
        lbp.active = false;
        choosequality_options = true;
    }

    public void checking()
    {
        Application.LoadLevel(3);
    }

    public void exit()
    {
        Application.Quit();
    }

}
