using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class MatchResultInfo {
		
		///<summary>
		/// 承运商匹配订单类型 @see com.vip.top.carrier.enums.MatchCarrierOrderType
		///</summary>
		
		private int? matchOrderType_;
		
		///<summary>
		/// 物流单ID（tms_order.tms_order_id，主键）
		///</summary>
		
		private string tmsOrderId_;
		
		///<summary>
		/// 承运商ID（crm_cust.cust_id）
		///</summary>
		
		private string custId_;
		
		///<summary>
		/// 承运商编码（crm_cust.cust_code）
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 承运商类型（crm_cust.cust_type）
		///</summary>
		
		private int? custType_;
		
		///<summary>
		/// 承运商名称（crm_cust.cust_name）
		///</summary>
		
		private string infCust_;
		
		///<summary>
		/// 承运商卸货站点ID（crm_cust_develivery_area.crm_cust_point_id）
		///</summary>
		
		private string infCustPointId_;
		
		///<summary>
		/// 承运商卸货站点编码（crm_cust_develivery_area.point_code）
		///</summary>
		
		private string infCustPointCode_;
		
		///<summary>
		/// 承运商卸货站点名称（crm_cust_point.point_name）
		///</summary>
		
		private string infCustPointName_;
		
		///<summary>
		/// 承运商提货时间（crm_cust_pickup_goods_time.pickup_goods_time）
		///</summary>
		
		private string infCustPickupGoodsTime_;
		
		///<summary>
		/// 海淘订单原寄地代码（tms_hts_batchno_order.origin_code）
		///</summary>
		
		private string infOrderOrginCode_;
		
		///<summary>
		/// 海淘订单目的地代码（tms_hts_batchno_order.destination_code）
		///</summary>
		
		private string infOrderDestinationCode_;
		
		///<summary>
		/// 面单打印[付款方式]（tms_hts_batchno_order.pay_type）
		///</summary>
		
		private string payType_;
		
		///<summary>
		/// 匹配承运商时的二配标识 0：普通，1：一配，2：二配。
		///</summary>
		
		private int? orderDeliveryBatch_;
		
		///<summary>
		/// 面单打印模板（crm_cust.waybill_template）
		///</summary>
		
		private string templateCode_;
		
		///<summary>
		/// 分拣码（crm_cust_picking_code.picking_code）
		///</summary>
		
		private string pickingCode_;
		
		///<summary>
		/// 分拣级别（crm_cust_picking_code.picking_level）
		///</summary>
		
		private string pickingLevel_;
		
		///<summary>
		/// 匹配数据的目标接收者：WMS，VIP_SE
		///</summary>
		
		private string destAccepter_;
		
		///<summary>
		/// 分发报关物流单标示 0：不分发，1：待分发，2：分发成功
		///</summary>
		
		private int? distributeDeclareOrder_;
		
		///<summary>
		/// 配送时效（crm_cust_develivery_area.original_service_level）
		///</summary>
		
		private double? originalServiceLevel_;
		
		///<summary>
		/// 开始手动挑单时间，取系统当前时间
		///</summary>
		
		private System.DateTime? acceptManipulatMatchTime_;
		
		///<summary>
		/// 是否有匹配到承运商，true是，false否
		///</summary>
		
		private bool? matchFlag_;
		
		///<summary>
		/// 匹配承运商备注：订单匹配使用何种匹配规则说明
		///</summary>
		
		private string matchMemo_;
		
		///<summary>
		/// 配送点CODE
		///</summary>
		
		private string deliverPointCode_;
		
		///<summary>
		/// 承运商的面单打印名称
		///</summary>
		
		private string custPrintName_;
		
		///<summary>
		/// 客户（收货人）地址
		///</summary>
		
		private string buyerAddress_;
		
		///<summary>
		/// 收货人所在国家
		///</summary>
		
		private string buyerCountryId_;
		
		///<summary>
		/// 收货人所在省/州
		///</summary>
		
		private string buyerState_;
		
		///<summary>
		/// 收货人所在城市
		///</summary>
		
		private string buyerCity_;
		
		///<summary>
		/// 收货人所在区县
		///</summary>
		
		private string buyerAreaId_;
		
		///<summary>
		/// 目的乡镇
		///</summary>
		
		private string buyTown_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 原始订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 站点ID
		///</summary>
		
		private string crmCustPointId_;
		
		///<summary>
		/// 类型
		///</summary>
		
		private string orderType_;
		
		///<summary>
		/// 发送控制 @see SendMatchControl
		///</summary>
		
		private int? sendMatchControl_;
		
		///<summary>
		/// 是否二配考核
		///</summary>
		
		private int? isSecondMatchAppraise_;
		
		///<summary>
		/// 承运商库区编码
		///</summary>
		
		private string wareHouseArea_;
		
		///<summary>
		/// 是否品骏分拨
		///</summary>
		
		private int? isPjDistribution_;
		
		///<summary>
		/// 是否品骏系
		///</summary>
		
		private int? isPjGroup_;
		
		///<summary>
		/// 子运单模式.1-品骏快递
		///</summary>
		
		private int? subMailnoModel_;
		
		///<summary>
		/// 承运商匹配业务模式0：默认值1：JITX 2：3PLX
		///</summary>
		
		private int? matchBizType_;
		
		public int? GetMatchOrderType(){
			return this.matchOrderType_;
		}
		
		public void SetMatchOrderType(int? value){
			this.matchOrderType_ = value;
		}
		public string GetTmsOrderId(){
			return this.tmsOrderId_;
		}
		
		public void SetTmsOrderId(string value){
			this.tmsOrderId_ = value;
		}
		public string GetCustId(){
			return this.custId_;
		}
		
		public void SetCustId(string value){
			this.custId_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public int? GetCustType(){
			return this.custType_;
		}
		
		public void SetCustType(int? value){
			this.custType_ = value;
		}
		public string GetInfCust(){
			return this.infCust_;
		}
		
		public void SetInfCust(string value){
			this.infCust_ = value;
		}
		public string GetInfCustPointId(){
			return this.infCustPointId_;
		}
		
		public void SetInfCustPointId(string value){
			this.infCustPointId_ = value;
		}
		public string GetInfCustPointCode(){
			return this.infCustPointCode_;
		}
		
		public void SetInfCustPointCode(string value){
			this.infCustPointCode_ = value;
		}
		public string GetInfCustPointName(){
			return this.infCustPointName_;
		}
		
		public void SetInfCustPointName(string value){
			this.infCustPointName_ = value;
		}
		public string GetInfCustPickupGoodsTime(){
			return this.infCustPickupGoodsTime_;
		}
		
		public void SetInfCustPickupGoodsTime(string value){
			this.infCustPickupGoodsTime_ = value;
		}
		public string GetInfOrderOrginCode(){
			return this.infOrderOrginCode_;
		}
		
		public void SetInfOrderOrginCode(string value){
			this.infOrderOrginCode_ = value;
		}
		public string GetInfOrderDestinationCode(){
			return this.infOrderDestinationCode_;
		}
		
		public void SetInfOrderDestinationCode(string value){
			this.infOrderDestinationCode_ = value;
		}
		public string GetPayType(){
			return this.payType_;
		}
		
		public void SetPayType(string value){
			this.payType_ = value;
		}
		public int? GetOrderDeliveryBatch(){
			return this.orderDeliveryBatch_;
		}
		
		public void SetOrderDeliveryBatch(int? value){
			this.orderDeliveryBatch_ = value;
		}
		public string GetTemplateCode(){
			return this.templateCode_;
		}
		
		public void SetTemplateCode(string value){
			this.templateCode_ = value;
		}
		public string GetPickingCode(){
			return this.pickingCode_;
		}
		
		public void SetPickingCode(string value){
			this.pickingCode_ = value;
		}
		public string GetPickingLevel(){
			return this.pickingLevel_;
		}
		
		public void SetPickingLevel(string value){
			this.pickingLevel_ = value;
		}
		public string GetDestAccepter(){
			return this.destAccepter_;
		}
		
		public void SetDestAccepter(string value){
			this.destAccepter_ = value;
		}
		public int? GetDistributeDeclareOrder(){
			return this.distributeDeclareOrder_;
		}
		
		public void SetDistributeDeclareOrder(int? value){
			this.distributeDeclareOrder_ = value;
		}
		public double? GetOriginalServiceLevel(){
			return this.originalServiceLevel_;
		}
		
		public void SetOriginalServiceLevel(double? value){
			this.originalServiceLevel_ = value;
		}
		public System.DateTime? GetAcceptManipulatMatchTime(){
			return this.acceptManipulatMatchTime_;
		}
		
		public void SetAcceptManipulatMatchTime(System.DateTime? value){
			this.acceptManipulatMatchTime_ = value;
		}
		public bool? GetMatchFlag(){
			return this.matchFlag_;
		}
		
		public void SetMatchFlag(bool? value){
			this.matchFlag_ = value;
		}
		public string GetMatchMemo(){
			return this.matchMemo_;
		}
		
		public void SetMatchMemo(string value){
			this.matchMemo_ = value;
		}
		public string GetDeliverPointCode(){
			return this.deliverPointCode_;
		}
		
		public void SetDeliverPointCode(string value){
			this.deliverPointCode_ = value;
		}
		public string GetCustPrintName(){
			return this.custPrintName_;
		}
		
		public void SetCustPrintName(string value){
			this.custPrintName_ = value;
		}
		public string GetBuyerAddress(){
			return this.buyerAddress_;
		}
		
		public void SetBuyerAddress(string value){
			this.buyerAddress_ = value;
		}
		public string GetBuyerCountryId(){
			return this.buyerCountryId_;
		}
		
		public void SetBuyerCountryId(string value){
			this.buyerCountryId_ = value;
		}
		public string GetBuyerState(){
			return this.buyerState_;
		}
		
		public void SetBuyerState(string value){
			this.buyerState_ = value;
		}
		public string GetBuyerCity(){
			return this.buyerCity_;
		}
		
		public void SetBuyerCity(string value){
			this.buyerCity_ = value;
		}
		public string GetBuyerAreaId(){
			return this.buyerAreaId_;
		}
		
		public void SetBuyerAreaId(string value){
			this.buyerAreaId_ = value;
		}
		public string GetBuyTown(){
			return this.buyTown_;
		}
		
		public void SetBuyTown(string value){
			this.buyTown_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetCrmCustPointId(){
			return this.crmCustPointId_;
		}
		
		public void SetCrmCustPointId(string value){
			this.crmCustPointId_ = value;
		}
		public string GetOrderType(){
			return this.orderType_;
		}
		
		public void SetOrderType(string value){
			this.orderType_ = value;
		}
		public int? GetSendMatchControl(){
			return this.sendMatchControl_;
		}
		
		public void SetSendMatchControl(int? value){
			this.sendMatchControl_ = value;
		}
		public int? GetIsSecondMatchAppraise(){
			return this.isSecondMatchAppraise_;
		}
		
		public void SetIsSecondMatchAppraise(int? value){
			this.isSecondMatchAppraise_ = value;
		}
		public string GetWareHouseArea(){
			return this.wareHouseArea_;
		}
		
		public void SetWareHouseArea(string value){
			this.wareHouseArea_ = value;
		}
		public int? GetIsPjDistribution(){
			return this.isPjDistribution_;
		}
		
		public void SetIsPjDistribution(int? value){
			this.isPjDistribution_ = value;
		}
		public int? GetIsPjGroup(){
			return this.isPjGroup_;
		}
		
		public void SetIsPjGroup(int? value){
			this.isPjGroup_ = value;
		}
		public int? GetSubMailnoModel(){
			return this.subMailnoModel_;
		}
		
		public void SetSubMailnoModel(int? value){
			this.subMailnoModel_ = value;
		}
		public int? GetMatchBizType(){
			return this.matchBizType_;
		}
		
		public void SetMatchBizType(int? value){
			this.matchBizType_ = value;
		}
		
	}
	
}