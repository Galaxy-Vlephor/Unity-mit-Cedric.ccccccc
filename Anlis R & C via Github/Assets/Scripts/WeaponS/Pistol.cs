using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Pistol : MonoBehaviour
{
    public Camera camera;
    public int damage;
    public float fireRate;

    [Header("VFX")]
    public GameObject hitVFX;
    public ParticleSystem muzzleFlash;
    public GameObject muzzleFlashGO;
    public AudioSource ShootingSound;

    private bool hasShot; // Flag to track if the shooting event has occurred

    public Animator animator; // Reference to the Animator component
    public AnimationClip shootAnimationClip; // Reference to the shoot animation clip

    private void Start()
    {
        muzzleFlashGO.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasShot)
        {
            ShootingSound.Play();
            StartCoroutine(PlayShootAnimation());
        }

       
    }

    private IEnumerator PlayShootAnimation()
    {

        muzzleFlashGO.SetActive(true);
        hasShot = true;

        // Play the muzzle flash effect
        if (muzzleFlash != null)
        {
            muzzleFlash.Play();
        }

        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray.origin, ray.direction, out hit, 100f))
        {
            PhotonNetwork.Instantiate(hitVFX.name, hit.point, Quaternion.identity);

            if (hit.transform.gameObject.GetComponent<Health>())
            {
                hit.transform.gameObject.GetComponent<PhotonView>().RPC("TakeDamage", RpcTarget.All, damage);
            }
        }

        // Set the "Shoot" bool parameter in the Animator to true
        

        // Play the shoot animation
        animator.Play(shootAnimationClip.name);

        // Wait until the animation finishes playing
        yield return new WaitForSeconds(shootAnimationClip.length);

        // Set the "Shoot" bool parameter in the Animator to false
       

        // Resume normal gameplay, e.g., allow the player to shoot again
        hasShot = false;
        muzzleFlashGO.SetActive(false);
    }

  
}
