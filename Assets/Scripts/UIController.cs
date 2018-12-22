using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

  public int score = 0;
  public int life = 1;
  GameObject scoreObj;
  GameObject lifeObj;
  GameObject gameOverText;

  public void GameOver(){
    this.gameOverText.GetComponent<Text>().text = "GameOver";
  }
  
  public void AddScore(int num) {
    if (this.score + num < 0)
      this.score = 0;
    else
      this.score += num;
  }

  public void AddLife(int num) {
    if (this.life + num < 0)
      this.life = 0;
    else
      this.life += num;
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
