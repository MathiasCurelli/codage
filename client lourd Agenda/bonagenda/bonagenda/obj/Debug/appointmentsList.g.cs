﻿#pragma checksum "..\..\appointmentsList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32C5A78C6E5440484EAA06BDDF48F2BF88E1DB9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using bonagenda;


namespace bonagenda {
    
    
    /// <summary>
    /// appointmentsList
    /// </summary>
    public partial class appointmentsList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid appointmentDataGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn dateHourColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn idBrokerColumn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn idCustomerColumn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn subjectColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changeDateAppointment;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox dropDownListCustomersChange;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox dropDownListBrokersChange;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changeSubjectAppointment;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\appointmentsList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock idAppointmentTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/bonagenda;component/appointmentslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\appointmentsList.xaml"
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
            
            #line 9 "..\..\appointmentsList.xaml"
            ((bonagenda.appointmentsList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.SaveAppointment_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.appointmentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.dateHourColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 4:
            this.idBrokerColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.idCustomerColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.subjectColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.changeDateAppointment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dropDownListCustomersChange = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.dropDownListBrokersChange = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.changeSubjectAppointment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 35 "..\..\appointmentsList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ModifyAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 36 "..\..\appointmentsList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.idAppointmentTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
