using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.service{
	
	
	
	
	
	public class TmsOrderUnionModel {
		
		///<summary>
		/// 记录ID
		///</summary>
		
		private long? recId_;
		
		///<summary>
		/// 物流单ID
		///</summary>
		
		private string tmsOrderId_;
		
		///<summary>
		/// 退货时间
		///</summary>
		
		private long? returnBoxTime_;
		
		///<summary>
		/// PO ID
		///</summary>
		
		private string purchaseOrderId_;
		
		///<summary>
		/// 是否计算运费
		///</summary>
		
		private int? isCountFee_;
		
		///<summary>
		/// 易碎品
		///</summary>
		
		private int? easybreak_;
		
		///<summary>
		/// 订单渠道名称
		///</summary>
		
		private string vipClubName_;
		
		///<summary>
		/// 用户类型名称
		///</summary>
		
		private string userTypeName_;
		
		///<summary>
		/// 配送类型名称
		///</summary>
		
		private string transportTypeName_;
		
		///<summary>
		/// 电子货币钱包
		///</summary>
		
		private double? surplus_;
		
		///<summary>
		/// 运费
		///</summary>
		
		private double? carriage_;
		
		///<summary>
		/// 出仓时间
		///</summary>
		
		private long? joinTime_;
		
		///<summary>
		/// 包裹数
		///</summary>
		
		private long? totalPack_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 是否支付
		///</summary>
		
		private int? isPay_;
		
		///<summary>
		/// 物流单号
		///</summary>
		
		private string orderNo_;
		
		///<summary>
		/// 是否货到付款
		///</summary>
		
		private int? isCod_;
		
		///<summary>
		/// 是否重发
		///</summary>
		
		private int? resendType_;
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private string userId_;
		
		///<summary>
		/// 下单人
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 收件人地址
		///</summary>
		
		private string buyerAddress_;
		
		///<summary>
		/// 收件人邮编
		///</summary>
		
		private string postCode_;
		
		///<summary>
		/// 收件人区域ID
		///</summary>
		
		private string buyerAreaId_;
		
		///<summary>
		/// 收件人地址2
		///</summary>
		
		private string buyerAddress2_;
		
		///<summary>
		/// 收件人地址3
		///</summary>
		
		private string buyerAddress3_;
		
		///<summary>
		/// 收件人城市
		///</summary>
		
		private string buyerCity_;
		
		///<summary>
		/// 收件人省份
		///</summary>
		
		private string buyerState_;
		
		///<summary>
		/// 收件人国家
		///</summary>
		
		private string buyerCountryId_;
		
		///<summary>
		/// 收件人电话
		///</summary>
		
		private string buyerTel_;
		
		///<summary>
		/// po类型
		///</summary>
		
		private int? poType_;
		
		///<summary>
		/// 有效限期
		///</summary>
		
		private string poPeriodValid_;
		
		///<summary>
		/// 采购
		///</summary>
		
		private string poBuyer_;
		
		///<summary>
		/// 电话号码
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 运送方式
		///</summary>
		
		private int? transportId_;
		
		///<summary>
		/// 承载物类型[航空禁运品]
		///</summary>
		
		private string transportType_;
		
		///<summary>
		/// 下单时间
		///</summary>
		
		private long? addTime_;
		
		///<summary>
		/// 支付类型
		///</summary>
		
		private string payType_;
		
		///<summary>
		/// 配送时间
		///</summary>
		
		private string transportDay_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 订单类型
		///</summary>
		
		private string orderType_;
		
		///<summary>
		/// 订单渠道
		///</summary>
		
		private int? vipClub_;
		
		///<summary>
		/// 发票抬头
		///</summary>
		
		private string invoice_;
		
		///<summary>
		/// 商品价
		///</summary>
		
		private double? goodsMoney_;
		
		///<summary>
		/// 付款
		///</summary>
		
		private double? money_;
		
		///<summary>
		/// 折扣
		///</summary>
		
		private double? aigo_;
		
		///<summary>
		/// 优惠金额
		///</summary>
		
		private double? favourableMoney_;
		
		///<summary>
		/// 促销优惠金额
		///</summary>
		
		private double? exFavMoney_;
		
		///<summary>
		/// 用户类型
		///</summary>
		
		private int? userType_;
		
		///<summary>
		/// 优惠1
		///</summary>
		
		private double? exPayMoney1_;
		
		///<summary>
		/// 优惠2
		///</summary>
		
		private double? exPayMoney2_;
		
		///<summary>
		/// 优惠3
		///</summary>
		
		private double? exPayMoney3_;
		
		///<summary>
		/// 是否hold
		///</summary>
		
		private int? isHold_;
		
		///<summary>
		/// 原始单号
		///</summary>
		
		private string oldOrderSn_;
		
		///<summary>
		/// 预留
		///</summary>
		
		private int? iudFlag_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 时效
		///</summary>
		
		private double? originalServiceLevel_;
		
		///<summary>
		/// 体积
		///</summary>
		
		private double? originalVolume_;
		
		///<summary>
		/// 体积单位
		///</summary>
		
		private string originalVolumeUnit_;
		
		///<summary>
		/// 重量
		///</summary>
		
		private double? originalWeight_;
		
		///<summary>
		/// 重量单位
		///</summary>
		
		private string originalWeightUnit_;
		
		///<summary>
		/// 总数量
		///</summary>
		
		private double? originalAmount_;
		
		///<summary>
		/// 运输交接人
		///</summary>
		
		private string transportWorkerName_;
		
		///<summary>
		/// 数量单位
		///</summary>
		
		private string amountUnit_;
		
		///<summary>
		/// 物流单类型
		///</summary>
		
		private int? orderSubType_;
		
		///<summary>
		/// 物流单状态
		///</summary>
		
		private int? orderStatus_;
		
		///<summary>
		/// 签收人
		///</summary>
		
		private string signInMan_;
		
		///<summary>
		/// 匹配状态
		///</summary>
		
		private int? isAutopicked_;
		
		///<summary>
		/// 出仓交接人
		///</summary>
		
		private string jionCustWorker_;
		
		///<summary>
		/// 匹配承运商时间
		///</summary>
		
		private long? acceptManipulatMatcTime_;
		
		///<summary>
		/// 承运商手动匹配序号
		///</summary>
		
		private long? custNumber_;
		
		///<summary>
		/// 是否跟踪
		///</summary>
		
		private int? isTrack_;
		
		///<summary>
		/// 是否异常
		///</summary>
		
		private int? isExceptional_;
		
		///<summary>
		/// 是否出险
		///</summary>
		
		private int? isInsurance_;
		
		///<summary>
		/// 关单人员
		///</summary>
		
		private string closeMan_;
		
		///<summary>
		/// 拒收时间
		///</summary>
		
		private long? rejectionTime_;
		
		///<summary>
		/// 签收时间
		///</summary>
		
		private long? signInTime_;
		
		///<summary>
		/// 是否关闭
		///</summary>
		
		private int? isClosed_;
		
		///<summary>
		/// 回单操作人
		///</summary>
		
		private string circularWorkerName_;
		
		///<summary>
		/// 关单时间
		///</summary>
		
		private long? closeTime_;
		
		///<summary>
		/// 关单操作人
		///</summary>
		
		private string closeManCode_;
		
		///<summary>
		/// 是否回单
		///</summary>
		
		private int? isCircular_;
		
		///<summary>
		/// 回单操作账号
		///</summary>
		
		private string circularWorker_;
		
		///<summary>
		/// 预计到达时间
		///</summary>
		
		private long? eta_;
		
		///<summary>
		/// 起运时间
		///</summary>
		
		private long? atd_;
		
		///<summary>
		/// 回单时间
		///</summary>
		
		private long? circularTime_;
		
		///<summary>
		/// 起运城市
		///</summary>
		
		private string oriCity_;
		
		///<summary>
		/// 原始单ID
		///</summary>
		
		private string tmsOriginalOrderId_;
		
		///<summary>
		/// 退款类型
		///</summary>
		
		private int? returnType_;
		
		///<summary>
		/// 退货申请单号
		///</summary>
		
		private string returnno_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createdByUser_;
		
		///<summary>
		/// 仓库
		///</summary>
		
		private string createdOffice_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private long? createdDtmLoc_;
		
		///<summary>
		/// 创建时区
		///</summary>
		
		private string createdTimeZone_;
		
		///<summary>
		/// 更新仓库
		///</summary>
		
		private string updatedOffice_;
		
		///<summary>
		/// 更新人
		///</summary>
		
		private string updatedByUser_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private long? updatedDtmLoc_;
		
		///<summary>
		/// 是否拒收
		///</summary>
		
		private int? isRefuce_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 当前所在配送点
		///</summary>
		
		private string currentDeliveryPoint_;
		
		///<summary>
		/// 配送点
		///</summary>
		
		private string deliveryPoint_;
		
		///<summary>
		/// 跟新时区
		///</summary>
		
		private string updatedTimeZone_;
		
		///<summary>
		/// 版本号
		///</summary>
		
		private long? recordVersion_;
		
		///<summary>
		/// 承运商类型
		///</summary>
		
		private int? custType_;
		
		///<summary>
		/// 是否删除
		///</summary>
		
		private int? isDelete_;
		
		///<summary>
		/// 是否破损
		///</summary>
		
		private string aux1_;
		
		///<summary>
		/// 是否丢件
		///</summary>
		
		private string aux2_;
		
		///<summary>
		/// 附加
		///</summary>
		
		private string aux3_;
		
		///<summary>
		/// 匹配备注信息
		///</summary>
		
		private string aux4_;
		
		///<summary>
		/// 上一次匹配结果
		///</summary>
		
		private string aux5_;
		
		///<summary>
		/// 是否回访
		///</summary>
		
		private int? isFeedBack_;
		
		///<summary>
		/// 是否计费
		///</summary>
		
		private int? autoFreight_;
		
		///<summary>
		/// 会计期间
		///</summary>
		
		private string fiscalYear_;
		
		///<summary>
		/// 是否修改
		///</summary>
		
		private int? isUpdate_;
		
		///<summary>
		/// 特殊客退
		///</summary>
		
		private int? isSpecialReturn_;
		
		///<summary>
		/// 承运商罚款金额
		///</summary>
		
		private double? custCounterAmount_;
		
		///<summary>
		/// 承运商索赔金额
		///</summary>
		
		private double? custClaimAmount_;
		
		///<summary>
		/// 保险公司索赔金额
		///</summary>
		
		private double? insuranceClaimAmount_;
		
		///<summary>
		/// 打包时间
		///</summary>
		
		private long? oqcDate_;
		
		///<summary>
		/// 退货联系人
		///</summary>
		
		private string returnGoodsContact_;
		
		///<summary>
		/// 退货联系电话
		///</summary>
		
		private string returnGoodsPhone_;
		
		///<summary>
		/// 退货类型
		///</summary>
		
		private int? returnGoodsType_;
		
		///<summary>
		/// 渠道
		///</summary>
		
		private string brand_;
		
		///<summary>
		/// 商户对接人
		///</summary>
		
		private string merchantsInterface_;
		
		///<summary>
		/// 商户对接电话
		///</summary>
		
		private string merchantsInterfacePhone_;
		
		///<summary>
		/// 退货特殊要求
		///</summary>
		
		private string returnSpecialRequirements_;
		
		///<summary>
		/// 支付
		///</summary>
		
		private int? payment_;
		
		///<summary>
		/// 退供联系人
		///</summary>
		
		private string returnVendorContact_;
		
		///<summary>
		/// 配送方式
		///</summary>
		
		private int? deliveryMode_;
		
		///<summary>
		/// 收货单位
		///</summary>
		
		private string receivedUnit_;
		
		///<summary>
		/// 运输方式
		///</summary>
		
		private int? transportMode_;
		
		///<summary>
		/// 配送员
		///</summary>
		
		private string deliverGoodsManLink_;
		
		///<summary>
		/// 配送员联系方式
		///</summary>
		
		private string deliverGoodsManPhone_;
		
		///<summary>
		/// 是否已入站
		///</summary>
		
		private int? isInStation_;
		
		///<summary>
		/// 收件人乡镇
		///</summary>
		
		private string buyTown_;
		
		///<summary>
		/// 取消状态
		///</summary>
		
		private int? cancelStatus_;
		
		///<summary>
		/// 结算方式
		///</summary>
		
		private string wayOfSettlement_;
		
		///<summary>
		/// 落地配交接时间
		///</summary>
		
		private long? ldpJoinTime_;
		
		///<summary>
		/// 重新计费备注
		///</summary>
		
		private string reBillingRemark_;
		
		///<summary>
		/// 扩展支付类型
		///</summary>
		
		private int? extPayType_;
		
		///<summary>
		/// 考核时效
		///</summary>
		
		private long? appraisedTime_;
		
		///<summary>
		/// 交接批次
		///</summary>
		
		private string orderBatchNo_;
		
		///<summary>
		/// 干线承运商
		///</summary>
		
		private string orderMainCust_;
		
		///<summary>
		/// 用户名
		///</summary>
		
		private string b2cUserName_;
		
		///<summary>
		/// 子单号
		///</summary>
		
		private string mergeOrderSns_;
		
		///<summary>
		/// 合并单号
		///</summary>
		
		private string mergeParentOrderSn_;
		
		///<summary>
		/// 合并物流单号
		///</summary>
		
		private string mergeParentOrderNo_;
		
		///<summary>
		/// 合并单标识
		///</summary>
		
		private int? mergeFlag_;
		
		///<summary>
		/// 临时承运商
		///</summary>
		
		private string tempCustCode_;
		
		///<summary>
		/// 是否二配
		///</summary>
		
		private short? isSecondMatch_;
		
		///<summary>
		/// 是否二配考核
		///</summary>
		
		private bool? isSecondMatchAppraise_;
		
		///<summary>
		/// 二配考核时效
		///</summary>
		
		private long? secondMatchAppraiseTime_;
		
		///<summary>
		/// 是否拦截
		///</summary>
		
		private int? isIntercept_;
		
		///<summary>
		/// 拦截操作人
		///</summary>
		
		private string interceptOperator_;
		
		///<summary>
		/// 拦截时间
		///</summary>
		
		private long? interceptTime_;
		
		///<summary>
		/// 承运商站点
		///</summary>
		
		private string crmCustPointId_;
		
		///<summary>
		/// 是否打印
		///</summary>
		
		private byte? isPrint_;
		
		///<summary>
		/// 服务类型
		///</summary>
		
		private byte? serviceType_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string customerCode_;
		
		///<summary>
		/// 发件人地址
		///</summary>
		
		private string sendAddress_;
		
		///<summary>
		/// 分发状态
		///</summary>
		
		private byte? dispatchStatus_;
		
		///<summary>
		/// 分发日期
		///</summary>
		
		private long? dispatchDate_;
		
		///<summary>
		/// 赔偿金额
		///</summary>
		
		private double? mbpCompensationAmount_;
		
		///<summary>
		/// 平台
		///</summary>
		
		private string salesPlatform_;
		
		///<summary>
		/// 站点名称
		///</summary>
		
		private string carrierPointName_;
		
		///<summary>
		/// 站点
		///</summary>
		
		private string carrierPointCode_;
		
		///<summary>
		/// 站点承运商
		///</summary>
		
		private string carrierPointCustCode_;
		
		///<summary>
		/// 仓库名称
		///</summary>
		
		private string officeName_;
		
		///<summary>
		/// 仓库真实名称
		///</summary>
		
		private string officeOutName_;
		
		///<summary>
		/// 联系方式
		///</summary>
		
		private string contact_;
		
		///<summary>
		/// 电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string officeCode_;
		
		///<summary>
		/// 省份编码
		///</summary>
		
		private string provinceCode_;
		
		///<summary>
		/// 城市编码
		///</summary>
		
		private string cityCode_;
		
		///<summary>
		/// 国家编码
		///</summary>
		
		private string countryCode_;
		
		///<summary>
		/// 区域编码
		///</summary>
		
		private string regionCode_;
		
		///<summary>
		/// 地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 承运商名称
		///</summary>
		
		private string custName_;
		
		public long? GetRecId(){
			return this.recId_;
		}
		
		public void SetRecId(long? value){
			this.recId_ = value;
		}
		public string GetTmsOrderId(){
			return this.tmsOrderId_;
		}
		
		public void SetTmsOrderId(string value){
			this.tmsOrderId_ = value;
		}
		public long? GetReturnBoxTime(){
			return this.returnBoxTime_;
		}
		
		public void SetReturnBoxTime(long? value){
			this.returnBoxTime_ = value;
		}
		public string GetPurchaseOrderId(){
			return this.purchaseOrderId_;
		}
		
		public void SetPurchaseOrderId(string value){
			this.purchaseOrderId_ = value;
		}
		public int? GetIsCountFee(){
			return this.isCountFee_;
		}
		
		public void SetIsCountFee(int? value){
			this.isCountFee_ = value;
		}
		public int? GetEasybreak(){
			return this.easybreak_;
		}
		
		public void SetEasybreak(int? value){
			this.easybreak_ = value;
		}
		public string GetVipClubName(){
			return this.vipClubName_;
		}
		
		public void SetVipClubName(string value){
			this.vipClubName_ = value;
		}
		public string GetUserTypeName(){
			return this.userTypeName_;
		}
		
		public void SetUserTypeName(string value){
			this.userTypeName_ = value;
		}
		public string GetTransportTypeName(){
			return this.transportTypeName_;
		}
		
		public void SetTransportTypeName(string value){
			this.transportTypeName_ = value;
		}
		public double? GetSurplus(){
			return this.surplus_;
		}
		
		public void SetSurplus(double? value){
			this.surplus_ = value;
		}
		public double? GetCarriage(){
			return this.carriage_;
		}
		
		public void SetCarriage(double? value){
			this.carriage_ = value;
		}
		public long? GetJoinTime(){
			return this.joinTime_;
		}
		
		public void SetJoinTime(long? value){
			this.joinTime_ = value;
		}
		public long? GetTotalPack(){
			return this.totalPack_;
		}
		
		public void SetTotalPack(long? value){
			this.totalPack_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public int? GetIsPay(){
			return this.isPay_;
		}
		
		public void SetIsPay(int? value){
			this.isPay_ = value;
		}
		public string GetOrderNo(){
			return this.orderNo_;
		}
		
		public void SetOrderNo(string value){
			this.orderNo_ = value;
		}
		public int? GetIsCod(){
			return this.isCod_;
		}
		
		public void SetIsCod(int? value){
			this.isCod_ = value;
		}
		public int? GetResendType(){
			return this.resendType_;
		}
		
		public void SetResendType(int? value){
			this.resendType_ = value;
		}
		public string GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(string value){
			this.userId_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetBuyerAddress(){
			return this.buyerAddress_;
		}
		
		public void SetBuyerAddress(string value){
			this.buyerAddress_ = value;
		}
		public string GetPostCode(){
			return this.postCode_;
		}
		
		public void SetPostCode(string value){
			this.postCode_ = value;
		}
		public string GetBuyerAreaId(){
			return this.buyerAreaId_;
		}
		
		public void SetBuyerAreaId(string value){
			this.buyerAreaId_ = value;
		}
		public string GetBuyerAddress2(){
			return this.buyerAddress2_;
		}
		
		public void SetBuyerAddress2(string value){
			this.buyerAddress2_ = value;
		}
		public string GetBuyerAddress3(){
			return this.buyerAddress3_;
		}
		
		public void SetBuyerAddress3(string value){
			this.buyerAddress3_ = value;
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
		public string GetBuyerTel(){
			return this.buyerTel_;
		}
		
		public void SetBuyerTel(string value){
			this.buyerTel_ = value;
		}
		public int? GetPoType(){
			return this.poType_;
		}
		
		public void SetPoType(int? value){
			this.poType_ = value;
		}
		public string GetPoPeriodValid(){
			return this.poPeriodValid_;
		}
		
		public void SetPoPeriodValid(string value){
			this.poPeriodValid_ = value;
		}
		public string GetPoBuyer(){
			return this.poBuyer_;
		}
		
		public void SetPoBuyer(string value){
			this.poBuyer_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public int? GetTransportId(){
			return this.transportId_;
		}
		
		public void SetTransportId(int? value){
			this.transportId_ = value;
		}
		public string GetTransportType(){
			return this.transportType_;
		}
		
		public void SetTransportType(string value){
			this.transportType_ = value;
		}
		public long? GetAddTime(){
			return this.addTime_;
		}
		
		public void SetAddTime(long? value){
			this.addTime_ = value;
		}
		public string GetPayType(){
			return this.payType_;
		}
		
		public void SetPayType(string value){
			this.payType_ = value;
		}
		public string GetTransportDay(){
			return this.transportDay_;
		}
		
		public void SetTransportDay(string value){
			this.transportDay_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetOrderType(){
			return this.orderType_;
		}
		
		public void SetOrderType(string value){
			this.orderType_ = value;
		}
		public int? GetVipClub(){
			return this.vipClub_;
		}
		
		public void SetVipClub(int? value){
			this.vipClub_ = value;
		}
		public string GetInvoice(){
			return this.invoice_;
		}
		
		public void SetInvoice(string value){
			this.invoice_ = value;
		}
		public double? GetGoodsMoney(){
			return this.goodsMoney_;
		}
		
		public void SetGoodsMoney(double? value){
			this.goodsMoney_ = value;
		}
		public double? GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(double? value){
			this.money_ = value;
		}
		public double? GetAigo(){
			return this.aigo_;
		}
		
		public void SetAigo(double? value){
			this.aigo_ = value;
		}
		public double? GetFavourableMoney(){
			return this.favourableMoney_;
		}
		
		public void SetFavourableMoney(double? value){
			this.favourableMoney_ = value;
		}
		public double? GetExFavMoney(){
			return this.exFavMoney_;
		}
		
		public void SetExFavMoney(double? value){
			this.exFavMoney_ = value;
		}
		public int? GetUserType(){
			return this.userType_;
		}
		
		public void SetUserType(int? value){
			this.userType_ = value;
		}
		public double? GetExPayMoney1(){
			return this.exPayMoney1_;
		}
		
		public void SetExPayMoney1(double? value){
			this.exPayMoney1_ = value;
		}
		public double? GetExPayMoney2(){
			return this.exPayMoney2_;
		}
		
		public void SetExPayMoney2(double? value){
			this.exPayMoney2_ = value;
		}
		public double? GetExPayMoney3(){
			return this.exPayMoney3_;
		}
		
		public void SetExPayMoney3(double? value){
			this.exPayMoney3_ = value;
		}
		public int? GetIsHold(){
			return this.isHold_;
		}
		
		public void SetIsHold(int? value){
			this.isHold_ = value;
		}
		public string GetOldOrderSn(){
			return this.oldOrderSn_;
		}
		
		public void SetOldOrderSn(string value){
			this.oldOrderSn_ = value;
		}
		public int? GetIudFlag(){
			return this.iudFlag_;
		}
		
		public void SetIudFlag(int? value){
			this.iudFlag_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public double? GetOriginalServiceLevel(){
			return this.originalServiceLevel_;
		}
		
		public void SetOriginalServiceLevel(double? value){
			this.originalServiceLevel_ = value;
		}
		public double? GetOriginalVolume(){
			return this.originalVolume_;
		}
		
		public void SetOriginalVolume(double? value){
			this.originalVolume_ = value;
		}
		public string GetOriginalVolumeUnit(){
			return this.originalVolumeUnit_;
		}
		
		public void SetOriginalVolumeUnit(string value){
			this.originalVolumeUnit_ = value;
		}
		public double? GetOriginalWeight(){
			return this.originalWeight_;
		}
		
		public void SetOriginalWeight(double? value){
			this.originalWeight_ = value;
		}
		public string GetOriginalWeightUnit(){
			return this.originalWeightUnit_;
		}
		
		public void SetOriginalWeightUnit(string value){
			this.originalWeightUnit_ = value;
		}
		public double? GetOriginalAmount(){
			return this.originalAmount_;
		}
		
		public void SetOriginalAmount(double? value){
			this.originalAmount_ = value;
		}
		public string GetTransportWorkerName(){
			return this.transportWorkerName_;
		}
		
		public void SetTransportWorkerName(string value){
			this.transportWorkerName_ = value;
		}
		public string GetAmountUnit(){
			return this.amountUnit_;
		}
		
		public void SetAmountUnit(string value){
			this.amountUnit_ = value;
		}
		public int? GetOrderSubType(){
			return this.orderSubType_;
		}
		
		public void SetOrderSubType(int? value){
			this.orderSubType_ = value;
		}
		public int? GetOrderStatus(){
			return this.orderStatus_;
		}
		
		public void SetOrderStatus(int? value){
			this.orderStatus_ = value;
		}
		public string GetSignInMan(){
			return this.signInMan_;
		}
		
		public void SetSignInMan(string value){
			this.signInMan_ = value;
		}
		public int? GetIsAutopicked(){
			return this.isAutopicked_;
		}
		
		public void SetIsAutopicked(int? value){
			this.isAutopicked_ = value;
		}
		public string GetJionCustWorker(){
			return this.jionCustWorker_;
		}
		
		public void SetJionCustWorker(string value){
			this.jionCustWorker_ = value;
		}
		public long? GetAcceptManipulatMatcTime(){
			return this.acceptManipulatMatcTime_;
		}
		
		public void SetAcceptManipulatMatcTime(long? value){
			this.acceptManipulatMatcTime_ = value;
		}
		public long? GetCustNumber(){
			return this.custNumber_;
		}
		
		public void SetCustNumber(long? value){
			this.custNumber_ = value;
		}
		public int? GetIsTrack(){
			return this.isTrack_;
		}
		
		public void SetIsTrack(int? value){
			this.isTrack_ = value;
		}
		public int? GetIsExceptional(){
			return this.isExceptional_;
		}
		
		public void SetIsExceptional(int? value){
			this.isExceptional_ = value;
		}
		public int? GetIsInsurance(){
			return this.isInsurance_;
		}
		
		public void SetIsInsurance(int? value){
			this.isInsurance_ = value;
		}
		public string GetCloseMan(){
			return this.closeMan_;
		}
		
		public void SetCloseMan(string value){
			this.closeMan_ = value;
		}
		public long? GetRejectionTime(){
			return this.rejectionTime_;
		}
		
		public void SetRejectionTime(long? value){
			this.rejectionTime_ = value;
		}
		public long? GetSignInTime(){
			return this.signInTime_;
		}
		
		public void SetSignInTime(long? value){
			this.signInTime_ = value;
		}
		public int? GetIsClosed(){
			return this.isClosed_;
		}
		
		public void SetIsClosed(int? value){
			this.isClosed_ = value;
		}
		public string GetCircularWorkerName(){
			return this.circularWorkerName_;
		}
		
		public void SetCircularWorkerName(string value){
			this.circularWorkerName_ = value;
		}
		public long? GetCloseTime(){
			return this.closeTime_;
		}
		
		public void SetCloseTime(long? value){
			this.closeTime_ = value;
		}
		public string GetCloseManCode(){
			return this.closeManCode_;
		}
		
		public void SetCloseManCode(string value){
			this.closeManCode_ = value;
		}
		public int? GetIsCircular(){
			return this.isCircular_;
		}
		
		public void SetIsCircular(int? value){
			this.isCircular_ = value;
		}
		public string GetCircularWorker(){
			return this.circularWorker_;
		}
		
		public void SetCircularWorker(string value){
			this.circularWorker_ = value;
		}
		public long? GetEta(){
			return this.eta_;
		}
		
		public void SetEta(long? value){
			this.eta_ = value;
		}
		public long? GetAtd(){
			return this.atd_;
		}
		
		public void SetAtd(long? value){
			this.atd_ = value;
		}
		public long? GetCircularTime(){
			return this.circularTime_;
		}
		
		public void SetCircularTime(long? value){
			this.circularTime_ = value;
		}
		public string GetOriCity(){
			return this.oriCity_;
		}
		
		public void SetOriCity(string value){
			this.oriCity_ = value;
		}
		public string GetTmsOriginalOrderId(){
			return this.tmsOriginalOrderId_;
		}
		
		public void SetTmsOriginalOrderId(string value){
			this.tmsOriginalOrderId_ = value;
		}
		public int? GetReturnType(){
			return this.returnType_;
		}
		
		public void SetReturnType(int? value){
			this.returnType_ = value;
		}
		public string GetReturnno(){
			return this.returnno_;
		}
		
		public void SetReturnno(string value){
			this.returnno_ = value;
		}
		public string GetCreatedByUser(){
			return this.createdByUser_;
		}
		
		public void SetCreatedByUser(string value){
			this.createdByUser_ = value;
		}
		public string GetCreatedOffice(){
			return this.createdOffice_;
		}
		
		public void SetCreatedOffice(string value){
			this.createdOffice_ = value;
		}
		public long? GetCreatedDtmLoc(){
			return this.createdDtmLoc_;
		}
		
		public void SetCreatedDtmLoc(long? value){
			this.createdDtmLoc_ = value;
		}
		public string GetCreatedTimeZone(){
			return this.createdTimeZone_;
		}
		
		public void SetCreatedTimeZone(string value){
			this.createdTimeZone_ = value;
		}
		public string GetUpdatedOffice(){
			return this.updatedOffice_;
		}
		
		public void SetUpdatedOffice(string value){
			this.updatedOffice_ = value;
		}
		public string GetUpdatedByUser(){
			return this.updatedByUser_;
		}
		
		public void SetUpdatedByUser(string value){
			this.updatedByUser_ = value;
		}
		public long? GetUpdatedDtmLoc(){
			return this.updatedDtmLoc_;
		}
		
		public void SetUpdatedDtmLoc(long? value){
			this.updatedDtmLoc_ = value;
		}
		public int? GetIsRefuce(){
			return this.isRefuce_;
		}
		
		public void SetIsRefuce(int? value){
			this.isRefuce_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetCurrentDeliveryPoint(){
			return this.currentDeliveryPoint_;
		}
		
		public void SetCurrentDeliveryPoint(string value){
			this.currentDeliveryPoint_ = value;
		}
		public string GetDeliveryPoint(){
			return this.deliveryPoint_;
		}
		
		public void SetDeliveryPoint(string value){
			this.deliveryPoint_ = value;
		}
		public string GetUpdatedTimeZone(){
			return this.updatedTimeZone_;
		}
		
		public void SetUpdatedTimeZone(string value){
			this.updatedTimeZone_ = value;
		}
		public long? GetRecordVersion(){
			return this.recordVersion_;
		}
		
		public void SetRecordVersion(long? value){
			this.recordVersion_ = value;
		}
		public int? GetCustType(){
			return this.custType_;
		}
		
		public void SetCustType(int? value){
			this.custType_ = value;
		}
		public int? GetIsDelete(){
			return this.isDelete_;
		}
		
		public void SetIsDelete(int? value){
			this.isDelete_ = value;
		}
		public string GetAux1(){
			return this.aux1_;
		}
		
		public void SetAux1(string value){
			this.aux1_ = value;
		}
		public string GetAux2(){
			return this.aux2_;
		}
		
		public void SetAux2(string value){
			this.aux2_ = value;
		}
		public string GetAux3(){
			return this.aux3_;
		}
		
		public void SetAux3(string value){
			this.aux3_ = value;
		}
		public string GetAux4(){
			return this.aux4_;
		}
		
		public void SetAux4(string value){
			this.aux4_ = value;
		}
		public string GetAux5(){
			return this.aux5_;
		}
		
		public void SetAux5(string value){
			this.aux5_ = value;
		}
		public int? GetIsFeedBack(){
			return this.isFeedBack_;
		}
		
		public void SetIsFeedBack(int? value){
			this.isFeedBack_ = value;
		}
		public int? GetAutoFreight(){
			return this.autoFreight_;
		}
		
		public void SetAutoFreight(int? value){
			this.autoFreight_ = value;
		}
		public string GetFiscalYear(){
			return this.fiscalYear_;
		}
		
		public void SetFiscalYear(string value){
			this.fiscalYear_ = value;
		}
		public int? GetIsUpdate(){
			return this.isUpdate_;
		}
		
		public void SetIsUpdate(int? value){
			this.isUpdate_ = value;
		}
		public int? GetIsSpecialReturn(){
			return this.isSpecialReturn_;
		}
		
		public void SetIsSpecialReturn(int? value){
			this.isSpecialReturn_ = value;
		}
		public double? GetCustCounterAmount(){
			return this.custCounterAmount_;
		}
		
		public void SetCustCounterAmount(double? value){
			this.custCounterAmount_ = value;
		}
		public double? GetCustClaimAmount(){
			return this.custClaimAmount_;
		}
		
		public void SetCustClaimAmount(double? value){
			this.custClaimAmount_ = value;
		}
		public double? GetInsuranceClaimAmount(){
			return this.insuranceClaimAmount_;
		}
		
		public void SetInsuranceClaimAmount(double? value){
			this.insuranceClaimAmount_ = value;
		}
		public long? GetOqcDate(){
			return this.oqcDate_;
		}
		
		public void SetOqcDate(long? value){
			this.oqcDate_ = value;
		}
		public string GetReturnGoodsContact(){
			return this.returnGoodsContact_;
		}
		
		public void SetReturnGoodsContact(string value){
			this.returnGoodsContact_ = value;
		}
		public string GetReturnGoodsPhone(){
			return this.returnGoodsPhone_;
		}
		
		public void SetReturnGoodsPhone(string value){
			this.returnGoodsPhone_ = value;
		}
		public int? GetReturnGoodsType(){
			return this.returnGoodsType_;
		}
		
		public void SetReturnGoodsType(int? value){
			this.returnGoodsType_ = value;
		}
		public string GetBrand(){
			return this.brand_;
		}
		
		public void SetBrand(string value){
			this.brand_ = value;
		}
		public string GetMerchantsInterface(){
			return this.merchantsInterface_;
		}
		
		public void SetMerchantsInterface(string value){
			this.merchantsInterface_ = value;
		}
		public string GetMerchantsInterfacePhone(){
			return this.merchantsInterfacePhone_;
		}
		
		public void SetMerchantsInterfacePhone(string value){
			this.merchantsInterfacePhone_ = value;
		}
		public string GetReturnSpecialRequirements(){
			return this.returnSpecialRequirements_;
		}
		
		public void SetReturnSpecialRequirements(string value){
			this.returnSpecialRequirements_ = value;
		}
		public int? GetPayment(){
			return this.payment_;
		}
		
		public void SetPayment(int? value){
			this.payment_ = value;
		}
		public string GetReturnVendorContact(){
			return this.returnVendorContact_;
		}
		
		public void SetReturnVendorContact(string value){
			this.returnVendorContact_ = value;
		}
		public int? GetDeliveryMode(){
			return this.deliveryMode_;
		}
		
		public void SetDeliveryMode(int? value){
			this.deliveryMode_ = value;
		}
		public string GetReceivedUnit(){
			return this.receivedUnit_;
		}
		
		public void SetReceivedUnit(string value){
			this.receivedUnit_ = value;
		}
		public int? GetTransportMode(){
			return this.transportMode_;
		}
		
		public void SetTransportMode(int? value){
			this.transportMode_ = value;
		}
		public string GetDeliverGoodsManLink(){
			return this.deliverGoodsManLink_;
		}
		
		public void SetDeliverGoodsManLink(string value){
			this.deliverGoodsManLink_ = value;
		}
		public string GetDeliverGoodsManPhone(){
			return this.deliverGoodsManPhone_;
		}
		
		public void SetDeliverGoodsManPhone(string value){
			this.deliverGoodsManPhone_ = value;
		}
		public int? GetIsInStation(){
			return this.isInStation_;
		}
		
		public void SetIsInStation(int? value){
			this.isInStation_ = value;
		}
		public string GetBuyTown(){
			return this.buyTown_;
		}
		
		public void SetBuyTown(string value){
			this.buyTown_ = value;
		}
		public int? GetCancelStatus(){
			return this.cancelStatus_;
		}
		
		public void SetCancelStatus(int? value){
			this.cancelStatus_ = value;
		}
		public string GetWayOfSettlement(){
			return this.wayOfSettlement_;
		}
		
		public void SetWayOfSettlement(string value){
			this.wayOfSettlement_ = value;
		}
		public long? GetLdpJoinTime(){
			return this.ldpJoinTime_;
		}
		
		public void SetLdpJoinTime(long? value){
			this.ldpJoinTime_ = value;
		}
		public string GetReBillingRemark(){
			return this.reBillingRemark_;
		}
		
		public void SetReBillingRemark(string value){
			this.reBillingRemark_ = value;
		}
		public int? GetExtPayType(){
			return this.extPayType_;
		}
		
		public void SetExtPayType(int? value){
			this.extPayType_ = value;
		}
		public long? GetAppraisedTime(){
			return this.appraisedTime_;
		}
		
		public void SetAppraisedTime(long? value){
			this.appraisedTime_ = value;
		}
		public string GetOrderBatchNo(){
			return this.orderBatchNo_;
		}
		
		public void SetOrderBatchNo(string value){
			this.orderBatchNo_ = value;
		}
		public string GetOrderMainCust(){
			return this.orderMainCust_;
		}
		
		public void SetOrderMainCust(string value){
			this.orderMainCust_ = value;
		}
		public string GetB2cUserName(){
			return this.b2cUserName_;
		}
		
		public void SetB2cUserName(string value){
			this.b2cUserName_ = value;
		}
		public string GetMergeOrderSns(){
			return this.mergeOrderSns_;
		}
		
		public void SetMergeOrderSns(string value){
			this.mergeOrderSns_ = value;
		}
		public string GetMergeParentOrderSn(){
			return this.mergeParentOrderSn_;
		}
		
		public void SetMergeParentOrderSn(string value){
			this.mergeParentOrderSn_ = value;
		}
		public string GetMergeParentOrderNo(){
			return this.mergeParentOrderNo_;
		}
		
		public void SetMergeParentOrderNo(string value){
			this.mergeParentOrderNo_ = value;
		}
		public int? GetMergeFlag(){
			return this.mergeFlag_;
		}
		
		public void SetMergeFlag(int? value){
			this.mergeFlag_ = value;
		}
		public string GetTempCustCode(){
			return this.tempCustCode_;
		}
		
		public void SetTempCustCode(string value){
			this.tempCustCode_ = value;
		}
		public short? GetIsSecondMatch(){
			return this.isSecondMatch_;
		}
		
		public void SetIsSecondMatch(short? value){
			this.isSecondMatch_ = value;
		}
		public bool? GetIsSecondMatchAppraise(){
			return this.isSecondMatchAppraise_;
		}
		
		public void SetIsSecondMatchAppraise(bool? value){
			this.isSecondMatchAppraise_ = value;
		}
		public long? GetSecondMatchAppraiseTime(){
			return this.secondMatchAppraiseTime_;
		}
		
		public void SetSecondMatchAppraiseTime(long? value){
			this.secondMatchAppraiseTime_ = value;
		}
		public int? GetIsIntercept(){
			return this.isIntercept_;
		}
		
		public void SetIsIntercept(int? value){
			this.isIntercept_ = value;
		}
		public string GetInterceptOperator(){
			return this.interceptOperator_;
		}
		
		public void SetInterceptOperator(string value){
			this.interceptOperator_ = value;
		}
		public long? GetInterceptTime(){
			return this.interceptTime_;
		}
		
		public void SetInterceptTime(long? value){
			this.interceptTime_ = value;
		}
		public string GetCrmCustPointId(){
			return this.crmCustPointId_;
		}
		
		public void SetCrmCustPointId(string value){
			this.crmCustPointId_ = value;
		}
		public byte? GetIsPrint(){
			return this.isPrint_;
		}
		
		public void SetIsPrint(byte? value){
			this.isPrint_ = value;
		}
		public byte? GetServiceType(){
			return this.serviceType_;
		}
		
		public void SetServiceType(byte? value){
			this.serviceType_ = value;
		}
		public string GetCustomerCode(){
			return this.customerCode_;
		}
		
		public void SetCustomerCode(string value){
			this.customerCode_ = value;
		}
		public string GetSendAddress(){
			return this.sendAddress_;
		}
		
		public void SetSendAddress(string value){
			this.sendAddress_ = value;
		}
		public byte? GetDispatchStatus(){
			return this.dispatchStatus_;
		}
		
		public void SetDispatchStatus(byte? value){
			this.dispatchStatus_ = value;
		}
		public long? GetDispatchDate(){
			return this.dispatchDate_;
		}
		
		public void SetDispatchDate(long? value){
			this.dispatchDate_ = value;
		}
		public double? GetMbpCompensationAmount(){
			return this.mbpCompensationAmount_;
		}
		
		public void SetMbpCompensationAmount(double? value){
			this.mbpCompensationAmount_ = value;
		}
		public string GetSalesPlatform(){
			return this.salesPlatform_;
		}
		
		public void SetSalesPlatform(string value){
			this.salesPlatform_ = value;
		}
		public string GetCarrierPointName(){
			return this.carrierPointName_;
		}
		
		public void SetCarrierPointName(string value){
			this.carrierPointName_ = value;
		}
		public string GetCarrierPointCode(){
			return this.carrierPointCode_;
		}
		
		public void SetCarrierPointCode(string value){
			this.carrierPointCode_ = value;
		}
		public string GetCarrierPointCustCode(){
			return this.carrierPointCustCode_;
		}
		
		public void SetCarrierPointCustCode(string value){
			this.carrierPointCustCode_ = value;
		}
		public string GetOfficeName(){
			return this.officeName_;
		}
		
		public void SetOfficeName(string value){
			this.officeName_ = value;
		}
		public string GetOfficeOutName(){
			return this.officeOutName_;
		}
		
		public void SetOfficeOutName(string value){
			this.officeOutName_ = value;
		}
		public string GetContact(){
			return this.contact_;
		}
		
		public void SetContact(string value){
			this.contact_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public string GetOfficeCode(){
			return this.officeCode_;
		}
		
		public void SetOfficeCode(string value){
			this.officeCode_ = value;
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
		public string GetCountryCode(){
			return this.countryCode_;
		}
		
		public void SetCountryCode(string value){
			this.countryCode_ = value;
		}
		public string GetRegionCode(){
			return this.regionCode_;
		}
		
		public void SetRegionCode(string value){
			this.regionCode_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		
	}
	
}