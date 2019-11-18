using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class OdsOrderMessage {
		
		///<summary>
		/// 订单生成的国外时间（海外站），日期格式为MMM dd, yyyy HH:mm:ss aaa，例如：Jan 8, 2014 10:20:26 PM
		///</summary>
		
		private string addLocalTime_;
		
		///<summary>
		/// 用户提交订单时间
		///</summary>
		
		private string addTime_;
		
		///<summary>
		/// 收货人地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 顾客地址行2
		///</summary>
		
		private string address2_;
		
		///<summary>
		/// 顾客地址行3
		///</summary>
		
		private string address3_;
		
		///<summary>
		/// 顾客地址行4
		///</summary>
		
		private string address4_;
		
		///<summary>
		/// 地址标识，由B2C创建，枚举值：0，空；1，家庭地址；2，公司地址；3，其他地址；
		///</summary>
		
		private string addressType_;
		
		///<summary>
		/// 折扣比例，如果没有折扣，或无需发票，写1.000
		///</summary>
		
		private double? aigo_;
		
		///<summary>
		/// 区域码，依省/市/区/镇 分级，除了海外订单/多渠道订单，其他订单的area_id位数=12。
		///</summary>
		
		private string areaId_;
		
		///<summary>
		/// 收货人
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 快递费用
		///</summary>
		
		private double? carriage_;
		
		///<summary>
		/// 城市，没有值时填入 ‘-’。
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 国家，Ex：CN, US, JP。
		///</summary>
		
		private string countryId_;
		
		///<summary>
		/// B2C订单创建时间
		///</summary>
		
		private string createTime_;
		
		///<summary>
		/// 货币符号
		///</summary>
		
		private string currencySymbol_;
		
		///<summary>
		/// 顾客邮箱
		///</summary>
		
		private string customerEmail_;
		
		///<summary>
		/// EDB标识
		///</summary>
		
		private string edbId_;
		
		///<summary>
		/// ERP单号
		///</summary>
		
		private string erpOrderSn_;
		
		///<summary>
		/// 促销优惠金额，如：大促满300减100满减优惠
		///</summary>
		
		private double? exFavMoney_;
		
		///<summary>
		/// 发票金额
		///</summary>
		
		private double? exPayMoney1_;
		
		///<summary>
		/// 积分支付金额
		///</summary>
		
		private double? exPayMoney2_;
		
		///<summary>
		/// (预留字段)
		///</summary>
		
		private double? exPayMoney3_;
		
		///<summary>
		/// 扩展支付类型，用来描述到付的支付方式：0-现金，1-POS机，2-支付宝APP。
		///</summary>
		
		private string extPayType_;
		
		///<summary>
		/// 优惠金额，例如使用了礼品卡,唯品卡,代金券。
		///</summary>
		
		private double? favourableMoney_;
		
		///<summary>
		/// 单据金额，整张出库单商品的金额总和。
		///</summary>
		
		private double? goodsMoney_;
		
		///<summary>
		/// 发票抬头
		///</summary>
		
		private string invoice_;
		
		///<summary>
		/// 保留标识，0-不保留，1-保留。
		///</summary>
		
		private int? isHold_;
		
		///<summary>
		/// 清单是否打印价格，0	打印金额，1不打印金额，默认为0。
		///</summary>
		
		private int? isPrintingPrice_;
		
		///<summary>
		/// 最后下发订单时间，格式为yyyy-MM-dd HH:mm:ss。
		///</summary>
		
		private string lastOrderTime_;
		
		///<summary>
		/// 移动电话
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 应收金额=(商品金额 x 折扣比例) + 运费 - 优惠金额 - 其余优惠金额 - 线上支付金额
		///</summary>
		
		private double? money_;
		
		///<summary>
		/// 原始订单码
		///</summary>
		
		private string oldOrderSn_;
		
		///<summary>
		/// 对应的订单流水号
		///</summary>
		
		private long? orderId_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 类型说明，OUTBOUND-销售出库
		///</summary>
		
		private string orderType_;
		
		///<summary>
		/// 支付方式，1-银行卡支付，2-信用卡支付，3支付宝...
		///</summary>
		
		private string payType_;
		
		///<summary>
		/// 邮政编码
		///</summary>
		
		private string postCode_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 订单类型，0-一般订单，1-JIT，2供应商直发...
		///</summary>
		
		private int? saleType_;
		
		///<summary>
		/// 销售平台，中文描述，比如京东商城、淘宝商城、淘宝等。
		///</summary>
		
		private string salesPlatform_;
		
		///<summary>
		/// 预留字段
		///</summary>
		
		private string scheduledSellingId_;
		
		///<summary>
		/// 预留字段
		///</summary>
		
		private string seqDataId_;
		
		///<summary>
		/// 客服电话，第三方下发客服电话到WMS。
		///</summary>
		
		private string servicePhone_;
		
		///<summary>
		/// 省份
		///</summary>
		
		private string state_;
		
		///<summary>
		/// 唯品钱包支付金额
		///</summary>
		
		private double? surplus_;
		
		///<summary>
		/// 联系电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 第三方单号，例如淘宝订单号。
		///</summary>
		
		private string thirdOrderSn_;
		
		///<summary>
		/// 订单状态（新增、修改、取消），003建主订单;090修改订单；转业务时只处理003或090。
		///</summary>
		
		private string tmsOrderStatus_;
		
		///<summary>
		/// 配送时间要求，只双休日/节假日送货(工作日不用送)，只工作日(双休日/节假日不用送)，只晚上送货(白天不用送)，送货时间不限。
		///</summary>
		
		private string transportDay_;
		
		///<summary>
		/// 运送方式说明
		///</summary>
		
		private string transportId_;
		
		///<summary>
		/// 配送时间要求，2-白天配送，3	-全天配送（含夜间）
		///</summary>
		
		private int? transportTime_;
		
		///<summary>
		/// 承载物类型，例如：航空禁运品，男装、精品...
		///</summary>
		
		private string transportType_;
		
		///<summary>
		/// 下单人
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 用户名（下单人姓名）
		///</summary>
		
		private string userName_;
		
		///<summary>
		/// 顾客类型，1-新客户，2-VIP，3-普通客户，4-糯米網。
		///</summary>
		
		private string userType_;
		
		///<summary>
		/// 顾客类型名称
		///</summary>
		
		private string userTypeName_;
		
		///<summary>
		/// 订单类型，1-普通订单，i-海外站订单...
		///</summary>
		
		private string vipclub_;
		
		///<summary>
		/// 订单类型名称
		///</summary>
		
		private string vipclubName_;
		
		///<summary>
		/// 发货仓
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 客退详细地址（外文）
		///</summary>
		
		private string withdrawAddress_;
		
		///<summary>
		/// 母订单号，在OXO的场景下，客户下单后会执行拆单操作，所有子订单都挂载在母订单中。
		///</summary>
		
		private string parentOrderSn_;
		
		///<summary>
		/// 订单流水号
		///</summary>
		
		private string id_;
		
		///<summary>
		/// Ods下发订单信息明细对象
		///</summary>
		
		private List<com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail> detail_;
		
		///<summary>
		/// 区域小仓编码
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		///</summary>
		
		private string incoterm_;
		
		///<summary>
		///</summary>
		
		private string includeNoGood_;
		
		///<summary>
		/// 揽换申请单号
		///</summary>
		
		private string exchangeBackSn_;
		
		///<summary>
		/// 服务类型.0-默认,1-212,2-次日达
		///</summary>
		
		private int? deliveryType_;
		
		///<summary>
		/// 慢必赔标识.0-不是.1-是
		///</summary>
		
		private int? isDelayCompensate_;
		
		///<summary>
		/// 预计送达时间
		///</summary>
		
		private System.DateTime? deliveryPromisedTime_;
		
		///<summary>
		/// 产品服务
		///</summary>
		
		private string productCode_;
		
		///<summary>
		/// 寄件人姓名
		///</summary>
		
		private string senderName_;
		
		///<summary>
		/// 寄件人电话
		///</summary>
		
		private string senderTelephone_;
		
		///<summary>
		/// 寄件人手机
		///</summary>
		
		private string senderMobilePhone_;
		
		///<summary>
		/// 寄件人详细地址
		///</summary>
		
		private string senderAddress_;
		
		///<summary>
		/// 寄件人省编码
		///</summary>
		
		private string senderProvince_;
		
		///<summary>
		/// 寄件人市编码
		///</summary>
		
		private string senderCity_;
		
		///<summary>
		/// 寄件人区/县编码
		///</summary>
		
		private string senderCountry_;
		
		///<summary>
		/// 寄件人镇/街道编码
		///</summary>
		
		private string senderStreet_;
		
		///<summary>
		/// 寄件人邮编
		///</summary>
		
		private string senderZipCode_;
		
		///<summary>
		/// 订单业务类型 1：普通订单 2：医药订单
		///</summary>
		
		private int? orderBizType_;
		
		///<summary>
		/// 特殊配送标识 0非特殊配送  1特殊配送
		///</summary>
		
		private int? isSpecialDelivery_;
		
		///<summary>
		/// 计费母单号
		///</summary>
		
		private string originalParentOrderSn_;
		
		///<summary>
		/// 业务标识
		///</summary>
		
		private string odsOrderBizFlags_;
		
		///<summary>
		/// 业务类型，O或为空表示订单，S表示订单状态
		///</summary>
		
		private string businessType_;
		
		///<summary>
		/// 订单状态，business_type为S时，必定有值；023取消；025修改单头；030打包状态
		///</summary>
		
		private string orderStatus_;
		
		///<summary>
		/// 更新时间，格式：yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string updateTime_;
		
		public string GetAddLocalTime(){
			return this.addLocalTime_;
		}
		
		public void SetAddLocalTime(string value){
			this.addLocalTime_ = value;
		}
		public string GetAddTime(){
			return this.addTime_;
		}
		
		public void SetAddTime(string value){
			this.addTime_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetAddress2(){
			return this.address2_;
		}
		
		public void SetAddress2(string value){
			this.address2_ = value;
		}
		public string GetAddress3(){
			return this.address3_;
		}
		
		public void SetAddress3(string value){
			this.address3_ = value;
		}
		public string GetAddress4(){
			return this.address4_;
		}
		
		public void SetAddress4(string value){
			this.address4_ = value;
		}
		public string GetAddressType(){
			return this.addressType_;
		}
		
		public void SetAddressType(string value){
			this.addressType_ = value;
		}
		public double? GetAigo(){
			return this.aigo_;
		}
		
		public void SetAigo(double? value){
			this.aigo_ = value;
		}
		public string GetAreaId(){
			return this.areaId_;
		}
		
		public void SetAreaId(string value){
			this.areaId_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public double? GetCarriage(){
			return this.carriage_;
		}
		
		public void SetCarriage(double? value){
			this.carriage_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetCountryId(){
			return this.countryId_;
		}
		
		public void SetCountryId(string value){
			this.countryId_ = value;
		}
		public string GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(string value){
			this.createTime_ = value;
		}
		public string GetCurrencySymbol(){
			return this.currencySymbol_;
		}
		
		public void SetCurrencySymbol(string value){
			this.currencySymbol_ = value;
		}
		public string GetCustomerEmail(){
			return this.customerEmail_;
		}
		
		public void SetCustomerEmail(string value){
			this.customerEmail_ = value;
		}
		public string GetEdbId(){
			return this.edbId_;
		}
		
		public void SetEdbId(string value){
			this.edbId_ = value;
		}
		public string GetErpOrderSn(){
			return this.erpOrderSn_;
		}
		
		public void SetErpOrderSn(string value){
			this.erpOrderSn_ = value;
		}
		public double? GetExFavMoney(){
			return this.exFavMoney_;
		}
		
		public void SetExFavMoney(double? value){
			this.exFavMoney_ = value;
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
		public string GetExtPayType(){
			return this.extPayType_;
		}
		
		public void SetExtPayType(string value){
			this.extPayType_ = value;
		}
		public double? GetFavourableMoney(){
			return this.favourableMoney_;
		}
		
		public void SetFavourableMoney(double? value){
			this.favourableMoney_ = value;
		}
		public double? GetGoodsMoney(){
			return this.goodsMoney_;
		}
		
		public void SetGoodsMoney(double? value){
			this.goodsMoney_ = value;
		}
		public string GetInvoice(){
			return this.invoice_;
		}
		
		public void SetInvoice(string value){
			this.invoice_ = value;
		}
		public int? GetIsHold(){
			return this.isHold_;
		}
		
		public void SetIsHold(int? value){
			this.isHold_ = value;
		}
		public int? GetIsPrintingPrice(){
			return this.isPrintingPrice_;
		}
		
		public void SetIsPrintingPrice(int? value){
			this.isPrintingPrice_ = value;
		}
		public string GetLastOrderTime(){
			return this.lastOrderTime_;
		}
		
		public void SetLastOrderTime(string value){
			this.lastOrderTime_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public double? GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(double? value){
			this.money_ = value;
		}
		public string GetOldOrderSn(){
			return this.oldOrderSn_;
		}
		
		public void SetOldOrderSn(string value){
			this.oldOrderSn_ = value;
		}
		public long? GetOrderId(){
			return this.orderId_;
		}
		
		public void SetOrderId(long? value){
			this.orderId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetOrderType(){
			return this.orderType_;
		}
		
		public void SetOrderType(string value){
			this.orderType_ = value;
		}
		public string GetPayType(){
			return this.payType_;
		}
		
		public void SetPayType(string value){
			this.payType_ = value;
		}
		public string GetPostCode(){
			return this.postCode_;
		}
		
		public void SetPostCode(string value){
			this.postCode_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public int? GetSaleType(){
			return this.saleType_;
		}
		
		public void SetSaleType(int? value){
			this.saleType_ = value;
		}
		public string GetSalesPlatform(){
			return this.salesPlatform_;
		}
		
		public void SetSalesPlatform(string value){
			this.salesPlatform_ = value;
		}
		public string GetScheduledSellingId(){
			return this.scheduledSellingId_;
		}
		
		public void SetScheduledSellingId(string value){
			this.scheduledSellingId_ = value;
		}
		public string GetSeqDataId(){
			return this.seqDataId_;
		}
		
		public void SetSeqDataId(string value){
			this.seqDataId_ = value;
		}
		public string GetServicePhone(){
			return this.servicePhone_;
		}
		
		public void SetServicePhone(string value){
			this.servicePhone_ = value;
		}
		public string GetState(){
			return this.state_;
		}
		
		public void SetState(string value){
			this.state_ = value;
		}
		public double? GetSurplus(){
			return this.surplus_;
		}
		
		public void SetSurplus(double? value){
			this.surplus_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public string GetThirdOrderSn(){
			return this.thirdOrderSn_;
		}
		
		public void SetThirdOrderSn(string value){
			this.thirdOrderSn_ = value;
		}
		public string GetTmsOrderStatus(){
			return this.tmsOrderStatus_;
		}
		
		public void SetTmsOrderStatus(string value){
			this.tmsOrderStatus_ = value;
		}
		public string GetTransportDay(){
			return this.transportDay_;
		}
		
		public void SetTransportDay(string value){
			this.transportDay_ = value;
		}
		public string GetTransportId(){
			return this.transportId_;
		}
		
		public void SetTransportId(string value){
			this.transportId_ = value;
		}
		public int? GetTransportTime(){
			return this.transportTime_;
		}
		
		public void SetTransportTime(int? value){
			this.transportTime_ = value;
		}
		public string GetTransportType(){
			return this.transportType_;
		}
		
		public void SetTransportType(string value){
			this.transportType_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetUserName(){
			return this.userName_;
		}
		
		public void SetUserName(string value){
			this.userName_ = value;
		}
		public string GetUserType(){
			return this.userType_;
		}
		
		public void SetUserType(string value){
			this.userType_ = value;
		}
		public string GetUserTypeName(){
			return this.userTypeName_;
		}
		
		public void SetUserTypeName(string value){
			this.userTypeName_ = value;
		}
		public string GetVipclub(){
			return this.vipclub_;
		}
		
		public void SetVipclub(string value){
			this.vipclub_ = value;
		}
		public string GetVipclubName(){
			return this.vipclubName_;
		}
		
		public void SetVipclubName(string value){
			this.vipclubName_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetWithdrawAddress(){
			return this.withdrawAddress_;
		}
		
		public void SetWithdrawAddress(string value){
			this.withdrawAddress_ = value;
		}
		public string GetParentOrderSn(){
			return this.parentOrderSn_;
		}
		
		public void SetParentOrderSn(string value){
			this.parentOrderSn_ = value;
		}
		public string GetId(){
			return this.id_;
		}
		
		public void SetId(string value){
			this.id_ = value;
		}
		public List<com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail> GetDetail(){
			return this.detail_;
		}
		
		public void SetDetail(List<com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail> value){
			this.detail_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public string GetIncoterm(){
			return this.incoterm_;
		}
		
		public void SetIncoterm(string value){
			this.incoterm_ = value;
		}
		public string GetIncludeNoGood(){
			return this.includeNoGood_;
		}
		
		public void SetIncludeNoGood(string value){
			this.includeNoGood_ = value;
		}
		public string GetExchangeBackSn(){
			return this.exchangeBackSn_;
		}
		
		public void SetExchangeBackSn(string value){
			this.exchangeBackSn_ = value;
		}
		public int? GetDeliveryType(){
			return this.deliveryType_;
		}
		
		public void SetDeliveryType(int? value){
			this.deliveryType_ = value;
		}
		public int? GetIsDelayCompensate(){
			return this.isDelayCompensate_;
		}
		
		public void SetIsDelayCompensate(int? value){
			this.isDelayCompensate_ = value;
		}
		public System.DateTime? GetDeliveryPromisedTime(){
			return this.deliveryPromisedTime_;
		}
		
		public void SetDeliveryPromisedTime(System.DateTime? value){
			this.deliveryPromisedTime_ = value;
		}
		public string GetProductCode(){
			return this.productCode_;
		}
		
		public void SetProductCode(string value){
			this.productCode_ = value;
		}
		public string GetSenderName(){
			return this.senderName_;
		}
		
		public void SetSenderName(string value){
			this.senderName_ = value;
		}
		public string GetSenderTelephone(){
			return this.senderTelephone_;
		}
		
		public void SetSenderTelephone(string value){
			this.senderTelephone_ = value;
		}
		public string GetSenderMobilePhone(){
			return this.senderMobilePhone_;
		}
		
		public void SetSenderMobilePhone(string value){
			this.senderMobilePhone_ = value;
		}
		public string GetSenderAddress(){
			return this.senderAddress_;
		}
		
		public void SetSenderAddress(string value){
			this.senderAddress_ = value;
		}
		public string GetSenderProvince(){
			return this.senderProvince_;
		}
		
		public void SetSenderProvince(string value){
			this.senderProvince_ = value;
		}
		public string GetSenderCity(){
			return this.senderCity_;
		}
		
		public void SetSenderCity(string value){
			this.senderCity_ = value;
		}
		public string GetSenderCountry(){
			return this.senderCountry_;
		}
		
		public void SetSenderCountry(string value){
			this.senderCountry_ = value;
		}
		public string GetSenderStreet(){
			return this.senderStreet_;
		}
		
		public void SetSenderStreet(string value){
			this.senderStreet_ = value;
		}
		public string GetSenderZipCode(){
			return this.senderZipCode_;
		}
		
		public void SetSenderZipCode(string value){
			this.senderZipCode_ = value;
		}
		public int? GetOrderBizType(){
			return this.orderBizType_;
		}
		
		public void SetOrderBizType(int? value){
			this.orderBizType_ = value;
		}
		public int? GetIsSpecialDelivery(){
			return this.isSpecialDelivery_;
		}
		
		public void SetIsSpecialDelivery(int? value){
			this.isSpecialDelivery_ = value;
		}
		public string GetOriginalParentOrderSn(){
			return this.originalParentOrderSn_;
		}
		
		public void SetOriginalParentOrderSn(string value){
			this.originalParentOrderSn_ = value;
		}
		public string GetOdsOrderBizFlags(){
			return this.odsOrderBizFlags_;
		}
		
		public void SetOdsOrderBizFlags(string value){
			this.odsOrderBizFlags_ = value;
		}
		public string GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(string value){
			this.businessType_ = value;
		}
		public string GetOrderStatus(){
			return this.orderStatus_;
		}
		
		public void SetOrderStatus(string value){
			this.orderStatus_ = value;
		}
		public string GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(string value){
			this.updateTime_ = value;
		}
		
	}
	
}