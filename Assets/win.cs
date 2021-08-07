using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{

    public Text winText;

    public List<GameObject> payloads = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.GetComponent<Player>()!=null){
            foreach (var item in payloads){
                item.SetActive(true);
            }
        }
    }

}
