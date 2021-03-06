//
// Class	:	PURPurchaseReturnLinePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:14 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class PURPurchaseReturnLinePrimaryKey
	{

	#region Class Level Variables
			private int?           	_purchaseReturnLineIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public PURPurchaseReturnLinePrimaryKey(int? purchaseReturnLineID) 
		{
	
			
			this._purchaseReturnLineIDNonDefault = purchaseReturnLineID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? PurchaseReturnLineID
		{
			get 
			{ 
				return _purchaseReturnLineIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnLineIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:14 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("PurchaseReturnLineID",_purchaseReturnLineIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
