﻿#pragma checksum "..\..\..\..\view\pagePengembalian.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327B3D80B528B23DA8A4EDE0292FCA4AF4D9AD6A"
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
using inventtaris.view;


namespace inventtaris.view {
    
    
    /// <summary>
    /// pagePengembalian
    /// </summary>
    public partial class pagePengembalian : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\..\view\pagePengembalian.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox lisPeminjaman;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\view\pagePengembalian.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namaPeminjam;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\view\pagePengembalian.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namaBarang;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\view\pagePengembalian.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox jumlahBarang;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\view\pagePengembalian.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTambah;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/inventtaris;component/view/pagepengembalian.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\view\pagePengembalian.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lisPeminjaman = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.namaPeminjam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.namaBarang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.jumlahBarang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnTambah = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
