﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player1, player2;
    private float distBetweenPlayers, orthoSize;

    private void LateUpdate()
    {
        distBetweenPlayers = (Mathf.Abs(Vector3.Distance(player1.position, player2.position)));

        orthoSize = distBetweenPlayers / 1.5f;

        if (orthoSize < 5f)
            orthoSize = 5f;

        Camera.main.orthographicSize = orthoSize;
    }
}
