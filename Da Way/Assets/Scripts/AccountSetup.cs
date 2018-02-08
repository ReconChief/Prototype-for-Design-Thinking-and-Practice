using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountSetup : MonoBehaviour
{
	public string savingsBalance;
	public string checkingBalance;

	public InputField savingsB;
	public InputField checkingsB;

	void Start ()
	{
		
	}

	void Update ()
	{
		savingsBalance = savingsB.text;
		checkingBalance = checkingsB.text;
	}

	public void accountUpdate()
	{
		
	}
}
