using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

  public GameObject bulletPrefab;
  public GameObject explosionPrefab;

  void Update() {
    if (Input.GetKey(KeyCode.LeftArrow)) {
      transform.Translate(-0.1f, 0, 0);
		}
    if (Input.GetKey(KeyCode.RightArrow)) {
      transform.Translate( 0.1f, 0, 0);
    }
    if (Input.GetKeyDown (KeyCode.Space)) {
      Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
  }

  void OnCollisionEnter2D(Collision2D coll)
  {
    Debug.Log(coll.gameObject.name);

    if (coll.gameObject.name.Contains("bulletPrefab")) {
      return;
    }
    if (coll.gameObject.name.Contains("RockPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddLife(-1);

      if (GameObject.Find("Canvas").GetComponent<UIController>().life ==0) {
        //ロケット爆発
        Destroy(gameObject);
        RocketExplosion();
        GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
      }
    }
    else if (coll.gameObject.name.Contains("RedballPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddScore(100);
    }
    else if (coll.gameObject.name.Contains("BlueballPrefab")) {
      GameObject.Find("Canvas").GetComponent<UIController>().AddLife(1);
    }
    // 衝突したオブジェクトを削除する
    Destroy(coll.gameObject);
  }

  void RocketExplosion() {
    Instantiate(explosionPrefab, transform.position, Quaternion.identity);
  }
}

