using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PurchaseOrder {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 出仓单号
		///</summary>
		
		private string delivery_no_;
		
		///<summary>
		/// 收货仓库名称
		///</summary>
		
		private string receive_warehouse_name_;
		
		///<summary>
		/// 收货仓库编码
		///</summary>
		
		private string receive_warehouse_code_;
		
		///<summary>
		/// 出仓时间
		///</summary>
		
		private System.DateTime? delivery_time_;
		
		///<summary>
		/// 采购类型，0=内采，1=外采
		///</summary>
		
		private int? purchase_type_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendor_code_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendor_name_;
		
		///<summary>
		/// 采购主体，xstorebuy,maxxbuy
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 退货地址
		///</summary>
		
		private vipapis.xstore.cc.bulkbuying.api.Address return_address_;
		
		///<summary>
		/// 采购员姓名
		///</summary>
		
		private string buyer_name_;
		
		///<summary>
		/// 是否鲸仓(0：非；1：是)
		///</summary>
		
		private byte? is_whale_warehouse_;
		
		///<summary>
		/// 收货类型(0：大仓收货，1：门店收货)
		///</summary>
		
		private byte? receiving_type_;
		
		///<summary>
		/// 货品类型（0=现货 1=囤货）
		///</summary>
		
		private int? goods_type_;
		
		///<summary>
		/// 可配货时间
		///</summary>
		
		private System.DateTime? distributable_goods_time_;
		
		///<summary>
		/// 合作模式(0=买断,1=代销)
		///</summary>
		
		private byte? cooperationMode_;
		
		///<summary>
		/// RFID打印模板，VIPSHOP不返回，VIPMAXX返回：VIPMAXX1=常规,VIPMAXX2=美妆
		///</summary>
		
		private string rfid_template_code_;
		
		///<summary>
		/// 是否越库，0：否，1：是
		///</summary>
		
		private string is_crossdock_;
		
		///<summary>
		/// 货主编码
		///</summary>
		
		private string owner_code_;
		
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public string GetDelivery_no(){
			return this.delivery_no_;
		}
		
		public void SetDelivery_no(string value){
			this.delivery_no_ = value;
		}
		public string GetReceive_warehouse_name(){
			return this.receive_warehouse_name_;
		}
		
		public void SetReceive_warehouse_name(string value){
			this.receive_warehouse_name_ = value;
		}
		public string GetReceive_warehouse_code(){
			return this.receive_warehouse_code_;
		}
		
		public void SetReceive_warehouse_code(string value){
			this.receive_warehouse_code_ = value;
		}
		public System.DateTime? GetDelivery_time(){
			return this.delivery_time_;
		}
		
		public void SetDelivery_time(System.DateTime? value){
			this.delivery_time_ = value;
		}
		public int? GetPurchase_type(){
			return this.purchase_type_;
		}
		
		public void SetPurchase_type(int? value){
			this.purchase_type_ = value;
		}
		public string GetVendor_code(){
			return this.vendor_code_;
		}
		
		public void SetVendor_code(string value){
			this.vendor_code_ = value;
		}
		public string GetVendor_name(){
			return this.vendor_name_;
		}
		
		public void SetVendor_name(string value){
			this.vendor_name_ = value;
		}
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public vipapis.xstore.cc.bulkbuying.api.Address GetReturn_address(){
			return this.return_address_;
		}
		
		public void SetReturn_address(vipapis.xstore.cc.bulkbuying.api.Address value){
			this.return_address_ = value;
		}
		public string GetBuyer_name(){
			return this.buyer_name_;
		}
		
		public void SetBuyer_name(string value){
			this.buyer_name_ = value;
		}
		public byte? GetIs_whale_warehouse(){
			return this.is_whale_warehouse_;
		}
		
		public void SetIs_whale_warehouse(byte? value){
			this.is_whale_warehouse_ = value;
		}
		public byte? GetReceiving_type(){
			return this.receiving_type_;
		}
		
		public void SetReceiving_type(byte? value){
			this.receiving_type_ = value;
		}
		public int? GetGoods_type(){
			return this.goods_type_;
		}
		
		public void SetGoods_type(int? value){
			this.goods_type_ = value;
		}
		public System.DateTime? GetDistributable_goods_time(){
			return this.distributable_goods_time_;
		}
		
		public void SetDistributable_goods_time(System.DateTime? value){
			this.distributable_goods_time_ = value;
		}
		public byte? GetCooperationMode(){
			return this.cooperationMode_;
		}
		
		public void SetCooperationMode(byte? value){
			this.cooperationMode_ = value;
		}
		public string GetRfid_template_code(){
			return this.rfid_template_code_;
		}
		
		public void SetRfid_template_code(string value){
			this.rfid_template_code_ = value;
		}
		public string GetIs_crossdock(){
			return this.is_crossdock_;
		}
		
		public void SetIs_crossdock(string value){
			this.is_crossdock_ = value;
		}
		public string GetOwner_code(){
			return this.owner_code_;
		}
		
		public void SetOwner_code(string value){
			this.owner_code_ = value;
		}
		
	}
	
}