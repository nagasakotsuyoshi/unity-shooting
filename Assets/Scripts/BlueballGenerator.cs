using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueballGenerator : MonoBehaviour {

  public GameObject blueballPrefab;

  void Start() {
    InvokeRepeating("GenBlueball", 5, 5);
  }

  void GenBlueball() {
    Instantiate(blueballPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
  }
}
