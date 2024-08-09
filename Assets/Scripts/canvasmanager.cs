using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasmanager : MonoBehaviour
{
	private void Awake()
	{
		bool flag = canvasmanager.Instance;
		canvasmanager.Instance = this;
		Scene activeScene = SceneManager.GetActiveScene();
		this.levelNo = activeScene;
	}
	private void Update()
	{
	}

	public void NextLevel()
	{
		AdManager.instance.showInterstitial();
		int num = this.levelNo;
		PlayerPrefs.Save();
		SceneManager.LoadScene(this.levelNo);
	}

	public void Onrewardvideo()
	{
		AdManager instance = AdManager.instance;
		long hint = 1L;
		instance.Hint = (hint != 0L);
		AdManager.instance.showRewardVideo();
	}

	public void skipMethod()
	{
		do
		{
			Transform pointsParent = this.PointsParent;
			long index = 0L;
			int childCount = pointsParent.childCount;
			SpriteRenderer component = this.PointsParent.GetChild((int)index).GetComponent<SpriteRenderer>();
			long enabled = 1L;
			component.enabled = (enabled != 0L);
		}
		while (this.PointsParent != null);
		throw new NullReferenceException();
	}


	public canvasmanager()
	{
	}

	public static canvasmanager Instance;

	private int levelNo;

	public Transform PointsParent;
}
