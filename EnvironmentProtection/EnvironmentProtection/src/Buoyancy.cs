using UnityEngine;
using System.Collections;

public class Buoyancy : MonoBehaviour {
    public float UpwardForce = 5f;
    private bool isInWater = false;
    
    void OnTriggerEnter2D(Collider2D Other){
        if (Other.tag == "Water") {
            isInWater = true;
            GetComponent<Rigidbody2D>().drag = 5f;
            GetComponent<Rigidbody2D>().angularDrag = 5f;
        }
    }
 
    void OnTriggerExit2D(Collider2D Other){
        if (Other.tag == "Water"){
            isInWater = false;
            GetComponent<Rigidbody2D>().drag = 0.5f;
            GetComponent<Rigidbody2D>().angularDrag = 0.5f;
        }
    }
 
    void FixedUpdate(){
        if (isInWater){
            Vector2 force = Vector2.up * UpwardForce;
            this.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Force);
            Debug.Log(isInWater);
        }
    }
}