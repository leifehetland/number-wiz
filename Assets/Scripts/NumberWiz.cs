using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWiz : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
		{
			// print("Up was pressed.");
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
		{
			// print("Down was pressed.");
			max = guess;
			NextGuess();
			
		}
		else if (Input.GetKeyUp(KeyCode.Return))
		{
			print("I guessed it!");
			StartGame();
		}
	}

	void StartGame() {

		max = 1000;
		min = 1;
		guess = 500;
		
		print("======================");
		print("Welcome to Number Wiz.");
		print("Think of a number in your head, but don't tell me what it is.");

		print("The highest number you can pick is " + max + ".");
		print("The lowest number you can pick is " + min + ".");

		print("Is the number higher or lower than " + guess + "?");

		print("Press up arrow for higher, down arrow for lower, and enter for equals.");
		max = max + 1;		
  }

	void NextGuess() {
		guess = (max + min) / 2;
		print("Is the number higher or lower than " + guess + "?");
	}
}
