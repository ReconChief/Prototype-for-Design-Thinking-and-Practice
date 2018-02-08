using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupBalances : MonoBehaviour
{

	public int savingsBalance= 50000;
	public double checkingsBalance= 0.08;

	public Text sB;
	public Text cB;

	void Start ()
	{
		
	}
	

	void Update ()
	{
		sB.text = "Savings Balance: " + savingsBalance.ToString();

		cB.text = "Checkings Balance: " + checkingsBalance.ToString("F");
	}
}
