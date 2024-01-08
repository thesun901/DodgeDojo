using UnityEngine;
using System.Collections;

public class fire_ball2 : MonoBehaviour
{

    float dest1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(20 * Time.deltaTime, 20 * Time.deltaTime, 0);

        dest1 += Time.deltaTime;

        if (dest1 > 4)
        {
            Destroy(gameObject);
        }
    }
}

