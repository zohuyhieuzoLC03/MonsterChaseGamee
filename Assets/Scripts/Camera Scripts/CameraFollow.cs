using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTarget;

    private Vector3 tempPos;

    [SerializeField] private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        playerTarget = GameObject.FindWithTag(TagManager.PLAYER_TAG).transform;
        // Invoke("LOAD",2f);
    }

    void LOAD()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(TagManager.MAIN_MENU_SCENE_NAME);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (!playerTarget) return;
        tempPos = transform.position;
        tempPos.x = playerTarget.position.x;
        if (tempPos.x < minX)
            tempPos.x = minX;
        if (tempPos.x > maxX)
            tempPos.x = maxX;

        transform.position = tempPos;
    }
}
