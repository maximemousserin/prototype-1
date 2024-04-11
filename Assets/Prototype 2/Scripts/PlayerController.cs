using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float Speed = 20f;
    public float RangeX = 20f;

    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }

        HorizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(transform.position.x) > RangeX)
        {
            transform.position = new Vector3(RangeX * Mathf.Sign(transform.position.x), transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * Speed);
    }
}
