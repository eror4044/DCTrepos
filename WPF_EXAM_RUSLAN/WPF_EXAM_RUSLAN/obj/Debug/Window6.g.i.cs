﻿#pragma checksum "..\..\Window6.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ABB2546B3E8B49C3AF166DDC4A5771DBB88E2CA419DF91BBBD00405A60855E1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WPF_EXAM_RUSLAN;


namespace WPF_EXAM_RUSLAN {
    
    
    /// <summary>
    /// Window6
    /// </summary>
    public partial class Window6 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginField;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassField;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailField;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearPhotoBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Avatar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Window6.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CanselBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_EXAM_RUSLAN;component/window6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window6.xaml"
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
            this.LoginField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PassField = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.EmailField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 27 "..\..\Window6.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClearPhotoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Window6.xaml"
            this.ClearPhotoBtn.Click += new System.Windows.RoutedEventHandler(this.ClearPhotoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Avatar = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.OkBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Window6.xaml"
            this.OkBtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CanselBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Window6.xaml"
            this.CanselBtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

