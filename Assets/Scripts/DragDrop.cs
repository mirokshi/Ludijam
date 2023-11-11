using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    public TypeItem typeItem;
    [SerializeField] private Canvas _canvas;
    private RectTransform _rectTransform;
    private CanvasGroup _canvasGroup;
    
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Transform originParent;
    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
        originParent = transform.parent;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _canvasGroup.alpha =.6f;
        _canvasGroup.blocksRaycasts = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _canvasGroup.alpha =1f;
        _canvasGroup.blocksRaycasts = true;
        transform.SetParent(parentAfterDrag);
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.anchoredPosition += eventData.delta/_canvas.scaleFactor;
    }
}
