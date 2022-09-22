﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _00000033360_FarhanRaihan_AL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbMahasiswa")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEnrollment(Enrollment instance);
    partial void UpdateEnrollment(Enrollment instance);
    partial void DeleteEnrollment(Enrollment instance);
    partial void InsertMahasiswa(Mahasiswa instance);
    partial void UpdateMahasiswa(Mahasiswa instance);
    partial void DeleteMahasiswa(Mahasiswa instance);
    partial void InsertMatakuliah(Matakuliah instance);
    partial void UpdateMatakuliah(Matakuliah instance);
    partial void DeleteMatakuliah(Matakuliah instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::_00000033360_FarhanRaihan_AL.Properties.Settings.Default.dbMahasiswaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Enrollment> Enrollments
		{
			get
			{
				return this.GetTable<Enrollment>();
			}
		}
		
		public System.Data.Linq.Table<Mahasiswa> Mahasiswas
		{
			get
			{
				return this.GetTable<Mahasiswa>();
			}
		}
		
		public System.Data.Linq.Table<Matakuliah> Matakuliahs
		{
			get
			{
				return this.GetTable<Matakuliah>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enrollment")]
	public partial class Enrollment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_enrollment;
		
		private string _kode_matkul;
		
		private string _nim;
		
		private EntityRef<Mahasiswa> _Mahasiswa;
		
		private EntityRef<Matakuliah> _Matakuliah;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_enrollmentChanging(string value);
    partial void Onid_enrollmentChanged();
    partial void Onkode_matkulChanging(string value);
    partial void Onkode_matkulChanged();
    partial void OnnimChanging(string value);
    partial void OnnimChanged();
    #endregion
		
		public Enrollment()
		{
			this._Mahasiswa = default(EntityRef<Mahasiswa>);
			this._Matakuliah = default(EntityRef<Matakuliah>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_enrollment", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_enrollment
		{
			get
			{
				return this._id_enrollment;
			}
			set
			{
				if ((this._id_enrollment != value))
				{
					this.Onid_enrollmentChanging(value);
					this.SendPropertyChanging();
					this._id_enrollment = value;
					this.SendPropertyChanged("id_enrollment");
					this.Onid_enrollmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kode_matkul", DbType="VarChar(50)")]
		public string kode_matkul
		{
			get
			{
				return this._kode_matkul;
			}
			set
			{
				if ((this._kode_matkul != value))
				{
					if (this._Matakuliah.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onkode_matkulChanging(value);
					this.SendPropertyChanging();
					this._kode_matkul = value;
					this.SendPropertyChanged("kode_matkul");
					this.Onkode_matkulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nim", DbType="Char(11)")]
		public string nim
		{
			get
			{
				return this._nim;
			}
			set
			{
				if ((this._nim != value))
				{
					if (this._Mahasiswa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnnimChanging(value);
					this.SendPropertyChanging();
					this._nim = value;
					this.SendPropertyChanged("nim");
					this.OnnimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mahasiswa_Enrollment", Storage="_Mahasiswa", ThisKey="nim", OtherKey="nim", IsForeignKey=true)]
		public Mahasiswa Mahasiswa
		{
			get
			{
				return this._Mahasiswa.Entity;
			}
			set
			{
				Mahasiswa previousValue = this._Mahasiswa.Entity;
				if (((previousValue != value) 
							|| (this._Mahasiswa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mahasiswa.Entity = null;
						previousValue.Enrollments.Remove(this);
					}
					this._Mahasiswa.Entity = value;
					if ((value != null))
					{
						value.Enrollments.Add(this);
						this._nim = value.nim;
					}
					else
					{
						this._nim = default(string);
					}
					this.SendPropertyChanged("Mahasiswa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Matakuliah_Enrollment", Storage="_Matakuliah", ThisKey="kode_matkul", OtherKey="kode_matkul", IsForeignKey=true)]
		public Matakuliah Matakuliah
		{
			get
			{
				return this._Matakuliah.Entity;
			}
			set
			{
				Matakuliah previousValue = this._Matakuliah.Entity;
				if (((previousValue != value) 
							|| (this._Matakuliah.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Matakuliah.Entity = null;
						previousValue.Enrollments.Remove(this);
					}
					this._Matakuliah.Entity = value;
					if ((value != null))
					{
						value.Enrollments.Add(this);
						this._kode_matkul = value.kode_matkul;
					}
					else
					{
						this._kode_matkul = default(string);
					}
					this.SendPropertyChanged("Matakuliah");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mahasiswa")]
	public partial class Mahasiswa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _nim;
		
		private string _nama;
		
		private System.Nullable<int> _angkatan;
		
		private string _fakultas;
		
		private string _prodi;
		
		private EntitySet<Enrollment> _Enrollments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnimChanging(string value);
    partial void OnnimChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnangkatanChanging(System.Nullable<int> value);
    partial void OnangkatanChanged();
    partial void OnfakultasChanging(string value);
    partial void OnfakultasChanged();
    partial void OnprodiChanging(string value);
    partial void OnprodiChanged();
    #endregion
		
		public Mahasiswa()
		{
			this._Enrollments = new EntitySet<Enrollment>(new Action<Enrollment>(this.attach_Enrollments), new Action<Enrollment>(this.detach_Enrollments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nim", DbType="Char(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string nim
		{
			get
			{
				return this._nim;
			}
			set
			{
				if ((this._nim != value))
				{
					this.OnnimChanging(value);
					this.SendPropertyChanging();
					this._nim = value;
					this.SendPropertyChanged("nim");
					this.OnnimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_angkatan", DbType="Int")]
		public System.Nullable<int> angkatan
		{
			get
			{
				return this._angkatan;
			}
			set
			{
				if ((this._angkatan != value))
				{
					this.OnangkatanChanging(value);
					this.SendPropertyChanging();
					this._angkatan = value;
					this.SendPropertyChanged("angkatan");
					this.OnangkatanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fakultas", DbType="VarChar(50)")]
		public string fakultas
		{
			get
			{
				return this._fakultas;
			}
			set
			{
				if ((this._fakultas != value))
				{
					this.OnfakultasChanging(value);
					this.SendPropertyChanging();
					this._fakultas = value;
					this.SendPropertyChanged("fakultas");
					this.OnfakultasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prodi", DbType="VarChar(50)")]
		public string prodi
		{
			get
			{
				return this._prodi;
			}
			set
			{
				if ((this._prodi != value))
				{
					this.OnprodiChanging(value);
					this.SendPropertyChanging();
					this._prodi = value;
					this.SendPropertyChanged("prodi");
					this.OnprodiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mahasiswa_Enrollment", Storage="_Enrollments", ThisKey="nim", OtherKey="nim")]
		public EntitySet<Enrollment> Enrollments
		{
			get
			{
				return this._Enrollments;
			}
			set
			{
				this._Enrollments.Assign(value);
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
		
		private void attach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Mahasiswa = this;
		}
		
		private void detach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Mahasiswa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Matakuliah")]
	public partial class Matakuliah : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kode_matkul;
		
		private string _nama_matkul;
		
		private EntitySet<Enrollment> _Enrollments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onkode_matkulChanging(string value);
    partial void Onkode_matkulChanged();
    partial void Onnama_matkulChanging(string value);
    partial void Onnama_matkulChanged();
    #endregion
		
		public Matakuliah()
		{
			this._Enrollments = new EntitySet<Enrollment>(new Action<Enrollment>(this.attach_Enrollments), new Action<Enrollment>(this.detach_Enrollments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kode_matkul", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string kode_matkul
		{
			get
			{
				return this._kode_matkul;
			}
			set
			{
				if ((this._kode_matkul != value))
				{
					this.Onkode_matkulChanging(value);
					this.SendPropertyChanging();
					this._kode_matkul = value;
					this.SendPropertyChanged("kode_matkul");
					this.Onkode_matkulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_matkul", DbType="VarChar(100)")]
		public string nama_matkul
		{
			get
			{
				return this._nama_matkul;
			}
			set
			{
				if ((this._nama_matkul != value))
				{
					this.Onnama_matkulChanging(value);
					this.SendPropertyChanging();
					this._nama_matkul = value;
					this.SendPropertyChanged("nama_matkul");
					this.Onnama_matkulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Matakuliah_Enrollment", Storage="_Enrollments", ThisKey="kode_matkul", OtherKey="kode_matkul")]
		public EntitySet<Enrollment> Enrollments
		{
			get
			{
				return this._Enrollments;
			}
			set
			{
				this._Enrollments.Assign(value);
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
		
		private void attach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Matakuliah = this;
		}
		
		private void detach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Matakuliah = null;
		}
	}
}
#pragma warning restore 1591
