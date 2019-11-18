using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.inventory.service.wop{
	
	
	
	
	
	public class InventoryFlow {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transactionId_;
		
		///<summary>
		/// 操作类型
		///</summary>
		
		private string actionType_;
		
		///<summary>
		/// 仓库编码（大仓）
		///</summary>
		
		private string warehouseCode_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// PO单号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 库存类型
		/// @sampleValue stockProps 3PL
		///</summary>
		
		private string stockProps_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private string disabilityLevel_;
		
		///<summary>
		/// 是否可售 0-不可售 1-可售
		///</summary>
		
		private int? salableState_;
		
		///<summary>
		/// 库存调整数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 业务时间 格式：yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string actionTime_;
		
		///<summary>
		/// 单号
		///</summary>
		
		private string billNo_;
		
		public string GetTransactionId(){
			return this.transactionId_;
		}
		
		public void SetTransactionId(string value){
			this.transactionId_ = value;
		}
		public string GetActionType(){
			return this.actionType_;
		}
		
		public void SetActionType(string value){
			this.actionType_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public string GetStockProps(){
			return this.stockProps_;
		}
		
		public void SetStockProps(string value){
			this.stockProps_ = value;
		}
		public string GetDisabilityLevel(){
			return this.disabilityLevel_;
		}
		
		public void SetDisabilityLevel(string value){
			this.disabilityLevel_ = value;
		}
		public int? GetSalableState(){
			return this.salableState_;
		}
		
		public void SetSalableState(int? value){
			this.salableState_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public string GetActionTime(){
			return this.actionTime_;
		}
		
		public void SetActionTime(string value){
			this.actionTime_ = value;
		}
		public string GetBillNo(){
			return this.billNo_;
		}
		
		public void SetBillNo(string value){
			this.billNo_ = value;
		}
		
	}
	
}