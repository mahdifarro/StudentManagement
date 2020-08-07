﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BAB4CD25DF7A7C4F430BE26D598ACCFE9F4A1339A2CB4D0D77804BB8DE6BF7F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StudentsManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace StudentsManager {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMain;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image backgroundImage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush adminPic;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dasboard_name;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionPanel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_Icon;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_Icon;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editInfo_Icon;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createWord_Icon;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button out_Icon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StudentsManager;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GridMain = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\AdminWindow.xaml"
            this.GridMain.Loaded += new System.Windows.RoutedEventHandler(this.Load_Page);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backgroundImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.adminPic = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 4:
            this.dasboard_name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DescriptionPanel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\AdminWindow.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.add_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\AdminWindow.xaml"
            this.add_Icon.Click += new System.Windows.RoutedEventHandler(this.Add_Icon_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.search_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\AdminWindow.xaml"
            this.search_Icon.Click += new System.Windows.RoutedEventHandler(this.Search_Icon_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.editInfo_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\AdminWindow.xaml"
            this.editInfo_Icon.Click += new System.Windows.RoutedEventHandler(this.editInfo_Icon_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.createWord_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\AdminWindow.xaml"
            this.createWord_Icon.Click += new System.Windows.RoutedEventHandler(this.createWord_Icon_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.out_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\AdminWindow.xaml"
            this.out_Icon.Click += new System.Windows.RoutedEventHandler(this.Out_Icon_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

