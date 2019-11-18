using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	
	
	public class ErrorSkuModel {
		
		///<summary>
		/// po单号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private string grade_;
		
		///<summary>
		/// 错误码
		///</summary>
		
		private string errorCode_;
		
		///<summary>
		/// 错误原因
		///</summary>
		
		private string errorMsg_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouseCode_;
		
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetGrade(){
			return this.grade_;
		}
		
		public void SetGrade(string value){
			this.grade_ = value;
		}
		public string GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(string value){
			this.errorCode_ = value;
		}
		public string GetErrorMsg(){
			return this.errorMsg_;
		}
		
		public void SetErrorMsg(string value){
			this.errorMsg_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		
	}
	
}