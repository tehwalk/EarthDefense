using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    EarthBehaviour earth;
    Rigidbody body;
    float speed;
    [HideInInspector] public Projectile projectileType;
    // Start is called before the first frame update
    void Start()
    {
        earth = EarthBehaviour.Instance;
        body = GetComponent<Rigidbody>();
        InstantiateProjectile();
    }

    void InstantiateProjectile() 
    { 
        speed = projectileType.p_Speed;
        var gfx = Instantiate(projectileType.p_GFX, body.transform);
        var particles = Instantiate(projectileType.p_Particles, body.transform);
        gfx.transform.SetParent(body.transform);
        particles.transform.SetParent(body.transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(earth.transform.position);
        body.position = Vector3.MoveTowards(body.position, earth.transform.position, speed*Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(earth.gameObject)) 
        {
            GameManager.Instance.LoseEarthHealth(projectileType.p_DamagePoints);
            Destroy(gameObject);
        }
    }
}
