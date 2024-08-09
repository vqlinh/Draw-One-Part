using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
	private void Start()
	{
		long defaultValue = 1L;
		int @int = PlayerPrefs.GetInt("LevelNo", (int)defaultValue);
		this.levelNo = @int;
		IEnumerator routine = this.StartGame();
		Coroutine coroutine = base.StartCoroutine(routine);
	}

	private IEnumerator StartGame()
	{
		LevelLoader.<StartGame>d__2 <StartGame>d__;
		<StartGame>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	private void Update()
	{
	}

	public LevelLoader()
	{
	}
	public int levelNo;
}
