using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class teleportback : MonoBehaviour
{
	public string level;

	private void OnTriggerEnter(Collider hit)
	{
		SceneManager.LoadScene(level);
	}
}
