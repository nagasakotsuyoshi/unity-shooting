using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour {
// 爆発し終わったクローンを消す
void Start() {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject,exp.duration);
	}
}
