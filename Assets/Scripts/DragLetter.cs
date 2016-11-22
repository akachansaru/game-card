using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragLetter : MonoBehaviour, IDragHandler, IEndDragHandler {

	public string letter;

	public void OnDrag(PointerEventData eventData) {
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		
	}

}
