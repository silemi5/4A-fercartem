using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    private int Min = 0;
    private int Max = 512;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Welcome to 'You think number, we guess!'");
        Debug.Log(System.String.Format("Think of a number between {0} and {1}!", this.Min, this.Max));
        GuessNumber();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.Max = GetMiddleRange() - 1;
            GuessNumber();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.Min = GetMiddleRange() + 1;
            GuessNumber();
        }
    }

	void GuessNumber()
	{
		//The number to guess is either Max or Min
		if(this.Max - this.Min == 1)
		{
			Debug.Log(System.String.Format("I guess my computer mind that you though of {0} or {1}!", this.Min, this.Max));
		}
		//The number to guess is Min, Max, or the number between them
		else if(this.Max - this.Min == 2)
		{
			Debug.Log(System.String.Format("I guess my computer mind that you though of {0}, {1}, or {2}!", this.Min, GetMiddleRange(), this.Max));
		}
		//Accurate results
		else if(this.Max == this.Min)
		{
			Debug.Log(System.String.Format("I guess my computer mind that you though of {0}!", GetMiddleRange()));
		}
		//Narrow down the search
		else
		{
			Debug.Log(System.String.Format("Is your number higher or lower than {0}? [Use up or down key]", GetMiddleRange()));
		}
	}

	//Gets the number between Min and Max
    int GetMiddleRange()
    {
		return (int)((this.Min + this.Max) / 2);
    }
}
