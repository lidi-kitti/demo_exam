﻿#pragma checksum "..\..\..\СтраницыПользователя\МенюПользователь.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E381E4596FE751C567A7F514E58217423EACE6079244D0FEDE10032E6CF7A228"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Proga.СтраницыПользователя;
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


namespace Proga.СтраницыПользователя {
    
    
    /// <summary>
    /// МенюПользователь
    /// </summary>
    public partial class МенюПользователь : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewЗаявка_Btn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllЗаявкаs_Btn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameMainMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/Proga;component/%d0%a1%d1%82%d1%80%d0%b0%d0%bd%d0%b8%d1%86%d1%8b%d0%9f%d0%be%d0%" +
                    "bb%d1%8c%d0%b7%d0%be%d0%b2%d0%b0%d1%82%d0%b5%d0%bb%d1%8f/%d0%9c%d0%b5%d0%bd%d1%8" +
                    "e%d0%9f%d0%be%d0%bb%d1%8c%d0%b7%d0%be%d0%b2%d0%b0%d1%82%d0%b5%d0%bb%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
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
            
            #line 9 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
            ((Proga.СтраницыПользователя.МенюПользователь)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddNewЗаявка_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
            this.AddNewЗаявка_Btn.Click += new System.Windows.RoutedEventHandler(this.AddNewЗаявка_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AllЗаявкаs_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\СтраницыПользователя\МенюПользователь.xaml"
            this.AllЗаявкаs_Btn.Click += new System.Windows.RoutedEventHandler(this.AllЗаявкаs_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FrameMainMenu = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

