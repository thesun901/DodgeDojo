using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class options : MonoBehaviour {

    public Dropdown ScreenResolution;
    public Slider Volume;
    public Slider TimeBoost;
    public Resolution[] res;
    public OptionsUI gameSettings;
    public Text resscr;
    public Text timespeed;


    void Start()
    {
        if (PlayerPrefs.GetFloat("SpeedBoost") < 0.5f || PlayerPrefs.GetFloat("SpeedBoost") > 3f)
        {
            Volume.value = 0.5f;
            TimeBoost.value = 4;
        }

        else
        {
            Volume.value = PlayerPrefs.GetFloat("Volume");
            TimeBoost.value = PlayerPrefs.GetFloat("SpeedBoost") * 4;
        }
        
    }
    void OnEnable()
    {
        gameSettings = new OptionsUI();
        ScreenResolution.onValueChanged.AddListener(delegate { OnResolutionChange();});
        res = Screen.resolutions;
        ScreenResolution.value = gameSettings.screenRes;
        foreach (Resolution resolution in res)
       
        {
            ScreenResolution.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }

    
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(res[ScreenResolution.value].width, res[ScreenResolution.value].height, Screen.fullScreen);
        
    }

    void Update()
    {
        if(PlayerPrefs.GetFloat("SpeedBoost") < 0.5f || PlayerPrefs.GetFloat("SpeedBoost") > 3f)
        {
            TimeBoost.value = 4;
            Volume.value = 0.5f;
           
        }

        PlayerPrefs.SetFloat("SpeedBoost", TimeBoost.value / 4);
        PlayerPrefs.SetFloat("Volume", Volume.value);

        timespeed.text = "SpeedBoost: x" + PlayerPrefs.GetFloat("SpeedBoost").ToString();

    }
}
