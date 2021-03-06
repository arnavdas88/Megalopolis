﻿using System;
using System.Runtime.Serialization;

namespace Megalopolis
{
    namespace ActivationFunctions
    {
        [DataContract]
        public class ReLU : IActivationFunction
        {
            public double Function(double x)
            {
                if (x > 0)
                {
                    return x;
                }

                return 0;
            }

            public double Derivative(double x)
            {
                if (x > 0)
                {
                    return 1.0;
                }

                return 0;
            }
        }
    }
}
