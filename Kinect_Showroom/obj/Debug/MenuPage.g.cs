﻿#pragma checksum "..\..\MenuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2BF6BB864B159BF86AAA416B339D6A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
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


namespace Kinect_Showroom {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton ArticleButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton MapButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton PhotosButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Kinect_Showroom;component/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuPage.xaml"
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
            this.ArticleButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 25 "..\..\MenuPage.xaml"
            this.ArticleButton.AddHandler(Microsoft.Kinect.Toolkit.Controls.KinectRegion.HandPointerEnterEvent, new System.EventHandler<Microsoft.Kinect.Toolkit.Controls.HandPointerEventArgs>(this.ArticleButton_OnHandPointerEnter));
            
            #line default
            #line hidden
            
            #line 25 "..\..\MenuPage.xaml"
            this.ArticleButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ArticleButton_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MenuPage.xaml"
            this.ArticleButton.Click += new System.Windows.RoutedEventHandler(this.ArticleButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MapButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 33 "..\..\MenuPage.xaml"
            this.MapButton.AddHandler(Microsoft.Kinect.Toolkit.Controls.KinectRegion.HandPointerEnterEvent, new System.EventHandler<Microsoft.Kinect.Toolkit.Controls.HandPointerEventArgs>(this.MapButton_OnHandPointerEnter));
            
            #line default
            #line hidden
            
            #line 33 "..\..\MenuPage.xaml"
            this.MapButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MapButton_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MenuPage.xaml"
            this.MapButton.Click += new System.Windows.RoutedEventHandler(this.MapButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PhotosButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 47 "..\..\MenuPage.xaml"
            this.PhotosButton.AddHandler(Microsoft.Kinect.Toolkit.Controls.KinectRegion.HandPointerEnterEvent, new System.EventHandler<Microsoft.Kinect.Toolkit.Controls.HandPointerEventArgs>(this.PhotosButton_OnHandPointerEnter));
            
            #line default
            #line hidden
            
            #line 47 "..\..\MenuPage.xaml"
            this.PhotosButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PhotosButton_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MenuPage.xaml"
            this.PhotosButton.Click += new System.Windows.RoutedEventHandler(this.PhotosButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExitButton = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 55 "..\..\MenuPage.xaml"
            this.ExitButton.AddHandler(Microsoft.Kinect.Toolkit.Controls.KinectRegion.HandPointerEnterEvent, new System.EventHandler<Microsoft.Kinect.Toolkit.Controls.HandPointerEventArgs>(this.ExitButton_OnHandPointerEnter));
            
            #line default
            #line hidden
            
            #line 55 "..\..\MenuPage.xaml"
            this.ExitButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ExitButton_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 55 "..\..\MenuPage.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

