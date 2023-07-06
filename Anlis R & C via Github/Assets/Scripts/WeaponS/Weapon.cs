using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Weapon : MonoBehaviour
{

	[Header("Weapon Settings")]
    public Camera camera;
    public int damage;
    public float fireRate;
	public float hitRange;
	public bool isAutofire;
	private float nextFire;

    [Header("VFX")]
    public GameObject hitVFX;
   
    private void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

		if (nextFire > 0)
			nextFire -= Time.deltaTime;
        


        if (Input.GetMouseButton(0) && isAutofire && nextFire <= 0)
        {
			nextFire = 1 / fireRate;

			Fire();
        }

        if (Input.GetMouseButtonDown(0) && !isAutofire && nextFire <= 0)
        {
			nextFire = 1 / fireRate;

			Fire();
		}

       

    }

   

	void Fire()
	{
		Ray ray = new Ray(camera.transform.position, camera.transform.forward);

		RaycastHit hit;

		if (Physics.Raycast(ray.origin, ray.direction, out hit, hitRange))
		{
			PhotonNetwork.Instantiate(hitVFX.name, hit.point, Quaternion.identity);

			if (hit.transform.gameObject.GetComponent<Health>())
			{
				hit.transform.gameObject.GetComponent<PhotonView>().RPC("TakeDamage", RpcTarget.All, damage);
			}
		}
	}

   

}
