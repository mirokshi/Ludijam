using MoreMountains.Feedbacks;
using UnityEngine;
using  UnityEngine.EventSystems;


public class DragDropN2 : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler,  IPointerEnterHandler, IPointerExitHandler 
{
    [SerializeField] private Canvas _canvas;
    private RectTransform _rectTransform;
    private CanvasGroup _canvasGroup;
    [SerializeField] public MMFeedbacks Feedback;
    
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Transform originParent;
    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
        originParent = transform.parent;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.transform.localScale = new Vector3(1.1f,1.1f,1.1f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.transform.localScale = new Vector3(1f,1f,1f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Feedback.PlayFeedbacks();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _canvasGroup.blocksRaycasts = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _canvasGroup.blocksRaycasts = true;
        transform.SetParent(parentAfterDrag);
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.anchoredPosition += eventData.delta/_canvas.scaleFactor;
        this.gameObject.transform.localScale = new Vector3(.9f,.9f,.9f);
    }
}
