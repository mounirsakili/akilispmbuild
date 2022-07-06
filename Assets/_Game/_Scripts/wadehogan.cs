using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class wadehogan : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool tammyvoss = false;
    [System.Serializable]
    public class kennethbutts : UnityEvent { }
    [SerializeField]
    private kennethbutts myOwnEvent = new kennethbutts();
    public kennethbutts onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, eunicegallardo = 1f;
    private Vector3 startPosition, shereedale;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (tammyvoss)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (tammyvoss)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator saraandrade()
    {
        yield return estherstallings(transform, transform.localPosition, shereedale, eunicegallardo);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float allieparsons = 1.0f / value;
        float odessachen = 0.0f;
        while (odessachen < 1.0)
        {
            odessachen += Time.deltaTime * allieparsons;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, odessachen));
            yield return null;
        }

        thisTransform.localPosition = shereedale;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        shereedale = EPos;

        eunicegallardo = MTime;

        StartCoroutine(saraandrade());
    }
}
