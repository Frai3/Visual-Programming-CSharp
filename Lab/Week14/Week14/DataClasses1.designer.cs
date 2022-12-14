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

namespace Week14
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Week14")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertpelanggan(pelanggan instance);
    partial void Updatepelanggan(pelanggan instance);
    partial void Deletepelanggan(pelanggan instance);
    partial void Insertpemasok(pemasok instance);
    partial void Updatepemasok(pemasok instance);
    partial void Deletepemasok(pemasok instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Week14.Properties.Settings.Default.Week14ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<pelanggan> pelanggans
		{
			get
			{
				return this.GetTable<pelanggan>();
			}
		}
		
		public System.Data.Linq.Table<pemasok> pemasoks
		{
			get
			{
				return this.GetTable<pemasok>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pelanggan")]
	public partial class pelanggan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_pelanggan;
		
		private string _nama_pelanggan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pelangganChanging(string value);
    partial void Onid_pelangganChanged();
    partial void Onnama_pelangganChanging(string value);
    partial void Onnama_pelangganChanged();
    #endregion
		
		public pelanggan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pelanggan", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_pelanggan
		{
			get
			{
				return this._id_pelanggan;
			}
			set
			{
				if ((this._id_pelanggan != value))
				{
					this.Onid_pelangganChanging(value);
					this.SendPropertyChanging();
					this._id_pelanggan = value;
					this.SendPropertyChanged("id_pelanggan");
					this.Onid_pelangganChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_pelanggan", DbType="VarChar(50)")]
		public string nama_pelanggan
		{
			get
			{
				return this._nama_pelanggan;
			}
			set
			{
				if ((this._nama_pelanggan != value))
				{
					this.Onnama_pelangganChanging(value);
					this.SendPropertyChanging();
					this._nama_pelanggan = value;
					this.SendPropertyChanged("nama_pelanggan");
					this.Onnama_pelangganChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pemasok")]
	public partial class pemasok : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_pemasok;
		
		private string _nama_pemasok;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pemasokChanging(string value);
    partial void Onid_pemasokChanged();
    partial void Onnama_pemasokChanging(string value);
    partial void Onnama_pemasokChanged();
    #endregion
		
		public pemasok()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pemasok", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_pemasok
		{
			get
			{
				return this._id_pemasok;
			}
			set
			{
				if ((this._id_pemasok != value))
				{
					this.Onid_pemasokChanging(value);
					this.SendPropertyChanging();
					this._id_pemasok = value;
					this.SendPropertyChanged("id_pemasok");
					this.Onid_pemasokChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_pemasok", DbType="VarChar(50)")]
		public string nama_pemasok
		{
			get
			{
				return this._nama_pemasok;
			}
			set
			{
				if ((this._nama_pemasok != value))
				{
					this.Onnama_pemasokChanging(value);
					this.SendPropertyChanging();
					this._nama_pemasok = value;
					this.SendPropertyChanged("nama_pemasok");
					this.Onnama_pemasokChanged();
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
