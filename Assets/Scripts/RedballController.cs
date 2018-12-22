using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedballController : MonoBehaviour {
  float fallSpeed;
  float rotSpeed;

  void Start() {
    this.fallSpeed = 0.01f;
  }

  void Update() {
    transform.Translate(0, -fallSpeed, 0, Space.World);

    if (transform.position.y < -5.5f) {
      Destroy(gameObject);
    }
  }
}
