﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CryptoBike
{    
    public class DestroyInteractable : InteractableBase
    {

        public override void OnInteract()
        {
            base.OnInteract();

            Destroy(gameObject);
        }
    }
}
