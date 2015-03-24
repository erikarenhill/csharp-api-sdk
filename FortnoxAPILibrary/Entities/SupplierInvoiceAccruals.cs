﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5472
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;
using FortnoxAPILibrary.Connectors;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class SupplierInvoiceAccruals
	{

		private List<SupplierInvoiceAccrualSubset> supplierInvoiceAccrualSubsetField;

		private string totalResourcesField;

		private string totalPagesField;

		private string currentPageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupplierInvoiceAccrualSubset")]
		public List<SupplierInvoiceAccrualSubset> SupplierInvoiceAccrualSubset
		{
			get
			{
				return this.supplierInvoiceAccrualSubsetField;
			}
			set
			{
				this.supplierInvoiceAccrualSubsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalResources
		{
			get
			{
				return this.totalResourcesField;
			}
			set
			{
				this.totalResourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalPages
		{
			get
			{
				return this.totalPagesField;
			}
			set
			{
				this.totalPagesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CurrentPage
		{
			get
			{
				return this.currentPageField;
			}
			set
			{
				this.currentPageField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class SupplierInvoiceAccrualSubset
	{

		private string descriptionField;

		private string invoiceNumberField;

		private SupplierInvoiceAccrualConnector.Period periodField;

		private string urlField;

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string InvoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}

		/// <remarks/>
		public SupplierInvoiceAccrualConnector.Period Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}