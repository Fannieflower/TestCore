using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.rfid.api{
	
	
	
	
	
	public class RfidEpcStatusResponse {
		
		///<summary>
		/// 老条码
		///</summary>
		
		private string oldBarcode_;
		
		///<summary>
		/// 新barcode
		///</summary>
		
		private string newBarcode_;
		
		///<summary>
		/// 主体
		///</summary>
		
		private string owner_;
		
		///<summary>
		/// 外部码
		///</summary>
		
		private string extCode_;
		
		///<summary>
		/// epc
		///</summary>
		
		private string epc_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		public string GetOldBarcode(){
			return this.oldBarcode_;
		}
		
		public void SetOldBarcode(string value){
			this.oldBarcode_ = value;
		}
		public string GetNewBarcode(){
			return this.newBarcode_;
		}
		
		public void SetNewBarcode(string value){
			this.newBarcode_ = value;
		}
		public string GetOwner(){
			return this.owner_;
		}
		
		public void SetOwner(string value){
			this.owner_ = value;
		}
		public string GetExtCode(){
			return this.extCode_;
		}
		
		public void SetExtCode(string value){
			this.extCode_ = value;
		}
		public string GetEpc(){
			return this.epc_;
		}
		
		public void SetEpc(string value){
			this.epc_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		
	}
	
}