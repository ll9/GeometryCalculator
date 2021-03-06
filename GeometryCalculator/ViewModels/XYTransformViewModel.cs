﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.ViewModels
{
    public class XYTransformViewModel: INotifyPropertyChanged
    {
            public double _xSourceCoordinates;
            [DisplayName("Quelle-X")]
            public double XSourceCoordinates { get => _xSourceCoordinates; set => SetField(ref _xSourceCoordinates, value); }
            public double _ySourceCoordinates;
            [DisplayName("Quelle-Y")]
            public double YSourceCoordinates { get => _ySourceCoordinates; set => SetField(ref _ySourceCoordinates, value); }

            public int _sourceProjection;
            [DisplayName("Quellprojektion")]
            public int SourceProjection { get => _sourceProjection; set => SetField(ref _sourceProjection, value); }
            public int _targetProjection;
            [DisplayName("Zielprojektion")]
            public int TargetProjection { get => _targetProjection; set => SetField(ref _targetProjection, value); }

            public double _xTargetCoordinates;
            [DisplayName("Ziel-X")]
            public double XTargetCoordinates { get => _xTargetCoordinates; set => SetField(ref _xTargetCoordinates, value); }
            public double _yTargetCoordinates;
            [DisplayName("Ziel-Y")]
            public double YTargetCoordinates { get => _yTargetCoordinates; set => SetField(ref _yTargetCoordinates, value); }


            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                //C# 6 null-safe operator. No need to check for event listeners
                //If there are no listeners, this will be a noop
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            // C# 5 - CallMemberName means we don't need to pass the property's name
            protected bool SetField<T>(ref T field, T value,
            [CallerMemberName] string propertyName = null)
            {
                if (EqualityComparer<T>.Default.Equals(field, value))
                    return false;
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }

    }
}
