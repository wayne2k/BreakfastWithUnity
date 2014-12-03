using UnityEngine;
using System.Collections;

public class CrossFadeExampleCS : MonoBehaviour
{
	public Camera camera1;
	public Camera camera2;
	public float fadeTime = 2.0f;
	private bool inProgress = false;
	private bool swap = false;
	
	void Update ()
	{
		if(Input.GetKeyDown("space"))
		{
			Debug.Log("Hey!");
			DoFade();
		}
	}
	
	void DoFade ()
	{
		if(inProgress)
		{
			return;
		}
		inProgress = true;
		
		swap = !swap;

		StartCoroutine(ScreenWipe.use.CrossFade (swap? camera1 : camera2, swap? camera2 : camera1, fadeTime));
		
		inProgress = false;
	}
}
