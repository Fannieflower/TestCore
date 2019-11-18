using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.warehouse.api{
	
	
	
	
	
	public class Warehouse {
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouseCode_;
		
		///<summary>
		/// 仓库名称
		///</summary>
		
		private string warehouseName_;
		
		///<summary>
		/// 安全库存
		///</summary>
		
		private int? safeQuantity_;
		
		///<summary>
		/// 地址
		///</summary>
		
		private com.vip.vop.vcloud.warehouse.api.Address address_;
		
		///<summary>
		/// 是否为虚拟仓库，1=虚拟仓库，0=实体仓库
		///</summary>
		
		private int? isVirtual_;
		
		///<summary>
		/// 描述
		///</summary>
		
		private string description_;
		
		///<summary>
		/// 唯品会门店编码
		///</summary>
		
		private string vipStoreSn_;
		
		///<summary>
		/// 收件联系电话
		///</summary>
		
		private string receiverMobile_;
		
		///<summary>
		/// 收件联系人
		///</summary>
		
		private string receiverName_;
		
		///<summary>
		/// 发件联系电话
		///</summary>
		
		private string senderMobile_;
		
		///<summary>
		/// 发件联系人
		///</summary>
		
		private string senderName_;
		
		///<summary>
		/// 仓库优先级
		///</summary>
		
		private int? priority_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		public string GetWarehouseName(){
			return this.warehouseName_;
		}
		
		public void SetWarehouseName(string value){
			this.warehouseName_ = value;
		}
		public int? GetSafeQuantity(){
			return this.safeQuantity_;
		}
		
		public void SetSafeQuantity(int? value){
			this.safeQuantity_ = value;
		}
		public com.vip.vop.vcloud.warehouse.api.Address GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(com.vip.vop.vcloud.warehouse.api.Address value){
			this.address_ = value;
		}
		public int? GetIsVirtual(){
			return this.isVirtual_;
		}
		
		public void SetIsVirtual(int? value){
			this.isVirtual_ = value;
		}
		public string GetDescription(){
			return this.description_;
		}
		
		public void SetDescription(string value){
			this.description_ = value;
		}
		public string GetVipStoreSn(){
			return this.vipStoreSn_;
		}
		
		public void SetVipStoreSn(string value){
			this.vipStoreSn_ = value;
		}
		public string GetReceiverMobile(){
			return this.receiverMobile_;
		}
		
		public void SetReceiverMobile(string value){
			this.receiverMobile_ = value;
		}
		public string GetReceiverName(){
			return this.receiverName_;
		}
		
		public void SetReceiverName(string value){
			this.receiverName_ = value;
		}
		public string GetSenderMobile(){
			return this.senderMobile_;
		}
		
		public void SetSenderMobile(string value){
			this.senderMobile_ = value;
		}
		public string GetSenderName(){
			return this.senderName_;
		}
		
		public void SetSenderName(string value){
			this.senderName_ = value;
		}
		public int? GetPriority(){
			return this.priority_;
		}
		
		public void SetPriority(int? value){
			this.priority_ = value;
		}
		
	}
	
}