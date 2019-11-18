using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class WarehouseInventoryLog {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 仓库id
		///</summary>
		
		private long? warehouseId_;
		
		///<summary>
		/// 仓库名称
		///</summary>
		
		private string warehouseName_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 数据源
		///</summary>
		
		private int? source_;
		
		///<summary>
		/// 是否全量，0：否，1：是
		///</summary>
		
		private int? isFull_;
		
		///<summary>
		/// 更新前库存数量
		///</summary>
		
		private int? currentQuantity_;
		
		///<summary>
		/// 更新数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 更新后库存数量
		///</summary>
		
		private int? postQuantity_;
		
		///<summary>
		/// skuId
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string productName_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string spu_;
		
		///<summary>
		/// 状态, 0：失败，1：成功
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string message_;
		
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public long? GetWarehouseId(){
			return this.warehouseId_;
		}
		
		public void SetWarehouseId(long? value){
			this.warehouseId_ = value;
		}
		public string GetWarehouseName(){
			return this.warehouseName_;
		}
		
		public void SetWarehouseName(string value){
			this.warehouseName_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public int? GetSource(){
			return this.source_;
		}
		
		public void SetSource(int? value){
			this.source_ = value;
		}
		public int? GetIsFull(){
			return this.isFull_;
		}
		
		public void SetIsFull(int? value){
			this.isFull_ = value;
		}
		public int? GetCurrentQuantity(){
			return this.currentQuantity_;
		}
		
		public void SetCurrentQuantity(int? value){
			this.currentQuantity_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public int? GetPostQuantity(){
			return this.postQuantity_;
		}
		
		public void SetPostQuantity(int? value){
			this.postQuantity_ = value;
		}
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetProductName(){
			return this.productName_;
		}
		
		public void SetProductName(string value){
			this.productName_ = value;
		}
		public string GetSpu(){
			return this.spu_;
		}
		
		public void SetSpu(string value){
			this.spu_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}