using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
    public class AbrirVentana : PickableItem
    {
        /// <summary>
        /// Triggered when something collides with the coin
        /// </summary>
        /// <param name="collider"></param>
        protected override void Pick(GameObject picker)
        {
            MMEventManager.TriggerEvent(new MMGameEvent("AbrirVentanaEvent"));
        }
    }
}

