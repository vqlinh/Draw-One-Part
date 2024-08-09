using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class direction : MonoBehaviour
{
	private void Awake()
	{
		bool flag = direction.instance;
		direction.instance = this;
	}

	private void Start()
	{
		Scene activeScene = SceneManager.GetActiveScene();
		throw new MissingMethodException();
	}

	public void next(int nextl)
	{
		int num = this.level;
	}

	private void Update()
	{
		if (this.alive)
		{
			if (this.start)
			{
				bool mouseButton = Input.GetMouseButton(0);
				Vector3 mousePosition = Input.mousePosition;
				Vector3 mousePosition2 = Input.mousePosition;
			}
			bool mouseButton2 = Input.GetMouseButton(0);
			this.superwhile();
			bool mouseButtonUp = Input.GetMouseButtonUp(0);
			string text = this.dir;
			long num = 1L;
			this.start = (num != 0L);
			this.stringmatch(text);
		}
	}

	public void live()
	{
		long num = 1L;
		this.alive = (num != 0L);
	}

	public void restart()
	{
		Scene activeScene = SceneManager.GetActiveScene();
		throw new MissingMethodException();
	}

	public void stringmatch(string dir)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	public void superwhile()
	{
		Vector3 mousePosition = Input.mousePosition;
		Vector3 mousePosition2 = Input.mousePosition;
	}

	public void restore(float x, float y)
	{
	}

	public void Notedir(int a)
	{
		string text = this.dir + "1 ";
		this.dir = text;
	}

	public void detection(string f)
	{
		Text text = this.pos;
		string text2 = this.final;
		string text3 = this.final;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
	}

	public direction()
	{
		long num = 1L;
		this.start = (num != 0L);
		this.max = 100;
		this.dir = "";
		this.final = "";
		base..ctor();
	}

	public static direction instance;

	public string dir;

	private float x;

	private float y;

	private int dirr;

	private int dire;

	private int level;

	public Text pos;

	public Text p;

	public bool start;

	public bool alive;

	public string shapename;

	private float rx;

	private float ry;

	private float xaxis;

	private float yaxis;

	private int dis;

	private int max;

	private string final;

	private string s;

	private List<string> shapes;

	private List<string> s2;

	public int scen;

	public int nextl;

	public string revShape;
}
