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

namespace GUISupermarket
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SUPERMARKETDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertPayment(Payment instance);
    partial void UpdatePayment(Payment instance);
    partial void DeletePayment(Payment instance);
    partial void InsertPurchase(Purchase instance);
    partial void UpdatePurchase(Purchase instance);
    partial void DeletePurchase(Purchase instance);
    partial void InsertPurchase_Item(Purchase_Item instance);
    partial void UpdatePurchase_Item(Purchase_Item instance);
    partial void DeletePurchase_Item(Purchase_Item instance);
    partial void InsertUserAccount(UserAccount instance);
    partial void UpdateUserAccount(UserAccount instance);
    partial void DeleteUserAccount(UserAccount instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::GUISupermarket.Properties.Settings.Default.SUPERMARKETDBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Payment> Payments
		{
			get
			{
				return this.GetTable<Payment>();
			}
		}
		
		public System.Data.Linq.Table<Purchase> Purchases
		{
			get
			{
				return this.GetTable<Purchase>();
			}
		}
		
		public System.Data.Linq.Table<Purchase_Item> Purchase_Items
		{
			get
			{
				return this.GetTable<Purchase_Item>();
			}
		}
		
		public System.Data.Linq.Table<UserAccount> UserAccounts
		{
			get
			{
				return this.GetTable<UserAccount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _itemID;
		
		private string _itemDesc;
		
		private decimal _price;
		
		private EntitySet<Purchase_Item> _Purchase_Items;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnitemIDChanging(int value);
    partial void OnitemIDChanged();
    partial void OnitemDescChanging(string value);
    partial void OnitemDescChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public Item()
		{
			this._Purchase_Items = new EntitySet<Purchase_Item>(new Action<Purchase_Item>(this.attach_Purchase_Items), new Action<Purchase_Item>(this.detach_Purchase_Items));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int itemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((this._itemID != value))
				{
					this.OnitemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("itemID");
					this.OnitemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemDesc", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string itemDesc
		{
			get
			{
				return this._itemDesc;
			}
			set
			{
				if ((this._itemDesc != value))
				{
					this.OnitemDescChanging(value);
					this.SendPropertyChanging();
					this._itemDesc = value;
					this.SendPropertyChanged("itemDesc");
					this.OnitemDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(5,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase_Item", Storage="_Purchase_Items", ThisKey="itemID", OtherKey="itemID")]
		public EntitySet<Purchase_Item> Purchase_Items
		{
			get
			{
				return this._Purchase_Items;
			}
			set
			{
				this._Purchase_Items.Assign(value);
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
		
		private void attach_Purchase_Items(Purchase_Item entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_Purchase_Items(Purchase_Item entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payment")]
	public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _paymentID;
		
		private System.Nullable<decimal> _amount;
		
		private string _username;
		
		private EntityRef<UserAccount> _UserAccount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpaymentIDChanging(int value);
    partial void OnpaymentIDChanged();
    partial void OnamountChanging(System.Nullable<decimal> value);
    partial void OnamountChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    #endregion
		
		public Payment()
		{
			this._UserAccount = default(EntityRef<UserAccount>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paymentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int paymentID
		{
			get
			{
				return this._paymentID;
			}
			set
			{
				if ((this._paymentID != value))
				{
					this.OnpaymentIDChanging(value);
					this.SendPropertyChanging();
					this._paymentID = value;
					this.SendPropertyChanged("paymentID");
					this.OnpaymentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(10)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					if (this._UserAccount.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserAccount_Payment", Storage="_UserAccount", ThisKey="username", OtherKey="username", IsForeignKey=true)]
		public UserAccount UserAccount
		{
			get
			{
				return this._UserAccount.Entity;
			}
			set
			{
				UserAccount previousValue = this._UserAccount.Entity;
				if (((previousValue != value) 
							|| (this._UserAccount.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserAccount.Entity = null;
						previousValue.Payments.Remove(this);
					}
					this._UserAccount.Entity = value;
					if ((value != null))
					{
						value.Payments.Add(this);
						this._username = value.username;
					}
					else
					{
						this._username = default(string);
					}
					this.SendPropertyChanged("UserAccount");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchase")]
	public partial class Purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseID;
		
		private string _username;
		
		private System.Nullable<int> _numItems;
		
		private System.Nullable<decimal> _totalPrice;
		
		private System.Nullable<System.DateTime> _purchaseDate;
		
		private EntitySet<Purchase_Item> _Purchase_Items;
		
		private EntityRef<UserAccount> _UserAccount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseIDChanging(int value);
    partial void OnPurchaseIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnnumItemsChanging(System.Nullable<int> value);
    partial void OnnumItemsChanged();
    partial void OntotalPriceChanging(System.Nullable<decimal> value);
    partial void OntotalPriceChanged();
    partial void OnpurchaseDateChanging(System.Nullable<System.DateTime> value);
    partial void OnpurchaseDateChanged();
    #endregion
		
		public Purchase()
		{
			this._Purchase_Items = new EntitySet<Purchase_Item>(new Action<Purchase_Item>(this.attach_Purchase_Items), new Action<Purchase_Item>(this.detach_Purchase_Items));
			this._UserAccount = default(EntityRef<UserAccount>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(10)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					if (this._UserAccount.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numItems", DbType="Int")]
		public System.Nullable<int> numItems
		{
			get
			{
				return this._numItems;
			}
			set
			{
				if ((this._numItems != value))
				{
					this.OnnumItemsChanging(value);
					this.SendPropertyChanging();
					this._numItems = value;
					this.SendPropertyChanged("numItems");
					this.OnnumItemsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalPrice", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> totalPrice
		{
			get
			{
				return this._totalPrice;
			}
			set
			{
				if ((this._totalPrice != value))
				{
					this.OntotalPriceChanging(value);
					this.SendPropertyChanging();
					this._totalPrice = value;
					this.SendPropertyChanged("totalPrice");
					this.OntotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaseDate", DbType="Date")]
		public System.Nullable<System.DateTime> purchaseDate
		{
			get
			{
				return this._purchaseDate;
			}
			set
			{
				if ((this._purchaseDate != value))
				{
					this.OnpurchaseDateChanging(value);
					this.SendPropertyChanging();
					this._purchaseDate = value;
					this.SendPropertyChanged("purchaseDate");
					this.OnpurchaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Purchase_Purchase_Item", Storage="_Purchase_Items", ThisKey="PurchaseID", OtherKey="purchaseID")]
		public EntitySet<Purchase_Item> Purchase_Items
		{
			get
			{
				return this._Purchase_Items;
			}
			set
			{
				this._Purchase_Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserAccount_Purchase", Storage="_UserAccount", ThisKey="username", OtherKey="username", IsForeignKey=true)]
		public UserAccount UserAccount
		{
			get
			{
				return this._UserAccount.Entity;
			}
			set
			{
				UserAccount previousValue = this._UserAccount.Entity;
				if (((previousValue != value) 
							|| (this._UserAccount.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserAccount.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._UserAccount.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._username = value.username;
					}
					else
					{
						this._username = default(string);
					}
					this.SendPropertyChanged("UserAccount");
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
		
		private void attach_Purchase_Items(Purchase_Item entity)
		{
			this.SendPropertyChanging();
			entity.Purchase = this;
		}
		
		private void detach_Purchase_Items(Purchase_Item entity)
		{
			this.SendPropertyChanging();
			entity.Purchase = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchase_Item")]
	public partial class Purchase_Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _purchaseID;
		
		private int _itemID;
		
		private int _amount;
		
		private EntityRef<Item> _Item;
		
		private EntityRef<Purchase> _Purchase;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpurchaseIDChanging(int value);
    partial void OnpurchaseIDChanged();
    partial void OnitemIDChanging(int value);
    partial void OnitemIDChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    #endregion
		
		public Purchase_Item()
		{
			this._Item = default(EntityRef<Item>);
			this._Purchase = default(EntityRef<Purchase>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int purchaseID
		{
			get
			{
				return this._purchaseID;
			}
			set
			{
				if ((this._purchaseID != value))
				{
					if (this._Purchase.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._purchaseID = value;
					this.SendPropertyChanged("purchaseID");
					this.OnpurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int itemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((this._itemID != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnitemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("itemID");
					this.OnitemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase_Item", Storage="_Item", ThisKey="itemID", OtherKey="itemID", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.Purchase_Items.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.Purchase_Items.Add(this);
						this._itemID = value.itemID;
					}
					else
					{
						this._itemID = default(int);
					}
					this.SendPropertyChanged("Item");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Purchase_Purchase_Item", Storage="_Purchase", ThisKey="purchaseID", OtherKey="PurchaseID", IsForeignKey=true)]
		public Purchase Purchase
		{
			get
			{
				return this._Purchase.Entity;
			}
			set
			{
				Purchase previousValue = this._Purchase.Entity;
				if (((previousValue != value) 
							|| (this._Purchase.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Purchase.Entity = null;
						previousValue.Purchase_Items.Remove(this);
					}
					this._Purchase.Entity = value;
					if ((value != null))
					{
						value.Purchase_Items.Add(this);
						this._purchaseID = value.PurchaseID;
					}
					else
					{
						this._purchaseID = default(int);
					}
					this.SendPropertyChanged("Purchase");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserAccount")]
	public partial class UserAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _pswd;
		
		private System.Nullable<decimal> _balance;
		
		private EntitySet<Payment> _Payments;
		
		private EntitySet<Purchase> _Purchases;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpswdChanging(string value);
    partial void OnpswdChanged();
    partial void OnbalanceChanging(System.Nullable<decimal> value);
    partial void OnbalanceChanged();
    #endregion
		
		public UserAccount()
		{
			this._Payments = new EntitySet<Payment>(new Action<Payment>(this.attach_Payments), new Action<Payment>(this.detach_Payments));
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pswd", DbType="Char(8)")]
		public string pswd
		{
			get
			{
				return this._pswd;
			}
			set
			{
				if ((this._pswd != value))
				{
					this.OnpswdChanging(value);
					this.SendPropertyChanging();
					this._pswd = value;
					this.SendPropertyChanged("pswd");
					this.OnpswdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserAccount_Payment", Storage="_Payments", ThisKey="username", OtherKey="username")]
		public EntitySet<Payment> Payments
		{
			get
			{
				return this._Payments;
			}
			set
			{
				this._Payments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserAccount_Purchase", Storage="_Purchases", ThisKey="username", OtherKey="username")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
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
		
		private void attach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.UserAccount = this;
		}
		
		private void detach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.UserAccount = null;
		}
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.UserAccount = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.UserAccount = null;
		}
	}
}
#pragma warning restore 1591
