using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Infrastructure.MonoServices
{
    public class MouseInputHandler : MonoBehaviour, IInputHandler, IPointerDownHandler
    {
        public Action<Touch> InputHandled { get; set; }

        public void OnPointerDown(PointerEventData eventData)
        {
            Touch newTouch = new Touch();
            newTouch.position = eventData.position;
            InputHandled?.Invoke(newTouch);
        }
    }
}