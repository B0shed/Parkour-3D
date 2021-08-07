using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInHand : MonoBehaviour
{

    public Pickable pickableObject;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void pickUp(Pickable pickable){
        gameObject.SetActive(true);
        pickableObject = pickable;
        pickable.gameObject.SetActive(false);
    }

    public void throwDown(){
        pickableObject.transform.position = gameObject.transform.position;
        pickableObject.transform.rotation = gameObject.transform.rotation;
        pickableObject.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

}
