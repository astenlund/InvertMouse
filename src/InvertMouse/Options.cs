﻿using System;
using InvertMouse.Inverter;

namespace InvertMouse
{
    public class Options
    {
        private DriverType _driverType;

        public DriverType DriverType
        {
            get => _driverType;
            set
            {
                if (_driverType != value)
                {
                    _driverType = value;
                    OnChanged();
                }
            }
        }

        private bool _running;

        public bool Running
        {
            get => _running;
            set
            {
                if (_running != value)
                {
                    _running = value;
                    OnChanged();
                }
            }
        }

        private bool _whenCursorIsHidden = true;

        public bool WhenCursorIsHidden
        {
            get => _whenCursorIsHidden;
            set
            {
                if (_whenCursorIsHidden != value)
                {
                    _whenCursorIsHidden = value;
                    OnChanged();
                }
            }
        }

        private bool _xAxis;

        public bool XAxis
        {
            get => _xAxis;
            set
            {
                if (_xAxis != value)
                {
                    _xAxis = value;
                    OnChanged();
                }
            }
        }

        private bool _yAxis = true;

        public bool YAxis
        {
            get => _yAxis;
            set
            {
                if (_yAxis != value)
                {
                    _yAxis = value;
                    OnChanged();
                }
            }
        }

        private decimal _xMultiplier = InvertMouseBase.InvertMultiplier;

        public decimal XMultiplier
        {
            get => _xMultiplier;
            set
            {
                if (_xMultiplier != value)
                {
                    _xMultiplier = value;
                    OnChanged();
                }
            }
        }

        private decimal _yMultiplier = InvertMouseBase.InvertMultiplier;

        public decimal YMultiplier
        {
            get => _yMultiplier;
            set
            {
                if (_yMultiplier != value)
                {
                    _yMultiplier = value;
                    OnChanged();
                }
            }
        }

        private bool _minimizeToTray;

        public bool MinimizeToTray
        {
            get => _minimizeToTray;
            set
            {
                if (_minimizeToTray != value)
                {
                    _minimizeToTray = value;
                    OnChanged();
                }
            }
        }

        private bool _startMinimized;

        public bool StartMinimized
        {
            get => _startMinimized;
            set
            {
                if (_startMinimized != value)
                {
                    _startMinimized = value;
                    OnChanged();
                }
            }
        }

        public event EventHandler Changed;

        protected virtual void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
