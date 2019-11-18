using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class MatchProcessResultInfo {
		
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
		/// 匹配承运商时的二配标识 0：普通，1：一配，2：二配。isSecondMatchAppraise
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
		/// 所属仓库
		///</summary>
		
		private string createdOffice_;
		
		///<summary>
		/// 信用等级（crm_cust.cust_level）
		///</summary>
		
		private string custLevel_;
		
		///<summary>
		/// 是否支持支付宝（crm_cust.s_use_alipay）
		///</summary>
		
		private int? isUseAlipay_;
		
		///<summary>
		/// 承运商名称（crm_cust.cust_name）
		///</summary>
		
		private string custName_;
		
		///<summary>
		/// 是否支持航空禁运品
		///</summary>
		
		private int? isAir_;
		
		///<summary>
		/// 承运商省份/州
		///</summary>
		
		private string custStats_;
		
		///<summary>
		/// 承运商省份/州
		///</summary>
		
		private string custCity_;
		
		///<summary>
		/// 承运商区县
		///</summary>
		
		private string custRegion_;
		
		///<summary>
		/// 承运商镇街
		///</summary>
		
		private string custTown_;
		
		///<summary>
		/// 是否货到付款
		///</summary>
		
		private int? isCod_;
		
		///<summary>
		/// 是否送达镇街
		///</summary>
		
		private int? isTownReach_;
		
		///<summary>
		/// 规则类型
		///</summary>
		
		private int? ruleType_;
		
		///<summary>
		/// 
		///</summary>
		
		private double? levelRate_;
		
		///<summary>
		/// 城市匹配概率
		///</summary>
		
		private double? matchCityPercent_;
		
		///<summary>
		/// 区县匹配概率
		///</summary>
		
		private double? matchRegionPercent_;
		
		///<summary>
		/// 是否POS机支付
		///</summary>
		
		private int? isPos_;
		
		///<summary>
		/// 是否二配考核
		///</summary>
		
		private int? isSecondMatchAppraise_;
		
		///<summary>
		/// 是否夜间配送
		///</summary>
		
		private bool? isNightMatch_;
		
		///<summary>
		/// 合并订单的承运商编码
		///</summary>
		
		private string mergeCustCode_;
		
		///<summary>
		/// 合并订单的ID
		///</summary>
		
		private string mergeTmsOrderId_;
		
		///<summary>
		/// 是否二配区域一配时段
		///</summary>
		
		private bool? isSecondMatch_;
		
		///<summary>
		/// 支付方式匹配概率
		///</summary>
		
		private long? matchPayPercent_;
		
		///<summary>
		/// 现金支付匹配概率
		///</summary>
		
		private long? matchCashPercent_;
		
		///<summary>
		/// 刷卡支付匹配概率
		///</summary>
		
		private long? matchPosPercent_;
		
		///<summary>
		/// 是否存在承运商
		///</summary>
		
		private bool? isExistCrm_;
		
		///<summary>
		/// 是否进入区域匹配算法(默认不进入，走原来优先级匹配算法)
		///</summary>
		
		private bool? isMatchArea_;
		
		///<summary>
		/// 承运商匹配业务模式0：默认值1：JITX 2：3PLX
		///</summary>
		
		private int? matchBizType_;
		
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
		public string GetCreatedOffice(){
			return this.createdOffice_;
		}
		
		public void SetCreatedOffice(string value){
			this.createdOffice_ = value;
		}
		public string GetCustLevel(){
			return this.custLevel_;
		}
		
		public void SetCustLevel(string value){
			this.custLevel_ = value;
		}
		public int? GetIsUseAlipay(){
			return this.isUseAlipay_;
		}
		
		public void SetIsUseAlipay(int? value){
			this.isUseAlipay_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		public int? GetIsAir(){
			return this.isAir_;
		}
		
		public void SetIsAir(int? value){
			this.isAir_ = value;
		}
		public string GetCustStats(){
			return this.custStats_;
		}
		
		public void SetCustStats(string value){
			this.custStats_ = value;
		}
		public string GetCustCity(){
			return this.custCity_;
		}
		
		public void SetCustCity(string value){
			this.custCity_ = value;
		}
		public string GetCustRegion(){
			return this.custRegion_;
		}
		
		public void SetCustRegion(string value){
			this.custRegion_ = value;
		}
		public string GetCustTown(){
			return this.custTown_;
		}
		
		public void SetCustTown(string value){
			this.custTown_ = value;
		}
		public int? GetIsCod(){
			return this.isCod_;
		}
		
		public void SetIsCod(int? value){
			this.isCod_ = value;
		}
		public int? GetIsTownReach(){
			return this.isTownReach_;
		}
		
		public void SetIsTownReach(int? value){
			this.isTownReach_ = value;
		}
		public int? GetRuleType(){
			return this.ruleType_;
		}
		
		public void SetRuleType(int? value){
			this.ruleType_ = value;
		}
		public double? GetLevelRate(){
			return this.levelRate_;
		}
		
		public void SetLevelRate(double? value){
			this.levelRate_ = value;
		}
		public double? GetMatchCityPercent(){
			return this.matchCityPercent_;
		}
		
		public void SetMatchCityPercent(double? value){
			this.matchCityPercent_ = value;
		}
		public double? GetMatchRegionPercent(){
			return this.matchRegionPercent_;
		}
		
		public void SetMatchRegionPercent(double? value){
			this.matchRegionPercent_ = value;
		}
		public int? GetIsPos(){
			return this.isPos_;
		}
		
		public void SetIsPos(int? value){
			this.isPos_ = value;
		}
		public int? GetIsSecondMatchAppraise(){
			return this.isSecondMatchAppraise_;
		}
		
		public void SetIsSecondMatchAppraise(int? value){
			this.isSecondMatchAppraise_ = value;
		}
		public bool? GetIsNightMatch(){
			return this.isNightMatch_;
		}
		
		public void SetIsNightMatch(bool? value){
			this.isNightMatch_ = value;
		}
		public string GetMergeCustCode(){
			return this.mergeCustCode_;
		}
		
		public void SetMergeCustCode(string value){
			this.mergeCustCode_ = value;
		}
		public string GetMergeTmsOrderId(){
			return this.mergeTmsOrderId_;
		}
		
		public void SetMergeTmsOrderId(string value){
			this.mergeTmsOrderId_ = value;
		}
		public bool? GetIsSecondMatch(){
			return this.isSecondMatch_;
		}
		
		public void SetIsSecondMatch(bool? value){
			this.isSecondMatch_ = value;
		}
		public long? GetMatchPayPercent(){
			return this.matchPayPercent_;
		}
		
		public void SetMatchPayPercent(long? value){
			this.matchPayPercent_ = value;
		}
		public long? GetMatchCashPercent(){
			return this.matchCashPercent_;
		}
		
		public void SetMatchCashPercent(long? value){
			this.matchCashPercent_ = value;
		}
		public long? GetMatchPosPercent(){
			return this.matchPosPercent_;
		}
		
		public void SetMatchPosPercent(long? value){
			this.matchPosPercent_ = value;
		}
		public bool? GetIsExistCrm(){
			return this.isExistCrm_;
		}
		
		public void SetIsExistCrm(bool? value){
			this.isExistCrm_ = value;
		}
		public bool? GetIsMatchArea(){
			return this.isMatchArea_;
		}
		
		public void SetIsMatchArea(bool? value){
			this.isMatchArea_ = value;
		}
		public int? GetMatchBizType(){
			return this.matchBizType_;
		}
		
		public void SetMatchBizType(int? value){
			this.matchBizType_ = value;
		}
		
	}
	
}