using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBehaviour : MonoBehaviour
{
    private static EarthBehaviour instance;
    public static EarthBehaviour Instance {  get { return instance; } }
    [SerializeField] float rotationSpeed = 10f;

    private void Awake()
    {
        if (instance != null && instance != this) instance = null;
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateEarth();
    }

    void RotateEarth() 
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
