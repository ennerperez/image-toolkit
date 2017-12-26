using System;

namespace Platform.Support
{
#if PORTABLE
    namespace Core
    {
#endif

    namespace Maths
    {
        public static class MathHelper
        {
            public const float RadianPI = 57.29578f; // 180.0 / Math.PI
            public const float DegreePI = 0.01745329f; // Math.PI / 180.0
            public const float TwoPI = 6.28319f; // Math.PI * 2

            private static readonly object randomLock = new object();
            private static readonly Random random = new Random();

            public static int Random(int max)
            {
                lock (randomLock)
                {
                    return random.Next(max + 1);
                }
            }

            public static int Random(int min, int max)
            {
                lock (randomLock)
                {
                    return random.Next(min, max + 1);
                }
            }

            public static float RadianToDegree(float radian)
            {
                return radian * RadianPI;
            }

            public static float DegreeToRadian(float degree)
            {
                return degree * DegreePI;
            }

            public static float Lerp(float value1, float value2, float amount)
            {
                return value1 + (value2 - value1) * amount;
            }
        }
    }

#if PORTABLE
}
#endif
}