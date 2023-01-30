using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshActivation : MonoBehaviour
{
    MeshCollider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBecameVisible()
    {
        myCollider.enabled = true;
        Debug.Log("EEEE");
    }

    public void OnBecameInvisible()
    {
        Debug.Log("GGGG");
        myCollider.enabled = false;
    }
}
