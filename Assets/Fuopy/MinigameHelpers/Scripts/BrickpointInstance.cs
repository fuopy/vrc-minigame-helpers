
using UdonSharp;
using VRC.SDKBase;
using VRC;

// Brickpoint: When a player clicks on a particular brick, their spawnpoint
// changes to be at the brick's position!

namespace Fuopy
{
    public class BrickpointInstance : UdonSharpBehaviour
    {
        public BrickpointContainer brickpointContainer;

        public override void Interact()
        {
            if (brickpointContainer.activeBrickpoint == this)
            {
                brickpointContainer.activeBrickpoint = null;
            }
            else
            {
                brickpointContainer.activeBrickpoint = this;
            }
        }

        public override void OnPlayerRespawn(VRCPlayerApi player)
        {
            if (brickpointContainer.activeBrickpoint == this)
            {
                player.TeleportTo(transform.position, player.GetRotation());
            }
        }
    }
}
