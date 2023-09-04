using System;

namespace Infrastructure.Services.Input
{
    public interface IInputService
    {
        float XAxis { get; }
        bool OnFireTap { get; }
        float YAxis { get; }
    }
}