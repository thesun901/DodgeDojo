using UnityEngine;
using System.Collections;

public class sword_spawn : MonoBehaviour {

    private float spawntime;
    public int rand_sword;
    public GameObject sword;

	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {

        spawntime += Time.deltaTime;

        if(spawntime > 0.5f)
        {
            spawntime = 0;
            if(Random.Range(1, rand_sword) == 1)
            {
                Instantiate(sword, transform.localPosition, transform.localRotation);
            }

        }
	
	}
}
