using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TmsOrderInfoModel {
		
		///<summary>
		/// 物流单ID
		///</summary>
		
		private string tmsOrderId_;
		
		///<summary>
		/// 原始订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 订单类型
		///</summary>
		
		private int? vipClub_;
		
		///<summary>
		/// 顾客类型
		///</summary>
		
		private int? userType_;
		
		///<summary>
		/// 外键：tms_original_sale_order表主键
		///</summary>
		
		private string tmsOriginalOrderId_;
		
		///<summary>
		/// 所属仓库
		///</summary>
		
		private string createdOffice_;
		
		///<summary>
		/// 目的乡镇
		///</summary>
		
		private string buyTown_;
		
		///<summary>
		/// 承运商类型
		///</summary>
		
		private int? custType_;
		
		///<summary>
		/// 收货人所在区县
		///</summary>
		
		private string buyerAreaId_;
		
		///<summary>
		/// 客户（收货人）地址
		///</summary>
		
		private string buyerAddress_;
		
		///<summary>
		/// 收货人所在城市
		///</summary>
		
		private string buyerCity_;
		
		///<summary>
		/// 收货人所在省/州
		///</summary>
		
		private string buyerState_;
		
		///<summary>
		/// 收货人所在国家
		///</summary>
		
		private string buyerCountryId_;
		
		///<summary>
		/// 货到付款，1-是，0-否
		///</summary>
		
		private int? isCod_;
		
		///<summary>
		/// 扩展付款方式
		///</summary>
		
		private int? extPayType_;
		
		///<summary>
		/// 承载物类型
		///</summary>
		
		private string transportType_;
		
		///<summary>
		/// 联络电话
		///</summary>
		
		private string buyerTel_;
		
		///<summary>
		/// 手机号码
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 时间要求
		///</summary>
		
		private string transportDay_;
		
		///<summary>
		/// 快递运费
		///</summary>
		
		private double? carriage_;
		
		///<summary>
		/// 应收金额[单据金额*折扣比例]
		///</summary>
		
		private double? money_;
		
		///<summary>
		/// 下单时间
		///</summary>
		
		private System.DateTime? addTime_;
		
		///<summary>
		/// 姓名
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 是否二配考核
		///</summary>
		
		private int? isSecondMatchAppraise_;
		
		///<summary>
		/// 站点ID
		///</summary>
		
		private string crmCustPointId_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 订单客户
		///</summary>
		
		private string customerCode_;
		
		///<summary>
		/// 类型
		///</summary>
		
		private string orderType_;
		
		///<summary>
		/// 拣货完成时间
		///</summary>
		
		private System.DateTime? pickingFinishTime_;
		
		///<summary>
		/// 配送时间
		///</summary>
		
		private byte? transportTime_;
		
		///<summary>
		/// 接收仓库
		///</summary>
		
		private string receivingWarehouse_;
		
		///<summary>
		/// 原始vipclub
		///</summary>
		
		private string originalVipClub_;
		
		///<summary>
		/// 服务类型
		///</summary>
		
		private int? serviceType_;
		
		///<summary>
		/// 订单类型
		///</summary>
		
		private int? saleType_;
		
		///<summary>
		/// 物流单类型
		///</summary>
		
		private int? orderSubType_;
		
		///<summary>
		/// <p>是否JIT直发订单
		///</summary>
		
		private int? isJitZf_;
		
		///<summary>
		/// 承运商匹配业务类型
		///</summary>
		
		private int? thirdCarrierFlag_;
		
		public string GetTmsOrderId(){
			return this.tmsOrderId_;
		}
		
		public void SetTmsOrderId(string value){
			this.tmsOrderId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public int? GetVipClub(){
			return this.vipClub_;
		}
		
		public void SetVipClub(int? value){
			this.vipClub_ = value;
		}
		public int? GetUserType(){
			return this.userType_;
		}
		
		public void SetUserType(int? value){
			this.userType_ = value;
		}
		public string GetTmsOriginalOrderId(){
			return this.tmsOriginalOrderId_;
		}
		
		public void SetTmsOriginalOrderId(string value){
			this.tmsOriginalOrderId_ = value;
		}
		public string GetCreatedOffice(){
			return this.createdOffice_;
		}
		
		public void SetCreatedOffice(string value){
			this.createdOffice_ = value;
		}
		public string GetBuyTown(){
			return this.buyTown_;
		}
		
		public void SetBuyTown(string value){
			this.buyTown_ = value;
		}
		public int? GetCustType(){
			return this.custType_;
		}
		
		public void SetCustType(int? value){
			this.custType_ = value;
		}
		public string GetBuyerAreaId(){
			return this.buyerAreaId_;
		}
		
		public void SetBuyerAreaId(string value){
			this.buyerAreaId_ = value;
		}
		public string GetBuyerAddress(){
			return this.buyerAddress_;
		}
		
		public void SetBuyerAddress(string value){
			this.buyerAddress_ = value;
		}
		public string GetBuyerCity(){
			return this.buyerCity_;
		}
		
		public void SetBuyerCity(string value){
			this.buyerCity_ = value;
		}
		public string GetBuyerState(){
			return this.buyerState_;
		}
		
		public void SetBuyerState(string value){
			this.buyerState_ = value;
		}
		public string GetBuyerCountryId(){
			return this.buyerCountryId_;
		}
		
		public void SetBuyerCountryId(string value){
			this.buyerCountryId_ = value;
		}
		public int? GetIsCod(){
			return this.isCod_;
		}
		
		public void SetIsCod(int? value){
			this.isCod_ = value;
		}
		public int? GetExtPayType(){
			return this.extPayType_;
		}
		
		public void SetExtPayType(int? value){
			this.extPayType_ = value;
		}
		public string GetTransportType(){
			return this.transportType_;
		}
		
		public void SetTransportType(string value){
			this.transportType_ = value;
		}
		public string GetBuyerTel(){
			return this.buyerTel_;
		}
		
		public void SetBuyerTel(string value){
			this.buyerTel_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public string GetTransportDay(){
			return this.transportDay_;
		}
		
		public void SetTransportDay(string value){
			this.transportDay_ = value;
		}
		public double? GetCarriage(){
			return this.carriage_;
		}
		
		public void SetCarriage(double? value){
			this.carriage_ = value;
		}
		public double? GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(double? value){
			this.money_ = value;
		}
		public System.DateTime? GetAddTime(){
			return this.addTime_;
		}
		
		public void SetAddTime(System.DateTime? value){
			this.addTime_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public int? GetIsSecondMatchAppraise(){
			return this.isSecondMatchAppraise_;
		}
		
		public void SetIsSecondMatchAppraise(int? value){
			this.isSecondMatchAppraise_ = value;
		}
		public string GetCrmCustPointId(){
			return this.crmCustPointId_;
		}
		
		public void SetCrmCustPointId(string value){
			this.crmCustPointId_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetCustomerCode(){
			return this.customerCode_;
		}
		
		public void SetCustomerCode(string value){
			this.customerCode_ = value;
		}
		public string GetOrderType(){
			return this.orderType_;
		}
		
		public void SetOrderType(string value){
			this.orderType_ = value;
		}
		public System.DateTime? GetPickingFinishTime(){
			return this.pickingFinishTime_;
		}
		
		public void SetPickingFinishTime(System.DateTime? value){
			this.pickingFinishTime_ = value;
		}
		public byte? GetTransportTime(){
			return this.transportTime_;
		}
		
		public void SetTransportTime(byte? value){
			this.transportTime_ = value;
		}
		public string GetReceivingWarehouse(){
			return this.receivingWarehouse_;
		}
		
		public void SetReceivingWarehouse(string value){
			this.receivingWarehouse_ = value;
		}
		public string GetOriginalVipClub(){
			return this.originalVipClub_;
		}
		
		public void SetOriginalVipClub(string value){
			this.originalVipClub_ = value;
		}
		public int? GetServiceType(){
			return this.serviceType_;
		}
		
		public void SetServiceType(int? value){
			this.serviceType_ = value;
		}
		public int? GetSaleType(){
			return this.saleType_;
		}
		
		public void SetSaleType(int? value){
			this.saleType_ = value;
		}
		public int? GetOrderSubType(){
			return this.orderSubType_;
		}
		
		public void SetOrderSubType(int? value){
			this.orderSubType_ = value;
		}
		public int? GetIsJitZf(){
			return this.isJitZf_;
		}
		
		public void SetIsJitZf(int? value){
			this.isJitZf_ = value;
		}
		public int? GetThirdCarrierFlag(){
			return this.thirdCarrierFlag_;
		}
		
		public void SetThirdCarrierFlag(int? value){
			this.thirdCarrierFlag_ = value;
		}
		
	}
	
}