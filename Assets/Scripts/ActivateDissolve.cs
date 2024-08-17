using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDissolve : MonoBehaviour
{
    [SerializeField] Material dissolveMaterial;
    [SerializeField] float dissolveSpeed;
    [SerializeField] float dissolveThreshold;

    void Dissovle()
    {
        dissolveThreshold += Time.deltaTime * dissolveSpeed * 0.1f;
        dissolveMaterial.SetFloat("_DissolveThreshold", dissolveThreshold);

        if (dissolveThreshold >= 1)
        {
            dissolveThreshold = 0;
        }
    }

    private void Update()
    {
        Dissovle();
    }
}
