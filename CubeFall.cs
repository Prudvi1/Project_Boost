using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour {

    public float delay = 10f;
    public GameObject Cube;
	// Use this for initialization
	void Start () {
        //print("from start");
        InvokeRepeating("spawn",0.1f, repeatRate: 0.2f);
	}
	
	// Update is called once per frame
	void spawn () {
        //print("from spawn");
        Instantiate(Cube,new Vector3(5, 11, Random.Range(-30, -11)), Quaternion.identity);
        
	}
    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(collision.gameObject, 3.0f);
    
    }
}
