﻿using UnityEngine;
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
			StartCoroutine(DoFade());
		}
	}
	
	IEnumerator DoFade ()
	{
		if(inProgress)
		{
			yield break;
		}
		inProgress = true;
		
		swap = !swap;

		yield return StartCoroutine(ScreenWipe.use.CrossFadeToNewScene (Camera.main, "GridSpawner", fadeTime));
		
		inProgress = false;
	}
}
