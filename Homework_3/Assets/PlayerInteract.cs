using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 5f;
    public int collectedObjects = 0;
    public GameObject door;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)){
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray){
                if(collider.gameObject.tag == "Interactable"){
                    Debug.Log("Interacted with object");
                    Destroy(collider.gameObject);
                    collectedObjects += 1;
                    if(collectedObjects >= 5){
                        Destroy(door);
                    }
                }
            }
        }
        
    }
}
