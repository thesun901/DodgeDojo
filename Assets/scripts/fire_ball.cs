using UnityEngine;
using System.Collections;

public class fire_ball : MonoBehaviour
{
    public int speed;

   
    void Start()
    {
        speed = 28;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);



    }
}
