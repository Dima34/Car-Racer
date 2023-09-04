using Infrastructure.Services.Input;
using Infrastructure.Services.StaticData;
using StaticData;
using UnityEngine;
using Zenject;

namespace Infrastructure.Logic
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _head;
        private IInputService _inputService;
        private PlayerStaticData _playerData;
        private IStaticDataService _staticDataService;

        [Inject]
        public void Construct(IInputService inputService, IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
            _inputService = inputService;
        }

        private void Update()
        {
            ApplyXHeadRotation();
            ApplyYHeadRotation();
        }

        private void ApplyXHeadRotation() =>
            ApplyHeadRotation(_inputService.XAxis, _playerData.HorizontalHeadRotationSpeed, _head.transform.up);

        private void ApplyYHeadRotation() =>
            ApplyHeadRotation(_inputService.YAxis, _playerData.VerticalHeadRotationSpeed, _head.transform.right);

        private void ApplyHeadRotation(float xAxis, float headRotationSpeed, Vector3 rotAxis)
        {
            if (xAxis != 0)
            {
                float rotAngle = xAxis * headRotationSpeed * Time.deltaTime;
                AddHeadRotation(rotAngle, rotAxis);
            }
        }

        private void AddHeadRotation(float rotAngle, Vector3 rotAxis)
        {
            _head.transform.rotation *=
                Quaternion.AngleAxis(rotAngle,
                    rotAxis);
        }
    }
}