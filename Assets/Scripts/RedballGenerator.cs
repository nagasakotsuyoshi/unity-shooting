using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedballGenerator : MonoBehaviour {

  public GameObject redballPrefab;

 	void Start() {
    InvokeRepeating("GenRedball", 3, 3);		
	 }
	
	 void GenRedball() {
    Instantiate(redballPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0),Quaternion.identity);
 	}
}
