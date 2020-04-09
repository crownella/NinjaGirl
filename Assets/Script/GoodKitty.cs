﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodKitty : MonoBehaviour
{
    public Text KittyText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) KittyText.text = "Yay!";
    }
}
