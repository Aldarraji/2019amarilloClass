﻿#pragma checksum "..\..\Page6.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10371C452FF5E5D1A72B0323A8C477D3B94CADC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CareAmarillo;
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


namespace CareAmarillo {
    
    
    /// <summary>
    /// Page6
    /// </summary>
    public partial class Page6 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsername;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWelcomeText;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstResult;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSignout;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Page6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWelcomeText_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/CareAmarillo;component/page6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page6.xaml"
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
            this.lblUsername = ((System.Windows.Controls.Label)(target));
            
            #line 10 "..\..\Page6.xaml"
            this.lblUsername.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LblUsername_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lblWelcomeText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\Page6.xaml"
            this.txtSearch.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TxtSearch_MouseEnter);
            
            #line default
            #line hidden
            
            #line 20 "..\..\Page6.xaml"
            this.txtSearch.MouseLeave += new System.Windows.Input.MouseEventHandler(this.TxtSearch_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Page6.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstResult = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Page6.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblSignout = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\Page6.xaml"
            this.lblSignout.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LblSignout_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblWelcomeText_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

