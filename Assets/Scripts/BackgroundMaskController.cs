using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMaskController : MonoBehaviour {
    [SerializeField] Transform Player1;
    [SerializeField] Transform Player2;
    [SerializeField] Transform BackgroundMask;

    private void Update() {
        BackgroundMask.position = new Vector2((Player1.position.x + Player2.position.x) / 2, (Player1.position.y + Player2.position.y) / 2);
        float xDelta = Player2.position.x - Player1.position.x;
        float yDelta = Player2.position.y - Player1.position.y;
        float maskAngle = Mathf.Atan2(yDelta, xDelta) * Mathf.Rad2Deg;
        BackgroundMask.rotation = Quaternion.Euler(0, 0, maskAngle);
    }
}
