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
	public partial class ArticleFileConnection
	{

		private string fileIdField;

		private string articleNumberField;

		private string urlField;

		/// <remarks/>
		public string FileId
		{
			get
			{
				return this.fileIdField;
			}
			set
			{
				this.fileIdField = value;
			}
		}

		/// <remarks/>
		public string ArticleNumber
		{
			get
			{
				return this.articleNumberField;
			}
			set
			{
				this.articleNumberField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.ReadOnly(true)]
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