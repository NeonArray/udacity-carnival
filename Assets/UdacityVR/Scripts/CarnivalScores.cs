﻿using System;
using UnityEngine;
using TMPro;

public class CarnivalScores : MonoBehaviour {

	public float gameTimer = 0.0f;

	public GameObject gameOverUI;
	public TextMeshPro timerText;

	[SerializeField]
	private int TeddyBearPointsMin = 2000;

	[SerializeField]
	private GameObject TeddyBear;

	[SerializeField]
	private TextMeshPro plinkoScore;
	[SerializeField]
	private TextMeshPro wheelScore;
	[SerializeField]
	private TextMeshPro coinScore;

	public static CarnivalScores Instance;

	private int plinkoPoints;
	private int wheelPoints;
	private int coinPoints;

	void Awake() {
		if (Instance == null)
			Instance = this;

		gameOverUI.SetActive(false);
		TeddyBear.SetActive(false);
	}

	void OnDestroy() {
		if (Instance = this)
			Instance = null;
	}

	// Update is called once per frame
	void Update () {
		plinkoScore.text = "Plinko: " + plinkoPoints.ToString("0000");
		wheelScore.text = "Wheel: " + wheelPoints.ToString("0000");
		coinScore.text = "Coins: " + coinPoints.ToString("0000");
		timerText.text = gameTimer.ToString("F0");

		if (plinkoPoints + wheelPoints + coinPoints >= TeddyBearPointsMin) {
			TeddyBear.SetActive(true);
		}

		if (gameTimer > 0) {
			gameTimer -= Time.deltaTime;

			if (gameTimer < 0) {
				gameOverUI.SetActive(true);
			}
		}
	}

	public void IncrementPlinkoScore(float points) {
		plinkoPoints += (int) points;
	}

	public void IncrementWheelScore(float points) {
		wheelPoints += (int) points;
	}

	public void IncrementCoinScore() {
		coinPoints += 1000;
	}
}
