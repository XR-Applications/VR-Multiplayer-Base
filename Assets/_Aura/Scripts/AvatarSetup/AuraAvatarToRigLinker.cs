using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Component links avatar transforms to XRRig transforms using lerp functions
/// </summary>
public class AuraAvatarToRigLinker : MonoBehaviour
{
    //Avatar Transforms
    public Transform mainAvatarTransform;
    public Transform avatarHead;
    public Transform avatarBody;
    public Transform avatarLeftHand;
    public Transform avatarRightHand;

    //XRRig Transforms
    public Transform XRHead;
    public Transform XRLeftHand;
    public Transform XRRightHand;

    //offsets
    public Vector3 headPositionOffset;
    public Vector3 handRotationOffset;
}
