﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0A6C7B24560F4D7679D189AC6DFF78B0206414087D9F2F771AE7709CA566E9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPF;


namespace WPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAllTopings;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSalami;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMushrooms;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMozarella;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.cbAllTopings = ((System.Windows.Controls.CheckBox)(target));
            
            #line 117 "..\..\MainWindow.xaml"
            this.cbAllTopings.Checked += new System.Windows.RoutedEventHandler(this.CbAllTopings_Checked);
            
            #line default
            #line hidden
            
            #line 117 "..\..\MainWindow.xaml"
            this.cbAllTopings.Unchecked += new System.Windows.RoutedEventHandler(this.CbAllTopings_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbSalami = ((System.Windows.Controls.CheckBox)(target));
            
            #line 119 "..\..\MainWindow.xaml"
            this.cbSalami.Checked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            
            #line 119 "..\..\MainWindow.xaml"
            this.cbSalami.Unchecked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbMushrooms = ((System.Windows.Controls.CheckBox)(target));
            
            #line 124 "..\..\MainWindow.xaml"
            this.cbMushrooms.Checked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            
            #line 124 "..\..\MainWindow.xaml"
            this.cbMushrooms.Unchecked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbMozarella = ((System.Windows.Controls.CheckBox)(target));
            
            #line 125 "..\..\MainWindow.xaml"
            this.cbMozarella.Checked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            
            #line 125 "..\..\MainWindow.xaml"
            this.cbMozarella.Unchecked += new System.Windows.RoutedEventHandler(this.CbSalami_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

