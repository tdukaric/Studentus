﻿#pragma checksum "C:\Users\dux\Dropbox\Projekti - Luka, Dux\Studentus\Studentus\NewTask.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E12F20067B6BE16776BB1CE9D875270F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
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


namespace Studentus {
    
    
    public partial class NewTask : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot settings;
        
        internal System.Windows.Controls.ScrollViewer svw;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox taskName;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBox taskDescription;
        
        internal Microsoft.Phone.Controls.DatePicker deadLine;
        
        internal Microsoft.Phone.Controls.ListPicker subjectPick;
        
        internal System.Windows.Controls.ScrollViewer scroll;
        
        internal System.Windows.Controls.StackPanel ContentPanel1;
        
        internal Microsoft.Phone.Controls.DatePicker startClasses;
        
        internal Microsoft.Phone.Controls.DatePicker endClasses;
        
        internal System.Windows.Controls.TextBlock textBlock_ponavljanje;
        
        internal System.Windows.Controls.Grid repetitionOptions;
        
        internal System.Windows.Controls.TextBox numberOfUnits;
        
        internal System.Windows.Controls.CheckBox alarm;
        
        internal Microsoft.Phone.Controls.ListPicker teacherPick;
        
        internal Microsoft.Phone.Controls.ListPicker rSubjectPick;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Studentus;component/NewTask.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.settings = ((Microsoft.Phone.Controls.Pivot)(this.FindName("settings")));
            this.svw = ((System.Windows.Controls.ScrollViewer)(this.FindName("svw")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.taskName = ((System.Windows.Controls.TextBox)(this.FindName("taskName")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.taskDescription = ((System.Windows.Controls.TextBox)(this.FindName("taskDescription")));
            this.deadLine = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("deadLine")));
            this.subjectPick = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("subjectPick")));
            this.scroll = ((System.Windows.Controls.ScrollViewer)(this.FindName("scroll")));
            this.ContentPanel1 = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel1")));
            this.startClasses = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("startClasses")));
            this.endClasses = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("endClasses")));
            this.textBlock_ponavljanje = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_ponavljanje")));
            this.repetitionOptions = ((System.Windows.Controls.Grid)(this.FindName("repetitionOptions")));
            this.numberOfUnits = ((System.Windows.Controls.TextBox)(this.FindName("numberOfUnits")));
            this.alarm = ((System.Windows.Controls.CheckBox)(this.FindName("alarm")));
            this.teacherPick = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("teacherPick")));
            this.rSubjectPick = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("rSubjectPick")));
        }
    }
}

