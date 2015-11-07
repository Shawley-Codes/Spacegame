using UnityEngine;
using System.Collections;

public class DestroyLifetime : MonoBehaviour {
  
    public float lifetime;

        void Start()
        {
            Destroy(gameObject, lifetime);
        }
}

