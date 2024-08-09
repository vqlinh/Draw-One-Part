using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

public class takeScreenShot : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		int width = Screen.width;
		int height = Screen.height;
		string text;
		this.resolution = text;
		object[] args = new object[6];
		string productName = Application.productName;
		if ((productName == null || productName != null) && ("_ScreenShot-" == null || "_ScreenShot-" != null))
		{
			string text2 = this.resolution;
			if ((text2 == null || text2 != null) && ("-" == null || "-" != null))
			{
				long defaultValue = 0L;
				int @int = PlayerPrefs.GetInt("number", (int)defaultValue);
				if ((typeof(int).TypeHandle == null || typeof(int).TypeHandle != null) && (".png" == null || ".png" != null))
				{
					string filename = string.Concat(args);
					long superSize = 1L;
					ScreenCapture.CaptureScreenshot(filename, (int)superSize);
					long num = 0L;
					int int2 = PlayerPrefs.GetInt("number", (int)num);
					PlayerPrefs.SetInt("number", (int)num);
					int width2 = Screen.width;
					int height2 = Screen.height;
					string text3;
					this.resolution = text3;
					string productName2 = Application.productName;
					if (productName2 == null || productName2 != null)
					{
						if ("X" == null)
						{
							throw new IndexOutOfRangeException();
						}
						if ("_HIGH_ScreenShot-" == null || "_HIGH_ScreenShot-" != null)
						{
							string text4 = this.resolution;
							if ((text4 == null || text4 != null) && ("-" == null || "-" != null))
							{
								long defaultValue2 = 0L;
								int int3 = PlayerPrefs.GetInt("number", (int)defaultValue2);
								if ((typeof(int).TypeHandle == null || typeof(int).TypeHandle != null) && (".png" == null || ".png" != null))
								{
									int superSize2 = 5;
									string filename2;
									ScreenCapture.CaptureScreenshot(filename2, superSize2);
									long num2 = 0L;
									int int4 = PlayerPrefs.GetInt("number", (int)num2);
									PlayerPrefs.SetInt("number", (int)num2);
									return;
								}
							}
						}
					}
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	public takeScreenShot()
	{
	}

	public KeyCode key = KeyCode.G;

	private string resolution;
}
