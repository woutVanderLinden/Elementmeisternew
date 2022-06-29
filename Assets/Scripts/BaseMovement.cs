using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour, Movement
{

    public string animationName;
    public float momentumGain;
    public GameObject particleEmitters;
    public GameObject attackCollider;
    public void PerformMovement()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
