using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game instance;
    public List<Pickable> pickables = new List<Pickable>();

    public bool rightMouseDown = false;
    public float playerReach = 5.0f;

    public GameObject BoxinHand;
    public GameObject player;
    public Pickable objectInHand = null ;

    public void Awake(){
        if (instance == null){
            instance = this;
            init();
        }else{
            print("destroy");
            Destroy(gameObject);
        }
    }

    public void registerPickupObject(Pickable pickable){
        if(!(pickables.Contains(pickable))) pickables.Add(pickable);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(1)){
            if(!rightMouseDown){
                rightMouseDown = true;
               // print("down");
            }
            objectInHand = findClosest();
            if(objectInHand!=null) objectInHand.InHand = true;
        }else if(rightMouseDown){
            //print("up");
            rightMouseDown = false;
            if(objectInHand!=null) objectInHand.InHand=false;
                objectInHand=null;
        }
    }

    void init(){

    }

    Pickable findClosest(){
        Pickable closest = null;
        float min = float.MaxValue;
        foreach(Pickable item in pickables){
            float distance = Vector3.Distance(BoxinHand.transform.position, item.transform.position);
            if(item.InHand) return item;
            if(distance < min && distance < playerReach){
                min = distance;
                closest = item;
            } 
        
        }
        if(closest != null)print(closest.gameObject.name);
        else print("none");
        return closest;
    }
}
