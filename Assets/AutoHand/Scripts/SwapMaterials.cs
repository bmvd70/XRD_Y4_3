using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMaterials : MonoBehaviour
{
    public Material SwappingMaterial;

    private Material _defaultMaterial;
    private Renderer _renderer;
    private bool _isDefaultMat = true;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _defaultMaterial = _renderer.material;
    }

    public void Swap()
    {
        if (_isDefaultMat) SetMaterial(SwappingMaterial);
        else SetMaterial(_defaultMaterial);
    }

    public void SetMaterial(Material mat)
    {
        _renderer.material = mat;
        _isDefaultMat = !_isDefaultMat;
    }
}
