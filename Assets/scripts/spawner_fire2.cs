using UnityEngine;
using System.Collections;

public class spawner_fire2 : MonoBehaviour
{
    float tofire1;
    public GameObject ball1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tofire1 += Time.deltaTime;
        if (tofire1 > 1.9f)
        {
            Instantiate(ball1, transform.position, transform.localRotation);
            tofire1 = 0;
        }

    }
}
