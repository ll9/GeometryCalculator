using DotSpatial.Projections;
using GeometryCalculator.ViewModels;
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
    }
}
