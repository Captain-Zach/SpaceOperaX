using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScrolling : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        mat = meshRenderer.materials[0];
        // Debug.Log(mat.mainTextureOffset);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mat offset: " + mat.mainTextureOffset);
    }
}
