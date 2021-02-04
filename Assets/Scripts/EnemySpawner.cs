using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject asteroid;
    float Timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 cameraPos = GameObject.Find("Main Camera").transform.position;
    transform.position = cameraPos;
    Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            GameObject astClone = Instantiate(asteroid, transform.position + new Vector3(Random.Range(-5, 5), 5f + Random.Range(0, 2), 10f), transform.rotation);
            Timer = 2f;
        }
    }
}
