using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPro : MonoBehaviour
{
    public float Speed = 10000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.forward, Time.deltaTime * this.Speed);
    }
}
