using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour {
    public GameObject pilota;
    private Vector3 vel = Vector3.zero;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        int forsa = 2;
        
        

        
        if (Input.GetKey(KeyCode.D)) {            
            //vel += new Vector3(1, 0, 0);
            pilota.transform.position += Vector3.right * Time.deltaTime * forsa;
        } 
        if (Input.GetKey(KeyCode.A)) {
            //vel += new Vector3(-1, 0, 0);
            pilota.transform.position += Vector3.left * Time.deltaTime * forsa;
        } 
        if (Input.GetKey(KeyCode.W)) {
           //vel += new Vector3(0, 1, 0);
            pilota.transform.position += Vector3.up * Time.deltaTime * 10;
        } 
        if (Input.GetKey(KeyCode.S)) {
            //vel += new Vector3(0, -1, 0);
            pilota.transform.position += Vector3.down * Time.deltaTime * forsa;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector3.up * 500);
        }
    }
}
