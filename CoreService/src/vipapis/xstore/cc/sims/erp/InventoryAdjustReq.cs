using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.sims.erp{
	
	
	
	
	
	public class InventoryAdjustReq {
		
		///<summary>
		/// 业务流水号 最高32位- 要全局唯一，用来保证幂等性
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 中台的商品条码
		///</summary>
		
		private string xlsBarcode_;
		
		///<summary>
		/// 中台门店编码-需要去主数据检查是否存在
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 库存调整业务操作类型:http://wiki.corp.vipshop.com/pages/viewpage.action?pageId=699637301
		///</summary>
		
		private int? bizReceiptType_;
		
		///<summary>
		/// 库存调整的业务单据号
		///</summary>
		
		private string bizReceiptCode_;
		
		///<summary>
		/// 库存调整数量(必须大于0)
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 业务操作时间,13位毫秒
		///</summary>
		
		private long? bizTime_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string optUser_;
		
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public string GetXlsBarcode(){
			return this.xlsBarcode_;
		}
		
		public void SetXlsBarcode(string value){
			this.xlsBarcode_ = value;
		}
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
		}
		public int? GetBizReceiptType(){
			return this.bizReceiptType_;
		}
		
		public void SetBizReceiptType(int? value){
			this.bizReceiptType_ = value;
		}
		public string GetBizReceiptCode(){
			return this.bizReceiptCode_;
		}
		
		public void SetBizReceiptCode(string value){
			this.bizReceiptCode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public long? GetBizTime(){
			return this.bizTime_;
		}
		
		public void SetBizTime(long? value){
			this.bizTime_ = value;
		}
		public string GetOptUser(){
			return this.optUser_;
		}
		
		public void SetOptUser(string value){
			this.optUser_ = value;
		}
		
	}
	
}