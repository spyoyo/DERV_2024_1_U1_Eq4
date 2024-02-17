using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{
    public Renderer rend;

    public Material color2;

    public Material color3;

    [SerializeField]
    Material color4;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            rend.material = color2;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            rend.material = color3;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            rend.material = color4;
        }
    }
}
