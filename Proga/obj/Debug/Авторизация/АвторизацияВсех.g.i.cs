﻿#pragma checksum "..\..\..\Авторизация\АвторизацияВсех.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBFECFB39F4D74723D4CA5414065920569805587E58187CD1F6064EF6F4D1C09"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Proga.Авторизация;
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


namespace Proga.Авторизация {
    
    
    /// <summary>
    /// АвторизацияВсех
    /// </summary>
    public partial class АвторизацияВсех : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Авторизация\АвторизацияВсех.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Login;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Авторизация\АвторизацияВсех.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PB_password;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Авторизация\АвторизацияВсех.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink HL_Reg;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Авторизация\АвторизацияВсех.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNext;
        
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
            System.Uri resourceLocater = new System.Uri("/Proga;component/%d0%90%d0%b2%d1%82%d0%be%d1%80%d0%b8%d0%b7%d0%b0%d1%86%d0%b8%d1%" +
                    "8f/%d0%90%d0%b2%d1%82%d0%be%d1%80%d0%b8%d0%b7%d0%b0%d1%86%d0%b8%d1%8f%d0%92%d1%8" +
                    "1%d0%b5%d1%85.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Авторизация\АвторизацияВсех.xaml"
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
            this.TB_Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PB_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.HL_Reg = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 32 "..\..\..\Авторизация\АвторизацияВсех.xaml"
            this.HL_Reg.Click += new System.Windows.RoutedEventHandler(this.HL_Reg_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonNext = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Авторизация\АвторизацияВсех.xaml"
            this.ButtonNext.Click += new System.Windows.RoutedEventHandler(this.ButtonNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

