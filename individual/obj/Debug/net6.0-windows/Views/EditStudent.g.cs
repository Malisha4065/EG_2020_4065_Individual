﻿#pragma checksum "..\..\..\..\Views\EditStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6A2E39D915A4C05B19C1879D8397A61CBC8EA4F"
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
using individual.ViewModels;
using individual.Views;


namespace individual.Views {
    
    
    /// <summary>
    /// EditStudent
    /// </summary>
    public partial class EditStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 101 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthdayPicker2;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CityPicker;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3301;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3302;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3203;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3305;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3206;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EE3151;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\Views\EditStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IS3302;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/individual;component/views/editstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\EditStudent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\Views\EditStudent.xaml"
            ((individual.Views.EditStudent)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 83 "..\..\..\..\Views\EditStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minimize_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 84 "..\..\..\..\Views\EditStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BirthdayPicker2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.CityPicker = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.EE3301 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.EE3302 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.EE3203 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.EE3305 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.EE3206 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.EE3151 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.IS3302 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

