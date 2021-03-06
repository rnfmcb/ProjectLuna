﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_healthbar : MonoBehaviour
{

    public enemy_stats_base _enemyStats;
    public float _rectMaxWidth = 600;
    public RectTransform _rectData;

    // Use this for initialization
    void Start()
    {
        _enemyStats = gameObject.GetComponent<UI_follow>()._parentObject.GetComponent<enemy_stats_base>();
        _rectData = gameObject.transform.GetChild(1).GetChild(1).gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float barLength = _rectMaxWidth * (1 - (_enemyStats.health / _enemyStats.maxHealth));

        _rectData.offsetMax = new Vector2(-barLength, -23);
        _rectData.offsetMin = new Vector2(0, -50);
    }
}
