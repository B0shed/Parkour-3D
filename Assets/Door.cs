using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    public GameObject key;
    public float minDistance = 3;
    public bool moving = false;
    public Transform openPos;
    public float speed = 1.5f;

    void Start()
    {
        
    }

    void Update()
    {
        if(checkKeyDistance()){
            moving = true;
            key.SetActive(false);
            key.transform.position = new Vector3(21474836,-21474836, 21474836);
        }

        if(moving){
            if(checkOpenDistance()) moving=false;
            else{
                transform.position = Vector3.MoveTowards(transform.position, openPos.position, speed * Time.deltaTime);
            }
        }
    }

    bool checkKeyDistance(){
        float distance = Vector3.Distance(transform.position, key.transform.position);
        return distance < minDistance;
    }

    bool checkOpenDistance(){
        float distance = Vector3.Distance(transform.position, openPos.transform.position);
        return distance <= 0.001f;
    }
}
