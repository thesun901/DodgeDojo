using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning2 : MonoBehaviour {

    public int randomizer1;
    public float randomizer2;
    public GameObject diamond;
    public float start_spawn;
    public float timing;
    public int inpoints;
    public moving mov;

	// Use this for initialization
	void Start () {
        randomizer1 = Random.RandomRange(1, 5);
        randomizer2 = Random.RandomRange(1, 100);
        start_spawn = randomizer1 - (randomizer2 *0.01f);

    }
	
	// Update is called once per frame
	void Update () {
        timing += Time.deltaTime;

        if (timing > start_spawn)
        {
            if (mov.points == inpoints)
            {
               Instantiate(diamond, transform.position, transform.rotation);
                inpoints++;
            }
        }
	}
}
