using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class VendorBillGoodsSource {
		
		///<summary>
		/// 全局唯一ID
		///</summary>
		
		private long? globalId_;
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private long? vendorId_;
		
		///<summary>
		/// 供应商编码（分库字段），原vendor_number
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 出仓组织
		///</summary>
		
		private string orgId_;
		
		///<summary>
		/// 业务实体名称
		///</summary>
		
		private string orgName_;
		
		///<summary>
		/// 业务实体名称
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 采购档期
		///</summary>
		
		private string scheduleId_;
		
		///<summary>
		/// 采购档期
		///</summary>
		
		private string scheduleName_;
		
		///<summary>
		/// 专场ID,销售专场，如果有多个专场则以分号分隔
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 专场名称
		///</summary>
		
		private string vBrandName_;
		
		///<summary>
		/// PO编号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// PO创建时间
		///</summary>
		
		private string poCreationDate_;
		
		///<summary>
		/// 品骏3PL原始PO号
		///</summary>
		
		private string origPoNo_;
		
		///<summary>
		/// SO号
		///</summary>
		
		private string orderNum_;
		
		///<summary>
		/// SO单的下单日期
		///</summary>
		
		private string orderDate_;
		
		///<summary>
		/// SKU(商品条码)
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// SKU名称
		///</summary>
		
		private string itemDescription_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string goodsNo_;
		
		///<summary>
		/// 品牌代码
		///</summary>
		
		private string brandCode_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 事务处理数量，所有数据均为正数。结合dataSign使用。
		///</summary>
		
		private double? transactionQuantity_;
		
		///<summary>
		/// 数据标识，1，-1,0。对应客退该值为-1
		///</summary>
		
		private int? dataSign_;
		
		///<summary>
		/// B2C售卖价，原attribute20,默认不提供
		///</summary>
		
		private string orderPrice_;
		
		///<summary>
		/// 结算币种
		///</summary>
		
		private string currencyCode_;
		
		///<summary>
		/// 税率，小数展示，如0.17代表17%税率，0.11代表11%税率.
		///</summary>
		
		private string taxRate_;
		
		///<summary>
		/// 账单期间，账单的生成期间。
		///</summary>
		
		private string periodName_;
		
		///<summary>
		/// 事务处理类型ID
		///</summary>
		
		private string transactionTypeId_;
		
		///<summary>
		/// 事务处理日期
		///</summary>
		
		private System.DateTime? transactionDate_;
		
		///<summary>
		/// 应付,结算不含税金额(转为po币种金额)
		///</summary>
		
		private double? payableBillAmount_;
		
		///<summary>
		/// 供应商承担比例。指固定比例补偿折扣的供应商承担比例。
		///</summary>
		
		private double? vendorRate_;
		
		///<summary>
		/// 活动确认函编号，固定比例返利确认函
		///</summary>
		
		private string confirmNo_;
		
		///<summary>
		/// 销售渠道英文简称
		///</summary>
		
		private string salePlatform_;
		
		///<summary>
		/// 销售渠道全称
		///</summary>
		
		private string salePlatformName_;
		
		///<summary>
		/// 记录创建时间
		///</summary>
		
		private System.DateTime? createdTime_;
		
		///<summary>
		/// 记录修改时间
		///</summary>
		
		private System.DateTime? updatedTime_;
		
		///<summary>
		/// 软删除标识（0:未删除,1:已删除）
		///</summary>
		
		private short? isDeleted_;
		
		///<summary>
		/// 扣点。扣点模式结算的扣点。
		///</summary>
		
		private string grossMarginRate_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// PO不含税价
		///</summary>
		
		private double? poPrice_;
		
		///<summary>
		/// PO含税价
		///</summary>
		
		private double? poTaxPrice_;
		
		///<summary>
		/// 应付，结算含税金额
		///</summary>
		
		private double? payableTotalBillAmount_;
		
		///<summary>
		/// 行类型,该字段用于区分行类型：（括号内表示含义）
		///DR_SUP（入库）
		///CR_SUP（退供），
		///DR_CUST（客退），
		///OTHER（其他），
		///CR_CUST（销售），
		///DR_CUST_EXTRA（跨月客退），
		///NLC（国检折让），
		///REBATE（补偿折扣），
		///RMA（客退折让），
		///SUBSIDY（客退补贴），
		///VRET（来货差异），
		///VI（转VI），
		///CR_CUST_DISCOUNT（销售优惠），
		///DR_CUST_DISCOUNT（客退优惠），
		///OTHER-LENT2（样品借出），
		///OTHER-RETURN2（样品归还），
		///OTHER-SHORTAGE2（库存盘亏），
		///OTHER-OVERAGE2（库存盘盈），
		///OTHER-INSPECT_IN2（国检入库），
		///OTHER-INSPECT_OUT2（国检出库），
		///OTHER-SCRAP2（报废）
		///</summary>
		
		private string detailLineType_;
		
		///<summary>
		/// 价格协议号
		///</summary>
		
		private string priceContractNum_;
		
		///<summary>
		/// 结算不含税价
		///</summary>
		
		private double? billPrice_;
		
		///<summary>
		/// 结算含税价
		///</summary>
		
		private double? billTaxPrice_;
		
		///<summary>
		/// 事务处理创建日期
		///</summary>
		
		private System.DateTime? trxCreationDate_;
		
		///<summary>
		/// 应付，结算数量
		///</summary>
		
		private double? payableQuantity_;
		
		///<summary>
		/// 事务处理类型指令
		///</summary>
		
		private string transactionTypeCommand_;
		
		///<summary>
		/// 可付，结算数量
		///</summary>
		
		private double? billQuantity_;
		
		///<summary>
		/// 可付，结算不含税金额
		///</summary>
		
		private double? billAmount_;
		
		///<summary>
		/// 可付，结算含税金额
		///</summary>
		
		private double? totalBillAmount_;
		
		///<summary>
		/// 品骏3PL原始PO号或VO号
		///</summary>
		
		private string poNoRef_;
		
		///<summary>
		/// 参考号-换货的原单号
		///</summary>
		
		private string referenceNumber_;
		
		///<summary>
		/// 换货标记 Y（是） N（否）
		///</summary>
		
		private string exchangeFlag_;
		
		///<summary>
		/// 原始不含税金额。指扣除固定比例的补偿折扣前的不含税金额。
		///</summary>
		
		private double? transactionAmount_;
		
		///<summary>
		/// 原始含税金额。指扣除固定不利的补偿折扣前的含税金额。
		///</summary>
		
		private double? totalTransactionAmount_;
		
		///<summary>
		/// 是否快抢标识, Y-是，N-不是
		///</summary>
		
		private string activeNewRuleFlag_;
		
		///<summary>
		/// 活动到手价
		///</summary>
		
		private string activeOrderPrice_;
		
		///<summary>
		/// 活动类型
		///</summary>
		
		private string activeType_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string activeName_;
		
		///<summary>
		/// 档期拆分唯一性ID,档期拆分唯一性ID，用于串联货款表和优惠表，注意一个inv_global_id可能存在多条优惠表记录
		///</summary>
		
		private long? invGlobalId_;
		
		///<summary>
		/// 来源行类型,来源行类型， 即账单来源明细类型的子类型
		///</summary>
		
		private string sourceLineType_;
		
		public long? GetGlobalId(){
			return this.globalId_;
		}
		
		public void SetGlobalId(long? value){
			this.globalId_ = value;
		}
		public long? GetVendorId(){
			return this.vendorId_;
		}
		
		public void SetVendorId(long? value){
			this.vendorId_ = value;
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
		public string GetOrgId(){
			return this.orgId_;
		}
		
		public void SetOrgId(string value){
			this.orgId_ = value;
		}
		public string GetOrgName(){
			return this.orgName_;
		}
		
		public void SetOrgName(string value){
			this.orgName_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetScheduleId(){
			return this.scheduleId_;
		}
		
		public void SetScheduleId(string value){
			this.scheduleId_ = value;
		}
		public string GetScheduleName(){
			return this.scheduleName_;
		}
		
		public void SetScheduleName(string value){
			this.scheduleName_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetVBrandName(){
			return this.vBrandName_;
		}
		
		public void SetVBrandName(string value){
			this.vBrandName_ = value;
		}
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public string GetPoCreationDate(){
			return this.poCreationDate_;
		}
		
		public void SetPoCreationDate(string value){
			this.poCreationDate_ = value;
		}
		public string GetOrigPoNo(){
			return this.origPoNo_;
		}
		
		public void SetOrigPoNo(string value){
			this.origPoNo_ = value;
		}
		public string GetOrderNum(){
			return this.orderNum_;
		}
		
		public void SetOrderNum(string value){
			this.orderNum_ = value;
		}
		public string GetOrderDate(){
			return this.orderDate_;
		}
		
		public void SetOrderDate(string value){
			this.orderDate_ = value;
		}
		public string GetItemNo(){
			return this.itemNo_;
		}
		
		public void SetItemNo(string value){
			this.itemNo_ = value;
		}
		public string GetItemDescription(){
			return this.itemDescription_;
		}
		
		public void SetItemDescription(string value){
			this.itemDescription_ = value;
		}
		public string GetGoodsNo(){
			return this.goodsNo_;
		}
		
		public void SetGoodsNo(string value){
			this.goodsNo_ = value;
		}
		public string GetBrandCode(){
			return this.brandCode_;
		}
		
		public void SetBrandCode(string value){
			this.brandCode_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public double? GetTransactionQuantity(){
			return this.transactionQuantity_;
		}
		
		public void SetTransactionQuantity(double? value){
			this.transactionQuantity_ = value;
		}
		public int? GetDataSign(){
			return this.dataSign_;
		}
		
		public void SetDataSign(int? value){
			this.dataSign_ = value;
		}
		public string GetOrderPrice(){
			return this.orderPrice_;
		}
		
		public void SetOrderPrice(string value){
			this.orderPrice_ = value;
		}
		public string GetCurrencyCode(){
			return this.currencyCode_;
		}
		
		public void SetCurrencyCode(string value){
			this.currencyCode_ = value;
		}
		public string GetTaxRate(){
			return this.taxRate_;
		}
		
		public void SetTaxRate(string value){
			this.taxRate_ = value;
		}
		public string GetPeriodName(){
			return this.periodName_;
		}
		
		public void SetPeriodName(string value){
			this.periodName_ = value;
		}
		public string GetTransactionTypeId(){
			return this.transactionTypeId_;
		}
		
		public void SetTransactionTypeId(string value){
			this.transactionTypeId_ = value;
		}
		public System.DateTime? GetTransactionDate(){
			return this.transactionDate_;
		}
		
		public void SetTransactionDate(System.DateTime? value){
			this.transactionDate_ = value;
		}
		public double? GetPayableBillAmount(){
			return this.payableBillAmount_;
		}
		
		public void SetPayableBillAmount(double? value){
			this.payableBillAmount_ = value;
		}
		public double? GetVendorRate(){
			return this.vendorRate_;
		}
		
		public void SetVendorRate(double? value){
			this.vendorRate_ = value;
		}
		public string GetConfirmNo(){
			return this.confirmNo_;
		}
		
		public void SetConfirmNo(string value){
			this.confirmNo_ = value;
		}
		public string GetSalePlatform(){
			return this.salePlatform_;
		}
		
		public void SetSalePlatform(string value){
			this.salePlatform_ = value;
		}
		public string GetSalePlatformName(){
			return this.salePlatformName_;
		}
		
		public void SetSalePlatformName(string value){
			this.salePlatformName_ = value;
		}
		public System.DateTime? GetCreatedTime(){
			return this.createdTime_;
		}
		
		public void SetCreatedTime(System.DateTime? value){
			this.createdTime_ = value;
		}
		public System.DateTime? GetUpdatedTime(){
			return this.updatedTime_;
		}
		
		public void SetUpdatedTime(System.DateTime? value){
			this.updatedTime_ = value;
		}
		public short? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(short? value){
			this.isDeleted_ = value;
		}
		public string GetGrossMarginRate(){
			return this.grossMarginRate_;
		}
		
		public void SetGrossMarginRate(string value){
			this.grossMarginRate_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public double? GetPoPrice(){
			return this.poPrice_;
		}
		
		public void SetPoPrice(double? value){
			this.poPrice_ = value;
		}
		public double? GetPoTaxPrice(){
			return this.poTaxPrice_;
		}
		
		public void SetPoTaxPrice(double? value){
			this.poTaxPrice_ = value;
		}
		public double? GetPayableTotalBillAmount(){
			return this.payableTotalBillAmount_;
		}
		
		public void SetPayableTotalBillAmount(double? value){
			this.payableTotalBillAmount_ = value;
		}
		public string GetDetailLineType(){
			return this.detailLineType_;
		}
		
		public void SetDetailLineType(string value){
			this.detailLineType_ = value;
		}
		public string GetPriceContractNum(){
			return this.priceContractNum_;
		}
		
		public void SetPriceContractNum(string value){
			this.priceContractNum_ = value;
		}
		public double? GetBillPrice(){
			return this.billPrice_;
		}
		
		public void SetBillPrice(double? value){
			this.billPrice_ = value;
		}
		public double? GetBillTaxPrice(){
			return this.billTaxPrice_;
		}
		
		public void SetBillTaxPrice(double? value){
			this.billTaxPrice_ = value;
		}
		public System.DateTime? GetTrxCreationDate(){
			return this.trxCreationDate_;
		}
		
		public void SetTrxCreationDate(System.DateTime? value){
			this.trxCreationDate_ = value;
		}
		public double? GetPayableQuantity(){
			return this.payableQuantity_;
		}
		
		public void SetPayableQuantity(double? value){
			this.payableQuantity_ = value;
		}
		public string GetTransactionTypeCommand(){
			return this.transactionTypeCommand_;
		}
		
		public void SetTransactionTypeCommand(string value){
			this.transactionTypeCommand_ = value;
		}
		public double? GetBillQuantity(){
			return this.billQuantity_;
		}
		
		public void SetBillQuantity(double? value){
			this.billQuantity_ = value;
		}
		public double? GetBillAmount(){
			return this.billAmount_;
		}
		
		public void SetBillAmount(double? value){
			this.billAmount_ = value;
		}
		public double? GetTotalBillAmount(){
			return this.totalBillAmount_;
		}
		
		public void SetTotalBillAmount(double? value){
			this.totalBillAmount_ = value;
		}
		public string GetPoNoRef(){
			return this.poNoRef_;
		}
		
		public void SetPoNoRef(string value){
			this.poNoRef_ = value;
		}
		public string GetReferenceNumber(){
			return this.referenceNumber_;
		}
		
		public void SetReferenceNumber(string value){
			this.referenceNumber_ = value;
		}
		public string GetExchangeFlag(){
			return this.exchangeFlag_;
		}
		
		public void SetExchangeFlag(string value){
			this.exchangeFlag_ = value;
		}
		public double? GetTransactionAmount(){
			return this.transactionAmount_;
		}
		
		public void SetTransactionAmount(double? value){
			this.transactionAmount_ = value;
		}
		public double? GetTotalTransactionAmount(){
			return this.totalTransactionAmount_;
		}
		
		public void SetTotalTransactionAmount(double? value){
			this.totalTransactionAmount_ = value;
		}
		public string GetActiveNewRuleFlag(){
			return this.activeNewRuleFlag_;
		}
		
		public void SetActiveNewRuleFlag(string value){
			this.activeNewRuleFlag_ = value;
		}
		public string GetActiveOrderPrice(){
			return this.activeOrderPrice_;
		}
		
		public void SetActiveOrderPrice(string value){
			this.activeOrderPrice_ = value;
		}
		public string GetActiveType(){
			return this.activeType_;
		}
		
		public void SetActiveType(string value){
			this.activeType_ = value;
		}
		public string GetActiveName(){
			return this.activeName_;
		}
		
		public void SetActiveName(string value){
			this.activeName_ = value;
		}
		public long? GetInvGlobalId(){
			return this.invGlobalId_;
		}
		
		public void SetInvGlobalId(long? value){
			this.invGlobalId_ = value;
		}
		public string GetSourceLineType(){
			return this.sourceLineType_;
		}
		
		public void SetSourceLineType(string value){
			this.sourceLineType_ = value;
		}
		
	}
	
}