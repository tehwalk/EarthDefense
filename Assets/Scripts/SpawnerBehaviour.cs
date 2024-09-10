using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Projectile[] projectileTypes;
    [SerializeField] float repeatRateMin;
    [SerializeField] float repeatRateMax;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectiles", 0.1f, Random.Range(repeatRateMin,repeatRateMax));
    }

    void SpawnProjectiles() 
    { 
        var inst = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        inst.GetComponent<ProjectileBehaviour>().projectileType = projectileTypes[Random.Range(0, projectileTypes.Length)];
    }
}
