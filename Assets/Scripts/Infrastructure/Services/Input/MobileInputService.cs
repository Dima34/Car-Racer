namespace Infrastructure.Services.Input
{
    public class MobileInputService : InputService
    {
        protected override float GetXAxis() =>
            GetTouchOnScreenPercent();

        protected override float GetYAxis()
        {
            return 0;
        }

        protected override bool IsStartTap() =>
            UnityEngine.Input.touchCount > 0;
    }
}