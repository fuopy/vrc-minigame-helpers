
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace Fuopy
{
    public class DoorgateSource : UdonSharpBehaviour
    {
        public GameObject destination;

        public override void OnPlayerTriggerEnter(VRCPlayerApi player)
        {
            if (player == Networking.LocalPlayer)
            {
                Networking.LocalPlayer.TeleportTo(destination.transform.position, Networking.LocalPlayer.GetRotation());
            }
        }
    }
}
