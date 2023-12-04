using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visualistaion : MonoBehaviour
{
	public Transform In;
	public Transform Out;
	public Transform Test;

	private Perceptron perceptron;

	// Start is called before the first frame update
	void Start()
	{
		perceptron = GetComponent<Perceptron>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnClick(int idx)
	{
		if (idx < 10)
		{
			var invertedValue = 1 - perceptron.ts[idx / 2].input[idx % 2];
			perceptron.ts[idx / 2].input[idx % 2] = invertedValue;
			In.GetChild(idx).GetComponent<Image>().color = GetRightColor(invertedValue);
		}
		else
		{
			idx -= 10;
			var invertedValue = 1 - perceptron.ts[idx].output;
			perceptron.ts[idx].output = invertedValue;
			Out.GetChild(idx).GetComponent<Image>().color = GetRightColor(invertedValue);
		}

		perceptron.Reset();
		perceptron.TrainNow();
		var output = perceptron.GetCalcOutput();

		for (int i = 0; i < 4; i++)
			Test.GetChild(i).GetComponent<Image>().color = GetRightColor(output[i]);
	}

	private Color GetRightColor(double num) => num == 1 ? Color.black : Color.white;
}
