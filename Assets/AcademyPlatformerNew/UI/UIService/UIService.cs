using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AcademyPlatformerNew.UI.UIService
{
    public class UIService : IUIService
    {
        private Dictionary<Type, UIWindow> _loadWindow = new Dictionary<Type, UIWindow>();
        private Dictionary<Type, GameObject> _initWindow = new Dictionary<Type, GameObject>();

        private UIRoot _uiRoot;

        public UIService(UIRoot uiRoot)
        {
            _uiRoot = uiRoot;
            LoadWindows();
            InitWindows();
        }

        public T Show<T>() where T : UIWindow
        {
            var window = Get<T>();
            if (window != null)
            {
                window.transform.SetParent(_uiRoot.ActiveContainer);
                window.Show();
                
                return window;
            }
            
            return null;
        }

        public void Hide<T>() where T : UIWindow
        {
            var window = Get<T>();
            if (window != null)
            {
                window.transform.SetParent(_uiRoot.DeactiveContainer);
                window.Hide();
            }
        }

        public T Get<T>() where T : UIWindow
        {
            var type = typeof(T);
            if (_initWindow.ContainsKey(type))
            {
                return _initWindow[type].GetComponent<T>();
            }

            return null;
        }

        public void InitWindows()
        {
            foreach (var key in _loadWindow.Keys)
            {
                var window = GameObject.Instantiate(_loadWindow[key].gameObject, _uiRoot.DeactiveContainer);
               
                window.transform.SetParent(_uiRoot.DeactiveContainer);
                
                _initWindow.Add(key, window);
            }
        }

        public void LoadWindows()
        {
            var windows = Resources.LoadAll(ResourcesConst.SourceUIWindow, typeof(UIWindow));
            foreach (var window in windows)
            {
                var type = window.GetType();
                
                _loadWindow.Add(type, (UIWindow) window);
            } 
        }
    }
}