﻿#pragma checksum "..\..\..\ClientAddWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9127EEDEF3DDBF49658C20322FDE844E6E3AF01D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gym_Managment_Test;
using Microsoft.Windows.Themes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Xceed.Wpf.Toolkit.Obselete;


namespace Gym_Managment_Test {
    
    
    /// <summary>
    /// ClientAddView
    /// </summary>
    public partial class ClientAddView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephone;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Surname;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PESEL;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Return;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox combo;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox category;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\ClientAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.Obselete.MaskedTextBox BirthDate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Gym Managment Test;component/clientaddwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ClientAddWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\ClientAddWindow.xaml"
            this.Name.KeyDown += new System.Windows.Input.KeyEventHandler(this.Ikeychanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Telephone = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\ClientAddWindow.xaml"
            this.Telephone.KeyDown += new System.Windows.Input.KeyEventHandler(this.Wkeychanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Surname = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\ClientAddWindow.xaml"
            this.Surname.KeyDown += new System.Windows.Input.KeyEventHandler(this.Ikeychanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PESEL = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\ClientAddWindow.xaml"
            this.PESEL.KeyDown += new System.Windows.Input.KeyEventHandler(this.Wkeychanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Return = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\ClientAddWindow.xaml"
            this.Return.Click += new System.Windows.RoutedEventHandler(this.Return_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\ClientAddWindow.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.combo = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.category = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BirthDate = ((Xceed.Wpf.Toolkit.Obselete.MaskedTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

