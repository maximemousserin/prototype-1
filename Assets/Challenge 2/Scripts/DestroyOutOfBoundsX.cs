﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Challenge2
{
    public class DestroyOutOfBoundsX : MonoBehaviour
    {
        private float leftLimit = -30;
        private float bottomLimit = -6;

        // Update is called once per frame
        void Update()
        {
            // Destroy dogs if x position less than left limit
            if (transform.position.x < leftLimit)
            {
                Destroy(gameObject);
            }
            // Destroy balls if y position is less than bottomLimit
            else if (transform.position.y < bottomLimit)
            {
                Destroy(gameObject);
            }
        }
    }

}