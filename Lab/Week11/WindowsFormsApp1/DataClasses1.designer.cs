#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Week11")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPelanggan(Pelanggan instance);
    partial void UpdatePelanggan(Pelanggan instance);
    partial void DeletePelanggan(Pelanggan instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.Week11ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Pelanggan> Pelanggans
		{
			get
			{
				return this.GetTable<Pelanggan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pelanggan")]
	public partial class Pelanggan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kode;
		
		private string _nama;
		
		private string _alamat;
		
		private System.Nullable<decimal> _umur;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkodeChanging(string value);
    partial void OnkodeChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnalamatChanging(string value);
    partial void OnalamatChanged();
    partial void OnumurChanging(System.Nullable<decimal> value);
    partial void OnumurChanged();
    #endregion
		
		public Pelanggan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kode", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string kode
		{
			get
			{
				return this._kode;
			}
			set
			{
				if ((this._kode != value))
				{
					this.OnkodeChanging(value);
					this.SendPropertyChanging();
					this._kode = value;
					this.SendPropertyChanged("kode");
					this.OnkodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="NVarChar(50)")]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alamat", DbType="NVarChar(50)")]
		public string alamat
		{
			get
			{
				return this._alamat;
			}
			set
			{
				if ((this._alamat != value))
				{
					this.OnalamatChanging(value);
					this.SendPropertyChanging();
					this._alamat = value;
					this.SendPropertyChanged("alamat");
					this.OnalamatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_umur", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> umur
		{
			get
			{
				return this._umur;
			}
			set
			{
				if ((this._umur != value))
				{
					this.OnumurChanging(value);
					this.SendPropertyChanging();
					this._umur = value;
					this.SendPropertyChanged("umur");
					this.OnumurChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
