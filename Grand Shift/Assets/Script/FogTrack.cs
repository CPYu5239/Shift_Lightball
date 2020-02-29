using UnityEngine;

public class FogTrack : MonoBehaviour
{
    Transform player;

    private void LateUpdate()
    {
        Track();
    }

    private void Track()
    {
        player = GameManager.player.transform;
        Vector3 pos = player.position;
        Vector3 posFog = transform.position;

        transform.position = new Vector3(pos.x + 175, posFog.y, posFog.z);
    }
}
