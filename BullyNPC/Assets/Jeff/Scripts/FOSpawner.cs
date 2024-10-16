using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOSpawner : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
           
        }
    }
}
