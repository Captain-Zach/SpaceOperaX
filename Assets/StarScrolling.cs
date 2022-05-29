using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScrolling : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.GetTextureOffset(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
