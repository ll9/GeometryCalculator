﻿using DotSpatial.Projections;
using GeoAPI.Geometries;
using GeometryCalculator.ViewModels;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalculator.Views
{
    public partial class MockView : Form
    {
        private XYTransformViewModel _xYTransformViewModel;

        public MockView()
        {
            InitializeComponent();

            _xYTransformViewModel = new XYTransformViewModel { SourceProjection = 4326, TargetProjection = 3857 };
            xYTransformViewModelBindingSource.DataSource = _xYTransformViewModel;
        }

        private void CalcXYButton_Click(object sender, EventArgs e)
        {
            var xy = new[] { _xYTransformViewModel.XSourceCoordinates, _xYTransformViewModel.YSourceCoordinates };
            var z = new[] { 0.0 };
            Reproject.ReprojectPoints(xy, z,
                ProjectionInfo.FromEpsgCode(_xYTransformViewModel.SourceProjection),
                ProjectionInfo.FromEpsgCode(_xYTransformViewModel.TargetProjection),
                0,
                1);

            _xYTransformViewModel.XTargetCoordinates = xy[0];
            _xYTransformViewModel.YTargetCoordinates = xy[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t();
        }

        public void t()
        {
            string wkt = "POINT (10 46)";
            WKTReader reader = new WKTReader();
            Geometry geom = (Geometry)reader.Read(wkt);

            double[] pointArray = new double[geom.Coordinates.Count() * 2];
            double[] zArray = new double[1];
            zArray[0] = 1;

            int counterX = 0;
            int counterY = 1;
            foreach (var coordinate in geom.Coordinates)
            {
                pointArray[counterX] = coordinate.X;
                pointArray[counterY] = coordinate.Y;

                counterX = counterX + 2;
                counterY = counterY + 2;
            }

            var sourceProjection = ProjectionInfo.FromEpsgCode(_xYTransformViewModel.SourceProjection);
            var targetProjection = ProjectionInfo.FromEpsgCode(_xYTransformViewModel.TargetProjection);


            Reproject.ReprojectPoints(pointArray, zArray, sourceProjection, targetProjection, 0, (pointArray.Length / 2));

            counterX = 0;
            counterY = 1;
            foreach (var coordinate in geom.Coordinates)
            {
                coordinate.X = pointArray[counterX];
                coordinate.Y = pointArray[counterY];

                counterX = counterX + 2;
                counterY = counterY + 2;
            }
            geom.GeometryChanged();

            var wktwriter = new WKTWriter();
            var x = wktwriter.Write(geom);
            Console.WriteLine(x);
        }
    }
}
