using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{

	public GameObject MainCamera;
	public GameObject WeaponCamera;

	public void IsLocalPlayer()
	{

		MainCamera.SetActive(true);
		WeaponCamera.SetActive(true);
	}
}
