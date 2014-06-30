//
// System.Data.SqlClient.SqlException
//
// Authors:
//	Konstantin Triger <kostat@mainsoft.com>
//	Boris Kirzner <borisk@mainsoft.com>
//	
// (C) 2005 Mainsoft Corporation (http://www.mainsoft.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Data.OracleClient {

	using java.sql;

	using System;
	using System.Data.ProviderBase;

	/**
	 * The exception that is thrown when SQL Server returns a warning or error.
	 * This class cannot be inherited.
	 */

	/*
	* CURRENT LIMITATIONS
	* 1. Constructor for serialization SqlException(SerializationInfo info, StreamingContext sc) 
	*    is not supported.
	* 2. Method "void GetObjectData(...,...)" is not supported (serialization)
	*/

	public sealed class OracleException : AbstractDbException {
		internal OracleException(Exception cause, OracleConnection connection) : base(cause, connection) {}

		internal OracleException(SQLException cause, OracleConnection connection) : base(cause, connection) {}

		internal OracleException(string message, SQLException cause, OracleConnection connection) : base(message, cause, connection) {}

		protected override AbstractDbErrorCollection DbErrors {
			get {
				return Errors;
			}
		}

        

		/**
		 * Gets the severity level of the error returned from the SQL Server .NET 
		 * Data Provider.
		 * @return severity level of the first error in the collection.
		 */
//		public byte Class {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].Class : (byte)0;
//			}
//		}

		/**
		 * Gets a collection of one or more SqlError objects that give detailed 
		 * information about exceptions generated by the SQL Server .NET Data Provider.
		 * @return collection of SqlError objects
		 */
		internal OracleErrorCollection Errors {
			get {
				return new OracleErrorCollection(_cause, _connection);
			}
		}

		public int Code {
			get { return DbErrorCode; }
		}

		/**
		 * Gets the line number within the Transact-SQL command batch or stored 
		 * procedure that generated the error.
		 * @return line number of the first error in the collection.
		 */
//		public int LineNumber {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].LineNumber : 0;
//			}
//		}

		/**
		 * Gets a number that identifies the type of error.
		 * @return number that identifies the type of first error in the collection
		 */
//		public int Number {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].Number : 0;
//			}
//		}

		/**
		 * Gets the name of the stored procedure or remote procedure call (RPC) 
		 * that generated the error.
		 * @return name of the stored procedure 
		 */
//		public String Procedure {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].Procedure : null;
//			}
//		}

		/**
		 * Gets the name of the computer running an instance of SQL Server 
		 * that generated the error.
		 * @return name of the computer where error generated
		 */
//		public String Server {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].Server : null;
//			}
//		}


		/**
		 * Gets a numeric error code from SQL Server that represents an error, 
		 * warning or "no data found" message. 
		 * @return numeric error code from SQL Server
		 */
//		public byte State {
//			get {
//				SqlErrorCollection errors = Errors;
//				return errors.Count > 0 ? errors[0].State : (byte)0;
//			}
//		}
	}
}