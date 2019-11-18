using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderItem {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 订单下单时间
		///</summary>
		
		private long? orderTime_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 收货人
		///</summary>
		
		private string recipients_;
		
		///<summary>
		/// 手机号
		///</summary>
		
		private string mobileNo_;
		
		///<summary>
		/// 收货地址
		///</summary>
		
		private string shipAddress_;
		
		///<summary>
		/// 省编码
		///</summary>
		
		private string provinceCode_;
		
		///<summary>
		/// 市编码
		///</summary>
		
		private string cityCode_;
		
		///<summary>
		/// 区编码
		///</summary>
		
		private string reginCode_;
		
		///<summary>
		/// 街道编码
		///</summary>
		
		private string streetCode_;
		
		///<summary>
		/// 门店Id
		///</summary>
		
		private long? storeId_;
		
		///<summary>
		/// 省编码
		///</summary>
		
		private string provinceName_;
		
		///<summary>
		/// 市编码
		///</summary>
		
		private string cityName_;
		
		///<summary>
		/// 区编码
		///</summary>
		
		private string reginName_;
		
		///<summary>
		/// 街道编码
		///</summary>
		
		private string streetName_;
		
		///<summary>
		/// 订单明细
		///</summary>
		
		private List<com.vip.vop.vcloud.order.OrderDetail> orderDetails_;
		
		///<summary>
		/// 官网会员账号
		///</summary>
		
		private string officalAccount_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 渠道ID
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 寻源状态
		///</summary>
		
		private int? findSrcState_;
		
		///<summary>
		/// 订单备注
		///</summary>
		
		private string orderRemark_;
		
		///<summary>
		/// 门店是否确认
		///</summary>
		
		private int? isConfirmed_;
		
		///<summary>
		/// 订单类型
		///</summary>
		
		private int? orderSaleType_;
		
		///<summary>
		/// 预售时间
		///</summary>
		
		private long? preOrderReleaseDate_;
		
		///<summary>
		/// 门店备注
		///</summary>
		
		private string remark_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public long? GetOrderTime(){
			return this.orderTime_;
		}
		
		public void SetOrderTime(long? value){
			this.orderTime_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetRecipients(){
			return this.recipients_;
		}
		
		public void SetRecipients(string value){
			this.recipients_ = value;
		}
		public string GetMobileNo(){
			return this.mobileNo_;
		}
		
		public void SetMobileNo(string value){
			this.mobileNo_ = value;
		}
		public string GetShipAddress(){
			return this.shipAddress_;
		}
		
		public void SetShipAddress(string value){
			this.shipAddress_ = value;
		}
		public string GetProvinceCode(){
			return this.provinceCode_;
		}
		
		public void SetProvinceCode(string value){
			this.provinceCode_ = value;
		}
		public string GetCityCode(){
			return this.cityCode_;
		}
		
		public void SetCityCode(string value){
			this.cityCode_ = value;
		}
		public string GetReginCode(){
			return this.reginCode_;
		}
		
		public void SetReginCode(string value){
			this.reginCode_ = value;
		}
		public string GetStreetCode(){
			return this.streetCode_;
		}
		
		public void SetStreetCode(string value){
			this.streetCode_ = value;
		}
		public long? GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(long? value){
			this.storeId_ = value;
		}
		public string GetProvinceName(){
			return this.provinceName_;
		}
		
		public void SetProvinceName(string value){
			this.provinceName_ = value;
		}
		public string GetCityName(){
			return this.cityName_;
		}
		
		public void SetCityName(string value){
			this.cityName_ = value;
		}
		public string GetReginName(){
			return this.reginName_;
		}
		
		public void SetReginName(string value){
			this.reginName_ = value;
		}
		public string GetStreetName(){
			return this.streetName_;
		}
		
		public void SetStreetName(string value){
			this.streetName_ = value;
		}
		public List<com.vip.vop.vcloud.order.OrderDetail> GetOrderDetails(){
			return this.orderDetails_;
		}
		
		public void SetOrderDetails(List<com.vip.vop.vcloud.order.OrderDetail> value){
			this.orderDetails_ = value;
		}
		public string GetOfficalAccount(){
			return this.officalAccount_;
		}
		
		public void SetOfficalAccount(string value){
			this.officalAccount_ = value;
		}
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
		public int? GetFindSrcState(){
			return this.findSrcState_;
		}
		
		public void SetFindSrcState(int? value){
			this.findSrcState_ = value;
		}
		public string GetOrderRemark(){
			return this.orderRemark_;
		}
		
		public void SetOrderRemark(string value){
			this.orderRemark_ = value;
		}
		public int? GetIsConfirmed(){
			return this.isConfirmed_;
		}
		
		public void SetIsConfirmed(int? value){
			this.isConfirmed_ = value;
		}
		public int? GetOrderSaleType(){
			return this.orderSaleType_;
		}
		
		public void SetOrderSaleType(int? value){
			this.orderSaleType_ = value;
		}
		public long? GetPreOrderReleaseDate(){
			return this.preOrderReleaseDate_;
		}
		
		public void SetPreOrderReleaseDate(long? value){
			this.preOrderReleaseDate_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}