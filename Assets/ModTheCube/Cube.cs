using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int xyz;
    private float speed;
    private float r,g,b;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 2.5f;
        
        Material material = Renderer.material;
        
        r = 0.5f;
        g = 1.0f;
        b = 0.3f;
        material.color = new Color(r, g, b, 0.4f);

        xyz = Random.Range(0, 3);
        speed = Random.Range(50.0f, 100.0f);
    }
    
    void Update()
    {
        float x= 0.0f, y = 0.0f ,z = 0.0f;
        switch (xyz)
        {
            case 0 :
                x = speed * Time.deltaTime;
                break;
            case 1 :
                y = speed * Time.deltaTime;
                break;
            case 2 :
                z = speed * Time.deltaTime;;
                break;
        }
        transform.Rotate(x, y, z);

        r += 0.1f;
        if ( r > 1.0f) r = 0.0f;
        g += 0.1f;
        if ( g > 1.0f) g = 0.0f;
        b += 0.1f;
        if ( b > 1.0f) b = 0.0f;
        Renderer.material.color = new Color(r,g,b, 0.4f);
    }
}
