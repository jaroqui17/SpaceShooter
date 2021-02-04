using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.reachBackgroundEnd += RunBackgroundEndReached;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y + 0.005f, -10);
        if(transform.position.y > 24) GameEvents.current.BackgroundEndReached();
        
    }

    private void RunBackgroundEndReached(){
        transform.position = new Vector3(0, 0, -10);
    }
}
