using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class darenculver : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool elviahedrick = false;
    [System.Serializable]
    public class lorenzocullen : UnityEvent { }
    [SerializeField]
    private lorenzocullen myOwnEvent = new lorenzocullen();
    public lorenzocullen onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, lauradunn = 1f;
    private Vector3 startPosition, luellabush;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (elviahedrick)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (elviahedrick)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator darlamclaughlin()
    {
        yield return estherstallings(transform, transform.localPosition, luellabush, lauradunn);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float patricesheppard = 1.0f / value;
        float nadinecrosby = 0.0f;
        while (nadinecrosby < 1.0)
        {
            nadinecrosby += Time.deltaTime * patricesheppard;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, nadinecrosby));
            yield return null;
        }

        thisTransform.localPosition = luellabush;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        luellabush = EPos;

        lauradunn = MTime;

        StartCoroutine(darlamclaughlin());
    }
}
