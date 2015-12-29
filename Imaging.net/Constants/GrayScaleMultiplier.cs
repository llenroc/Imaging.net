﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using Imaging.net.Encoders;
using Imaging.net.Quantizers.Helpers;
using Imaging.net.Quantizers.XiaolinWu;
using Imaging.net.Processing;

namespace Imaging.net
{
    public static partial class GrayScaleMultiplier
    {
        public const float NtscRed = 0.299f;
        public const float NtscGreen = 0.587f;
        public const float NtscBlue = 0.114f;

        public const float NaturalRed = 0.3086f;
        public const float NaturalGreen = 0.6094f;
        public const float NaturalBlue = 0.0820f;

        public const float AccurateRed = 1.0f / 3.0f;
        public const float AccurateGreen = 1.0f / 3.0f;
        public const float AccurateBlue = 1.0f / 3.0f;
    }

}