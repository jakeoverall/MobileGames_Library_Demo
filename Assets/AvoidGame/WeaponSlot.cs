using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : MonoBehaviour
{

    public List<Transform> Slots;
    public GameObject Projectile;
    AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void Fire()
    {
        audioSrc.Play();
        Slots.ForEach(slot =>
       {
           Instantiate(Projectile,
               slot.transform.position,
               slot.transform.rotation
            );
       });
    }

}
