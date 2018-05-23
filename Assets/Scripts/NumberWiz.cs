using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWiz : MonoBehaviour {

	int max = 1000;
	int min = 1;

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wiz.");
		print("Think of a number in your head, but don't tell me what it is.");

		print("The highest number you can pick is " + max + ".");
		print("The lowest number you can pick is " + min + ".");

		print("Is the number higher or lower than 500?");

		print("Up arrow for higher.");
		print("Down arrow for lower.");
		print("Enter for equals.");	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
		{
			print("Up was pressed.");
		}
		if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
		{
			print("Down was pressed.");
		}
		if (Input.GetKeyUp(KeyCode.Return))
		{
			print("Enter was pressed.");
		}
	}
}
