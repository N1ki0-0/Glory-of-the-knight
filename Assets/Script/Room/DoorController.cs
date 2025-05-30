using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public GameObject fireEffectPrefab;
    public Transform firePointLeft;
    public Transform firePointRight;

    private bool hasSpawnedFire = false;

    void Update()
    {
        // Проверка: если дверь уничтожена и огонь ещё не заспаунен
        if (door == null && !hasSpawnedFire)
        {
            SpawnFire();
            hasSpawnedFire = true;
        }
    }

    void SpawnFire()
    {
        Instantiate(fireEffectPrefab, firePointLeft.position, Quaternion.identity);
        Instantiate(fireEffectPrefab, firePointRight.position, Quaternion.identity);
    }
}
