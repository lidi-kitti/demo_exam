﻿#pragma checksum "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F1660AAFB3B9D2B0D8BFE138A3AD93133597FCE1B661478C7A0BCA46F8EEC939"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Proga.МенеджерСтраницы;
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


namespace Proga.МенеджерСтраницы {
    
    
    /// <summary>
    /// ЗаявкиМенеджер
    /// </summary>
    public partial class ЗаявкиМенеджер : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Poisk;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridЗаявкаs;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Proga;component/%d0%9c%d0%b5%d0%bd%d0%b5%d0%b4%d0%b6%d0%b5%d1%80%d0%a1%d1%82%d1%" +
                    "80%d0%b0%d0%bd%d0%b8%d1%86%d1%8b/%d0%97%d0%b0%d1%8f%d0%b2%d0%ba%d0%b8%d0%9c%d0%b" +
                    "5%d0%bd%d0%b5%d0%b4%d0%b6%d0%b5%d1%80.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
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
            
            #line 9 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
            ((Proga.МенеджерСтраницы.ЗаявкиМенеджер)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
            ((Proga.МенеджерСтраницы.ЗаявкиМенеджер)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Poisk = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
            this.Poisk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Poisk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridЗаявкаs = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\МенеджерСтраницы\ЗаявкиМенеджер.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

