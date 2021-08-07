using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public ObjectInHand objectInHand;

    private bool inHand = false;
    public bool InHand {
        get{
            return inHand;
        }
        set{
            if(inHand == value) return;
            inHand = value;
            if(inHand){
                print("holding " + gameObject.name);
                print(objectInHand.gameObject.name);
                if(objectInHand != null) objectInHand.pickUp(this);
            } 
            else{
                print("dropping " + gameObject.name);
                if(objectInHand != null) objectInHand.throwDown();
            } 
        }
    }


    void Start()
    {
        Game.instance.registerPickupObject(this);
        if(objectInHand != null) objectInHand.gameObject.SetActive(false);

    }

    void Update()
    {
        
    }
}
