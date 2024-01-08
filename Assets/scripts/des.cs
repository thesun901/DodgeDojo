using UnityEngine;
using System.Collections;

public class des : MonoBehaviour {
    public float dest_timer;
    public head_dodge_script hds;
	void Start () {
	
	}
	
	
	void Update () {
        dest_timer += Time.deltaTime;

        if(dest_timer > 3.5f)
        {
            PlayerPrefs.SetInt("Dodged", PlayerPrefs.GetInt("Dodged") + 1);
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
