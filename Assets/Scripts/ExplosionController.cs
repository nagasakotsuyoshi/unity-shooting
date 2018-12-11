﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour {
// 爆発し終わったクローンを消す
  void Start() {
    var exp = GetComponent<ParticleSystem>();
    exp.Play();
    Destroy(gameObject,exp.main.duration);
  }
}
