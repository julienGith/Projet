#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "710B46740B1D66888C17857B0AFF8FDB6D0C811AC6F1C9DBF262D4C7620EB09B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Configuration;
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
using TrouveLeMot;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Configuration
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;

#line default
#line hidden


#line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxLex;

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxMot;

#line default
#line hidden


#line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxCible;

#line default
#line hidden


#line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTransfert;

#line default
#line hidden


#line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupr;

#line default
#line hidden


#line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;

#line default
#line hidden


#line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rBtnPerso;

#line default
#line hidden


#line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rBtnFacile;

#line default
#line hidden


#line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rBtnDifficile;

#line default
#line hidden


#line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rBtnExpert;

#line default
#line hidden


#line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown nupDurée;

#line default
#line hidden


#line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown nupPtPerdu;

#line default
#line hidden


#line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;

#line default
#line hidden


#line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown nupManches;

#line default
#line hidden


#line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown nupEssais;

#line default
#line hidden


#line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTri;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TrouveLeMot;component/mainwindow.xaml", System.UriKind.Relative);

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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btnAdd = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\MainWindow.xaml"
                    this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.listBoxLex = ((System.Windows.Controls.ListBox)(target));
                    return;
                case 3:
                    this.txtBoxMot = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.listBoxCible = ((System.Windows.Controls.ListBox)(target));

#line 23 "..\..\MainWindow.xaml"
                    this.listBoxCible.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxCible_SelectionChanged);

#line default
#line hidden
                    return;
                case 5:
                    this.btnTransfert = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\MainWindow.xaml"
                    this.btnTransfert.Click += new System.Windows.RoutedEventHandler(this.BtnTransfert_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btnSupr = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\MainWindow.xaml"
                    this.btnSupr.Click += new System.Windows.RoutedEventHandler(this.BtnSupr_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.btnRemove = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\MainWindow.xaml"
                    this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.BtnRemove_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.rBtnPerso = ((System.Windows.Controls.RadioButton)(target));

#line 31 "..\..\MainWindow.xaml"
                    this.rBtnPerso.Checked += new System.Windows.RoutedEventHandler(this.RBtnPerso_Checked);

#line default
#line hidden
                    return;
                case 9:
                    this.rBtnFacile = ((System.Windows.Controls.RadioButton)(target));

#line 32 "..\..\MainWindow.xaml"
                    this.rBtnFacile.Checked += new System.Windows.RoutedEventHandler(this.RBtnFacile_Checked);

#line default
#line hidden
                    return;
                case 10:
                    this.rBtnDifficile = ((System.Windows.Controls.RadioButton)(target));

#line 33 "..\..\MainWindow.xaml"
                    this.rBtnDifficile.Checked += new System.Windows.RoutedEventHandler(this.RBtnDifficile_Checked);

#line default
#line hidden
                    return;
                case 11:
                    this.rBtnExpert = ((System.Windows.Controls.RadioButton)(target));

#line 34 "..\..\MainWindow.xaml"
                    this.rBtnExpert.Checked += new System.Windows.RoutedEventHandler(this.RBtnExpert_Checked);

#line default
#line hidden
                    return;
                case 12:
                    this.nupDurée = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));

#line 37 "..\..\MainWindow.xaml"
                    this.nupDurée.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.NupDurée_ValueChanged);

#line default
#line hidden
                    return;
                case 13:
                    this.nupPtPerdu = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
                    return;
                case 14:
                    this.btnClose = ((System.Windows.Controls.Button)(target));

#line 41 "..\..\MainWindow.xaml"
                    this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);

#line default
#line hidden
                    return;
                case 15:
                    this.nupManches = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));

#line 43 "..\..\MainWindow.xaml"
                    this.nupManches.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.NupManches_ValueChanged);

#line default
#line hidden
                    return;
                case 16:
                    this.lblScore = ((System.Windows.Controls.Label)(target));
                    return;
                case 17:
                    this.nupEssais = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));

#line 47 "..\..\MainWindow.xaml"
                    this.nupEssais.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.NupEssais_ValueChanged);

#line default
#line hidden
                    return;
                case 18:
                    this.btnTri = ((System.Windows.Controls.Button)(target));

#line 48 "..\..\MainWindow.xaml"
                    this.btnTri.Click += new System.Windows.RoutedEventHandler(this.BtnTri_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.GroupBox gpBoptions;
    }
}

