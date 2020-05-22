// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace UnitsNet
{
    public partial struct Angle
    {
        /// <summary>Get <see cref="RotationalSpeed"/> from <see cref="Angle"/> delta over time delta.</summary>
        public static RotationalSpeed operator /(Angle angle, TimeSpan timeSpan)
        {
            return RotationalSpeed.FromRadiansPerSecond(angle.Radians / timeSpan.TotalSeconds);
        }

        /// <inheritdoc cref="op_Division(UnitsNet.Angle,System.TimeSpan)" />
        public static RotationalSpeed operator /(Angle angle, Duration duration)
        {
            return RotationalSpeed.FromRadiansPerSecond(angle.Radians / duration.Seconds);
        }

        /// <summary>
        /// Normalizes the angle so it is within one circle.
        /// </summary>
        /// <param name="toFullCircle">Set to true to normalize to a full circle (0 to 360° degrees, 0 to 2 Pi),
        /// otherwise normalizes to a half circle (+/-180°, +/- Pi)</param>
        public Angle Normalize(bool toFullCircle)
        {
            double r = Radians;
            if (toFullCircle)
            {
                if (r > Math.PI * 2)
                {
                    r = r % (Math.PI * 2);
                }

                if (r < 0)
                {
                    r = -(Math.Abs(r) % (Math.PI * 2));
                    if (r < 0)
                    {
                        r += Math.PI * 2;
                    }
                }
            }
            else
            {
                if (r > Math.PI)
                {
                    r = r % (Math.PI * 2);
                    if (r > Math.PI)
                    {
                        // Still above Pi?
                        r -= Math.PI * 2;
                    }
                }

                if (r < -Math.PI)
                {
                    r = -(Math.Abs(r) % (Math.PI * 2));
                    if (r < -Math.PI)
                    {
                        r += Math.PI * 2;
                    }
                }
            }

            return FromRadians(r);
        }

        /// <summary>
        /// Converts an angle in geographic definition to mathematical definition.
        /// Geographers give angles in degrees, where 0 degrees is north, counting clockwise, mathematicians give angles
        /// in radians, starting east and going counterclockwise.
        /// </summary>
        /// <param name="direction">Geographic angle</param>
        /// <returns>Mathematical angle, normalized to 0..2Pi</returns>
        public static Angle DirectionToMathematical(Angle direction)
        {
            double temp = ((-direction.Degrees) + 90.0);
            Angle rad = FromDegrees(temp);
            return rad.Normalize(true);
        }

        /// <summary>
        /// Convert angle from mathematical definition to geographic definition
        /// <seealso cref="DirectionToMathematical"/>
        /// </summary>
        /// <param name="math">Mathematical value in radians</param>
        /// <returns>Direction angle, geographic definition</returns>
        public static Angle MathematicalToDirection(Angle math)
        {
            double ret = math.Degrees;
            ret = ((-ret) + 90.0);
            if (ret < 0)
            {
                ret += 360;
            }

            return FromDegrees(ret);
        }

        /// <summary>
        /// Calculate the difference between two angles, properly considering overflow.
        /// 
        /// </summary>
        /// <param name="desired">First angle (desired)</param>
        /// <param name="actual">Second angle (actual)</param>
        /// <returns>Difference, ranging +/- half the circle. The sign indicates in which direction one needs to turn
        /// to follow the given direction. Negative is left/port</returns>
        public static Angle DirectionDifference(Angle desired, Angle actual)
        {
            Angle delta = desired - actual;
            return delta.Normalize(false);
        }

        /// <summary>
        /// Gives the angle that is the hypotenuse for the given triangle sides. That is the angle one needs to drive
        /// when going x to the right (or left) and y up (or down) in a cartesian coordinate system.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Angle FromCartesianDistances(Length x, Length y)
        {

        }
    }
}
