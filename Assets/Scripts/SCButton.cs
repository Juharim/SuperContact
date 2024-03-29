﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SCButton : MonoBehaviour
{
    Button cachedButton;
    Button CachedButton
    {
        get
        {
            if (cachedButton == null)
            {
                cachedButton = GetComponent<Button>();
            }
            return cachedButton;
        }
    }

    // 버튼에 타이틀 변경 함수
    public void SetTitle(string title)
    {
        GetComponentInChildren<Text>().text = title;
    }

    // 버튼의 OnClick 이벤트 변경 함수
    public void SetOnClickAction(UnityAction action)
    {
        CachedButton.onClick.AddListener(action);
    }

    public void SetInteractable(bool value)
    {
        cachedButton.interactable = value;
    }
}
