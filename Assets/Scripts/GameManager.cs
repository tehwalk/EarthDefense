using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance {  get { return instance; } }
    [Header("Earth Properties - General & UI")]
    [SerializeField] int earthHealthPointsMax;
    [SerializeField] Slider earthHealthBar;
    int earthHealthPoints = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null && instance != this) instance = null;
        instance=this;
    }
    void Start()
    {
        InitializeEarth();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeEarth() 
    { 
        earthHealthPoints = earthHealthPointsMax;
        earthHealthBar.minValue = 0;
        earthHealthBar.maxValue = earthHealthPointsMax;
        earthHealthBar.value = earthHealthPoints;
    }

    public void LoseEarthHealth(int dmg) 
    {
        earthHealthPoints -= dmg;
        earthHealthBar.value = earthHealthPoints;
        if (earthHealthPoints <= 0) 
        {
            Debug.Log("fuck");
        }
    }
}
