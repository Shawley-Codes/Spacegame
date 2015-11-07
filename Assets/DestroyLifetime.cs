using UnityEngine;
using System.Collections;

public class DestroyLifetime : MonoBehaviour {
  
    public float lifetime;

        void Start()
        {
        if (gameObject != null)
            {
               // Destroy(gameObject, lifetime); //causing prblects
            }
        }
}

