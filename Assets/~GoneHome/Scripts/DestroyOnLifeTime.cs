using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class DestroyOnLifeTime : MonoBehaviour
    {
        public float lifeTime = 5f;
        // Update is called once per frame
        void Update()
        {
            Destroy(gameObject, lifeTime);
        }
    }
}


