﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.ViewModels
{
    public class XYTransformViewModel
    {
        [DisplayName("X")]
        public double XSourceCoordinates { get; set; }
        [DisplayName("Y")]
        public double YSourceCoordinates { get; set; }

        [DisplayName("Quellprojektion")]
        public string SourceProjection { get; set; }
        [DisplayName("Zielprojektion")]
        public string TargetProjection { get; set; }

        [DisplayName("X")]
        public double XTargetCoordinates { get; set; }
        [DisplayName("Y")]
        public double YTargetCoordinates { get; set; }
    }
}