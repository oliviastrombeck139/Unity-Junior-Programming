using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;

        material.color = new Color(7.0f, 16.0f, 18.0f, 0.3f);
    }
    
    void Update()
    {
        transform.Rotate(60.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
