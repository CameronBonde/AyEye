using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public List<GameObject> characters;
    public int distance;
    public int numberOfEach;

    // Use this for initialization
	void Start ()
    {
	    for (int i = 0; i < numberOfEach; i++)
	    {
	        foreach (GameObject character in characters)
	        {
	            Instantiate(character, new Vector3(Random.Range(-distance, distance), 0, Random.Range(-distance, distance)),
	                Quaternion.identity);
	        }
	    }
    }
}
