﻿#pragma checksum "..\..\Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7C4BC0B0B927427384AEA418F9F832DE990E5D659B90AC707B7173640BC236D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant_ManagementFull;
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


namespace Restaurant_ManagementFull {
    
    
    /// <summary>
    /// CodingWnd
    /// </summary>
    public partial class CodingWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxbTitleCustomer;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DvgRoot;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DvgChild;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GrdBtn;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GrdAddCoding;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTitleCoding;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveCoding;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelCoding;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant_ManagementFull;component/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Add.xaml"
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
            
            #line 14 "..\..\Add.xaml"
            ((Restaurant_ManagementFull.CodingWnd)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxbTitleCustomer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DvgRoot = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\Add.xaml"
            this.DvgRoot.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DvgRoot_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DvgChild = ((System.Windows.Controls.DataGrid)(target));
            
            #line 43 "..\..\Add.xaml"
            this.DvgChild.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DvgChild_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GrdBtn = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 57 "..\..\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAddCoding);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 75 "..\..\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditeCoding);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 93 "..\..\Add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseCodingPage);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GrdAddCoding = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.TxtTitleCoding = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.BtnSaveCoding = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\Add.xaml"
            this.BtnSaveCoding.Click += new System.Windows.RoutedEventHandler(this.BtnAddOrEditeSave);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnCancelCoding = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\Add.xaml"
            this.BtnCancelCoding.Click += new System.Windows.RoutedEventHandler(this.BtnCancelAdd);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

