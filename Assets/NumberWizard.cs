using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 5;

	public Text guessText;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
	    max = 1000;
	    min = 1;
	    guess = Random.Range(min, max + 1);
	    guessText.text = guess.ToString();
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	void NextGuess () {
		guess = Random.Range(min, max + 1);
		guessText.text = guess.ToString();
		maxGuessesAllowed--;
		if(maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		} 
	}
}
