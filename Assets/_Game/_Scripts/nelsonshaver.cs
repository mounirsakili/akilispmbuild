using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class nelsonshaver : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool gaylapollock = false;
    [System.Serializable]
    public class quintoncoker : UnityEvent { }
    [SerializeField]
    private quintoncoker myOwnEvent = new quintoncoker();
    public quintoncoker onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, katecalderon = 1f;
    private Vector3 startPosition, wandaelder;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gaylapollock)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (gaylapollock)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator noellebriggs()
    {
        yield return estherstallings(transform, transform.localPosition, wandaelder, katecalderon);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float mariecoffey = 1.0f / value;
        float hopeholland = 0.0f;
        while (hopeholland < 1.0)
        {
            hopeholland += Time.deltaTime * mariecoffey;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, hopeholland));
            yield return null;
        }

        thisTransform.localPosition = wandaelder;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        wandaelder = EPos;

        katecalderon = MTime;

        StartCoroutine(noellebriggs());
    }
}
