using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
	private void Update()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	private void CreateLine()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}


	private void UpdateLine(Vector2 newFingerPos)
	{
	}

	public DrawLine()
	{
	}

	public GameObject linePrefab;


	public GameObject currentLine;

	public LineRenderer lineRenderer;

	public List<Vector2> fingerPositions;

	public Camera cam;


	public DetectShapes shapesDetector;
}
