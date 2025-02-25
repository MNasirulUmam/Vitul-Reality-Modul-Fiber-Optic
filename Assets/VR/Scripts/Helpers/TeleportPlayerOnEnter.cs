﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VR {
    public class TeleportPlayerOnEnter : MonoBehaviour {

        public Transform TeleportDestination;

        void OnTriggerEnter(Collider other) {
            if(other.GetComponent<CharacterController>()) {
                PlayerTeleport pt = other.transform.GetComponentInParent<PlayerTeleport>();
                if(pt && TeleportDestination) {
                    pt.TeleportPlayerToTransform(TeleportDestination);
                }
            }
        }
    }
}

