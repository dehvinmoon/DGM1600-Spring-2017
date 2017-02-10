using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Operators : MonoBehaviour {
	public int one =1;
	public int two =2;

//Use for Intalizing
void Start() {

}
//Update is called once per frame
void Update () {

//Addition: Adds and leaves the sum.
Debug. Log(one + two);

//Modulus: Leaves the remainder of the two varriables.
Debug.Log(one % two);

//Subtraction: Subtracts and leaves the sum.
Debug.Log(one - two);

//Division: Divides and leaves the sum.
Debug.Log(one / two);

//Multiplication: Multiplies and leaves the sum.
Debug.Log(one * two);

//Increment: Each + sign is an increment one added upon the number chosen.
Debug.Log(one + + two);

//Decrement: Each - sign is an increment one substracted upon the number chosen.
Debug.Log(one - - two);



}

