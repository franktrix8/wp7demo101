﻿#pragma checksum "G:\wp7_ws\wp7demo101\4-StopWatch\4-StopWatch\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8EEC03C629443A65CCCE16AB0086C0E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using _4_StopWatch;


namespace _4_StopWatch {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal _4_StopWatch.TimeSpanDisplay CurrentLapTimeDisplay;
        
        internal _4_StopWatch.TimeSpanDisplay TotalTimeDisplay;
        
        internal System.Windows.Controls.ProgressBar LapProgressBar;
        
        internal System.Windows.Controls.Button StartBtn;
        
        internal System.Windows.Controls.Button StopBtn;
        
        internal System.Windows.Controls.Button ResetBtn;
        
        internal System.Windows.Controls.Button LapBtn;
        
        internal System.Windows.Controls.StackPanel LapsStackPanel;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/4-StopWatch;component/MainPage.xaml", System.UriKind.Relative));
            this.CurrentLapTimeDisplay = ((_4_StopWatch.TimeSpanDisplay)(this.FindName("CurrentLapTimeDisplay")));
            this.TotalTimeDisplay = ((_4_StopWatch.TimeSpanDisplay)(this.FindName("TotalTimeDisplay")));
            this.LapProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("LapProgressBar")));
            this.StartBtn = ((System.Windows.Controls.Button)(this.FindName("StartBtn")));
            this.StopBtn = ((System.Windows.Controls.Button)(this.FindName("StopBtn")));
            this.ResetBtn = ((System.Windows.Controls.Button)(this.FindName("ResetBtn")));
            this.LapBtn = ((System.Windows.Controls.Button)(this.FindName("LapBtn")));
            this.LapsStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("LapsStackPanel")));
        }
    }
}

