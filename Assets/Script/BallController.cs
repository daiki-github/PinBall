using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	//スコアを表示するテキスト（追加）
	private GameObject scoreText;
	//得点（追加）
	private int score = 0;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");

		//シーン中のscoreTextオブジェクトを取得（追加）
		this.scoreText = GameObject.Find("ScoreText");
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}

	void OnTriggerEnter(Collider other) {
		//コインに衝突した場合
		if (other.gameObject.tag =="SmallCloudTag" || other.gameObject.tag =="LargeStarTag") {

			// スコアを加算(追加)
			this.score += 10;

			//ScoreText獲得した点数を表示(追加)
			this.scoreText.GetComponent<Text> ().text = "Score " + this.score + "pt";
		}

		//コインに衝突した場合
		if (other.gameObject.tag =="LargeCloudTag") {

			// スコアを加算(追加)
			this.score += 20;

			//ScoreText獲得した点数を表示(追加)
			this.scoreText.GetComponent<Text> ().text = "Score " + this.score + "pt";
		}

	}
}









