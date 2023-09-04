using UnityEngine;
using Zenject;

namespace Infrastructure.Factories.UI
{
    public class UIFactory : IUIFactory
    {
        private DiContainer _container;
        private RectTransform _canvasRect;
        private GameObject _waitingHud;
        private GameObject _endgameHud;

        public UIFactory(DiContainer container)
        {
            _container = container;

            CreateCanvas();
        }

        private void CreateCanvas()
        {
            
        }
    }
}