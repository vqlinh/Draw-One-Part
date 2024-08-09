using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

public class DetectShapes : MonoBehaviour
{
	private void Start()
	{
		IEnumerator enumerator = this.pointsParent.GetEnumerator();
	}

	private void Update()
	{
		this.rayMethod();
	}

	private void rayMethod()
	{
		Camera main = Camera.main;
		Vector3 mousePosition = Input.mousePosition;
		if (typeof(Vector2).TypeHandle == null)
		{
		}
		Vector2 zero = Vector2.zero;
		if (typeof(Physics2D).TypeHandle == null)
		{
		}
		bool mouseButton = Input.GetMouseButton(0);
		PointsScript pointsScript;
		if (!pointsScript.isTouched)
		{
			long isTouched = 1L;
			pointsScript.isTouched = (isTouched != 0L);
			MonoBehaviour.print(pointsScript.name);
			int num = this.pointsAdded;
			this.pointsAdded = num;
			Animator component = pointsScript.GetComponent<Animator>();
			long enabled = 1L;
			component.enabled = (enabled != 0L);
		}
	}

	public void CheckPointMethod()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	public DetectShapes()
	{
		List<PointsScript> list = new List();
		this.points = list;
		base..ctor();
	}

	public int pointsAdded;

	public int pointsToCollect;

	public List<PointsScript> points;

	public Transform pointsParent;

	public LineRenderer LinePrefab;

	public int lineLength;

	public int totalLineLength;

	public GameObject hiddenPart;
}
