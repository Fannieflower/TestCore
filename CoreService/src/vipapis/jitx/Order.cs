using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class Order {
		
		///<summary>
		/// 唯品会订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string delivery_warehouse_;
		
		///<summary>
		/// 下单时间
		///</summary>
		
		private string add_time_;
		
		///<summary>
		/// 收货人
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 收货详细地址(街道信息，不需重复省市区数据)
		///</summary>
		
		private string buyer_address_;
		
		///<summary>
		/// 手机号码
		///</summary>
		
		private string buyer_mobile_;
		
		///<summary>
		/// 联系电话
		///</summary>
		
		private string buyer_tel_;
		
		///<summary>
		/// 邮政编码
		///</summary>
		
		private string buyer_postcode_;
		
		///<summary>
		/// 城市
		///</summary>
		
		private string buyer_city_;
		
		///<summary>
		/// 省份
		///</summary>
		
		private string buyer_province_;
		
		///<summary>
		/// 区/县
		///</summary>
		
		private string buyer_county_;
		
		///<summary>
		/// 国家代码(CN)
		///</summary>
		
		private string buyer_country_id_;
		
		///<summary>
		/// 支付方式
		///</summary>
		
		private string pay_type_;
		
		///<summary>
		/// 支付方式(货到付款)
		///</summary>
		
		private string cod_type_;
		
		///<summary>
		/// 应收金额(货到付款才有金额)
		///</summary>
		
		private string cod_money_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 下发【标识】，枚举以下值：配送时间，周末配送项目新增字段，1，全天；2，白天；3，夜间；(new)
		///</summary>
		
		private string transport_time_;
		
		///<summary>
		/// 期望收货时间，只双休日/节假日送货(工作日不用送)，只工作日(双休日/节假日不用送)，只晚上送货(白天不用送)，送货时间不限
		///</summary>
		
		private string transport_day_;
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendor_name_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 承运商编码。非空，例如：pjbest-品骏；yuantong-圆通；yunda-韵达
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 承运商名称。非空。提供文本。例如：品骏，圆通
		///</summary>
		
		private string carrier_name_;
		
		///<summary>
		/// 订单状态10：订单已审核22:订单已发货23:订单已揽收97_22:已发货取消97_10:未发货取消97_23:已揽收取消
		///</summary>
		
		private string order_status_;
		
		///<summary>
		/// 订单最后更新时间,格式:yyyy-MM-dd
		///</summary>
		
		private string last_update_time_;
		
		///<summary>
		/// 揽收时间
		///</summary>
		
		private string package_received_time_;
		
		///<summary>
		/// 商品明细
		///</summary>
		
		private List<vipapis.jitx.OrderGood> order_goods_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetDelivery_warehouse(){
			return this.delivery_warehouse_;
		}
		
		public void SetDelivery_warehouse(string value){
			this.delivery_warehouse_ = value;
		}
		public string GetAdd_time(){
			return this.add_time_;
		}
		
		public void SetAdd_time(string value){
			this.add_time_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public string GetBuyer_address(){
			return this.buyer_address_;
		}
		
		public void SetBuyer_address(string value){
			this.buyer_address_ = value;
		}
		public string GetBuyer_mobile(){
			return this.buyer_mobile_;
		}
		
		public void SetBuyer_mobile(string value){
			this.buyer_mobile_ = value;
		}
		public string GetBuyer_tel(){
			return this.buyer_tel_;
		}
		
		public void SetBuyer_tel(string value){
			this.buyer_tel_ = value;
		}
		public string GetBuyer_postcode(){
			return this.buyer_postcode_;
		}
		
		public void SetBuyer_postcode(string value){
			this.buyer_postcode_ = value;
		}
		public string GetBuyer_city(){
			return this.buyer_city_;
		}
		
		public void SetBuyer_city(string value){
			this.buyer_city_ = value;
		}
		public string GetBuyer_province(){
			return this.buyer_province_;
		}
		
		public void SetBuyer_province(string value){
			this.buyer_province_ = value;
		}
		public string GetBuyer_county(){
			return this.buyer_county_;
		}
		
		public void SetBuyer_county(string value){
			this.buyer_county_ = value;
		}
		public string GetBuyer_country_id(){
			return this.buyer_country_id_;
		}
		
		public void SetBuyer_country_id(string value){
			this.buyer_country_id_ = value;
		}
		public string GetPay_type(){
			return this.pay_type_;
		}
		
		public void SetPay_type(string value){
			this.pay_type_ = value;
		}
		public string GetCod_type(){
			return this.cod_type_;
		}
		
		public void SetCod_type(string value){
			this.cod_type_ = value;
		}
		public string GetCod_money(){
			return this.cod_money_;
		}
		
		public void SetCod_money(string value){
			this.cod_money_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetTransport_time(){
			return this.transport_time_;
		}
		
		public void SetTransport_time(string value){
			this.transport_time_ = value;
		}
		public string GetTransport_day(){
			return this.transport_day_;
		}
		
		public void SetTransport_day(string value){
			this.transport_day_ = value;
		}
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public string GetVendor_name(){
			return this.vendor_name_;
		}
		
		public void SetVendor_name(string value){
			this.vendor_name_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetCarrier_name(){
			return this.carrier_name_;
		}
		
		public void SetCarrier_name(string value){
			this.carrier_name_ = value;
		}
		public string GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(string value){
			this.order_status_ = value;
		}
		public string GetLast_update_time(){
			return this.last_update_time_;
		}
		
		public void SetLast_update_time(string value){
			this.last_update_time_ = value;
		}
		public string GetPackage_received_time(){
			return this.package_received_time_;
		}
		
		public void SetPackage_received_time(string value){
			this.package_received_time_ = value;
		}
		public List<vipapis.jitx.OrderGood> GetOrder_goods(){
			return this.order_goods_;
		}
		
		public void SetOrder_goods(List<vipapis.jitx.OrderGood> value){
			this.order_goods_ = value;
		}
		
	}
	
}