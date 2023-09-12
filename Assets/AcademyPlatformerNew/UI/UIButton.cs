using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AcademyPlatformerNew.UI
{
    public class UIButton : MonoBehaviour, IPointerClickHandler
    {
        public Action OnClickButton;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            OnClickButton?.Invoke();
        }
    }
}