using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

  int score = 0;
  int life = 1;
  GameObject scoreObj;
  GameObject lifeObj;
  GameObject gameOverText;

  public void GameOver(){
    this.gameOverText.GetComponent<Text>().text = "GameOver";
  }
  
  public void AddScore(int num) {
    this.score += num;
  }

  void Start() {
    this.scoreObj = GameObject.Find("Score");
    this.lifeObj = GameObject.Find("Life");
    this.gameOverText = GameObject.Find ("GameOver");
  }

  void Update() {
    scoreObj.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    lifeObj.GetComponent<Text>().text = "Life:" + life.ToString("D4");
  }
}
