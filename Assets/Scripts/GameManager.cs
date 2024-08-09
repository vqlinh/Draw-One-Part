using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private void Awake()
	{
		bool flag = GameManager.Instance;
		GameManager.Instance = this;
		Scene activeScene = SceneManager.GetActiveScene();
		throw new MissingMethodException();
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public IEnumerator GameCompleteMethod()
	{
		GameManager.<GameCompleteMethod>d__13 <GameCompleteMethod>d__;
		<GameCompleteMethod>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	public GameManager()
	{
	}

	public static GameManager Instance;

	public int levelNo;
	public TextMeshProUGUI levelText;
	public GameObject HitEffect;
	public GameObject FinalEffect;
	public GameObject tick;
	public GameObject NextLevel;
	public Animator ObjectAnim;
	public bool tutorial;
	public GameObject Hand;
}
