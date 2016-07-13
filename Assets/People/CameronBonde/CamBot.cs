using UnityEngine;
using System.Collections;

public class CamBot : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        GetComponent<Health>().OnDied.AddListener(Dead);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void Dead()
    {
        print("CAM DEAD");

        GetComponent<Health>().OnDied.RemoveListener(Dead);
    }
}
