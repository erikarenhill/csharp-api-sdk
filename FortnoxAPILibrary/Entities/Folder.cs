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
	public partial class Folder
	{

		private string emailField;

		private Files filesField;

		private Folders foldersField;

		private string idField;

		private string nameField;

		private string urlField;

		/// <remarks/>
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}

		/// <remarks/>
		public Files Files
		{
			get
			{
				return this.filesField;
			}
			set
			{
				this.filesField = value;
			}
		}

		/// <remarks/>
		public Folders Folders
		{
			get
			{
				return this.foldersField;
			}
			set
			{
				this.foldersField = value;
			}
		}

		/// <remarks/>
		public string Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class Files
	{

		private List<File> fileField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("File")]
		public List<File> File
		{
			get
			{
				return this.fileField;
			}
			set
			{
				this.fileField = value;
			}
		}

	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class File
	{

		private string commentsField;

		private string idField;

		private string nameField;

		private string pathField;

		private string sizeField;

		private string urlField;

		/// <remarks/>
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}

		/// <remarks/>
		public string Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		/// <remarks/>
		public string Size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class Folders
	{

		private List<FoldersFolder> folderField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Folder")]
		public List<FoldersFolder> Folder
		{
			get
			{
				return this.folderField;
			}
			set
			{
				this.folderField = value;
			}
		}

	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class FoldersFolder
	{

		private string idField;

		private string nameField;

		private string urlField;

		/// <remarks/>
		public string Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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