using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;

    public VFXManager vfxManager;

    public Collider bola;
    
    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            vfxManager.PlayVFX(collision.transform.position);
        }
    }
}
