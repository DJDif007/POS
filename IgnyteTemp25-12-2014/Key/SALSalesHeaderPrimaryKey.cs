//
// Class	:	SALSalesHeaderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:46:02 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace DAPOS
{
	public class SALSalesHeaderPrimaryKey
	{

	#region Class Level Variables
			private int?           	_salesHeaderIDNonDefault 	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public SALSalesHeaderPrimaryKey(int? salesHeaderID) 
		{
	
			
			this._salesHeaderIDNonDefault = salesHeaderID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "SalesHeaderID" field.  Mandatory.
		/// </summary>
		public int? SalesHeaderID
		{
			get 
			{ 
				return _salesHeaderIDNonDefault;
			}
			set 
			{
			
				_salesHeaderIDNonDefault = value; 
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
		/// DLGenerator			12/26/2014 2:46:02 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("SalesHeaderID",_salesHeaderIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
