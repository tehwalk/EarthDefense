using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingBehaviour : MonoBehaviour
{
    EarthBehaviour earth;
    [SerializeField] float rotationSpeed;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        earth = EarthBehaviour.Instance;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        OrbitAround();
    }

    void OrbitAround() 
    {
        transform.RotateAround(earth.gameObject.transform.position, Vector3.forward, rotationSpeed*Time.deltaTime);
    }

    private void OnMouseEnter()
    {
        //Debug.Log(gameObject.name);
        OnHoverEnter();
    }

    private void OnMouseExit()
    {
        OnHoverExit();
    }

    protected virtual void OnHoverEnter() 
    {
        Debug.Log("frick");
    }

    protected virtual void OnHoverExit() 
    {
        Debug.Log("frack");
    }
}
