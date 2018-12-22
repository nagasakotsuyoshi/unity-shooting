using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

  public GameObject explosionPrefab;
	
  void Update() {
    transform.Translate(0, 0.2f, 0);

    if (transform.position.y > 5) {
      Destroy(gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D coll) {
    if (coll.gameObject.name.Contains("bulletPrefab")) {
      return;
    }
    
    if (coll.gameObject.name.Contains("RockPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddScore(10);
    } else if (coll.gameObject.name.Contains("RedballPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddScore(-100);
    } else if (coll.gameObject.name.Contains("BlueballPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddLife(1);
    }
    // 爆発エフェクトを生成する
    Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    // 衝突したオブジェクトを削除する
    Destroy(coll.gameObject);
      Destroy(gameObject);
  }
}
