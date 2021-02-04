using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    Rigidbody2D prb;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.reachBackgroundEnd += GoBack;
        prb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = GameObject.Find("Main Camera").transform.position;
        move();
    }
    void GoBack(){
        transform.position = new Vector2(transform.position.x, transform.position.y - 24f);
    }
    void move(){
        float vs = .5f;
        float hs = 0f;
        if(Input.GetKey(KeyCode.UpArrow)) vs = 5;
        if(Input.GetKey(KeyCode.DownArrow)) vs = -5;
        if(Input.GetKey(KeyCode.LeftArrow)) hs = -5;
        if(Input.GetKey(KeyCode.RightArrow)) hs = 5;
        if(Input.GetKey(KeyCode.Z)){
            GameObject bullet = GameObject.Instantiate(projectile, transform.position, transform.rotation);
        } 
        prb.velocity = new Vector2(hs,vs);
    }
}
