using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MaterialController_Ver01 : MonoBehaviour
{
    private Renderer renderCar;
    public Material[] materials;
    private int matIndex;

    // Start is called before the first frame update
    void Start()
    {
        //Get Render Componet
        renderCar = GetComponent<Renderer>();
        renderCar.enabled = true;  
        matIndex = Random.Range(0, materials.Length);
        renderCar.sharedMaterial = materials[matIndex];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
