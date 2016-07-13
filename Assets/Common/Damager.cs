using UnityEngine;
using System.Collections;

public class Damager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerStay(Collider other)
    {
        other.GetComponent<Health>().ChangeHealth(-1);
    }
}
