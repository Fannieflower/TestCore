using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderModel {
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchNo_;
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 采购清单编号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 销售订单编号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 审核状态，0=草稿，1=待审批，2=审批通过，3=已驳回
		///</summary>
		
		private byte? approvalStatus_;
		
		///<summary>
		/// 发货状态， 0=未下发、1=已下发、2=占用失败、3=占用成功、4=已出仓、9=已取消
		///</summary>
		
		private byte? deliveryStatus_;
		
		///<summary>
		/// 采购员
		///</summary>
		
		private string buyerId_;
		
		///<summary>
		/// 库存属性，0=SI，1=VI
		///</summary>
		
		private byte? stockProps_;
		
		///<summary>
		/// 发货仓库
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private string disabilityLevel_;
		
		///<summary>
		/// 采购商品数量
		///</summary>
		
		private int? purchaseQuantity_;
		
		///<summary>
		/// 采购商品金额
		///</summary>
		
		private double? totalAmount_;
		
		///<summary>
		/// 占用数量
		///</summary>
		
		private int? holdQuantity_;
		
		///<summary>
		/// 已发货数量
		///</summary>
		
		private int? deliveredQuantity_;
		
		///<summary>
		/// 已收货数量
		///</summary>
		
		private int? receivedQuantity_;
		
		///<summary>
		/// 收货地址id
		///</summary>
		
		private string deliveryAddrId_;
		
		///<summary>
		/// 采购员部门id
		///</summary>
		
		private string deptId_;
		
		///<summary>
		/// 录入文件地址
		///</summary>
		
		private string sourceFileUrl_;
		
		///<summary>
		/// 校验结果文件url地址
		///</summary>
		
		private string resultFileUrl_;
		
		///<summary>
		/// 是否删除，0=未删除，1=已删除
		///</summary>
		
		private byte? isDeleted_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 采购员名称
		///</summary>
		
		private string buyerName_;
		
		///<summary>
		/// 采购类型,0=内采，1=外采
		///</summary>
		
		private byte? purchaseType_;
		
		///<summary>
		/// 采购员部门
		///</summary>
		
		private string deptName_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 审批时间
		///</summary>
		
		private string approvalTime_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 退货地址id
		///</summary>
		
		private string returnAddrId_;
		
		///<summary>
		/// 商务对接人OA帐号
		///</summary>
		
		private string bizLinkerId_;
		
		///<summary>
		/// 商务对接人名称
		///</summary>
		
		private string bizLinkerName_;
		
		///<summary>
		/// 商务对接人所属部门id
		///</summary>
		
		private string bizLinkerDeptId_;
		
		///<summary>
		/// 商务对接人所属部门名称
		///</summary>
		
		private string bizLinkerDeptName_;
		
		///<summary>
		/// 当前审核节点的权限编码
		///</summary>
		
		private string approvalRole_;
		
		///<summary>
		/// 当前审核角色名称
		///</summary>
		
		private string approvalRoleName_;
		
		///<summary>
		/// 越库标识(0否,1是)
		///</summary>
		
		private byte? skipFlag_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 是否集团采买:0-否,1-是
		///</summary>
		
		private byte? isQuota_;
		
		///<summary>
		/// 合作模式:0-买断,1-代销
		///</summary>
		
		private byte? cooperationMode_;
		
		///<summary>
		/// 预计到货时间
		///</summary>
		
		private System.DateTime? estimateArrivalTime_;
		
		///<summary>
		/// 是否补单:0-否,1-是
		///</summary>
		
		private byte? isSupplement_;
		
		///<summary>
		/// 货品类型（0、现货 1、囤货）
		///</summary>
		
		private byte? goodsType_;
		
		///<summary>
		/// 可配货时间
		///</summary>
		
		private System.DateTime? distributableGoodsTime_;
		
		///<summary>
		/// 订单来源
		///</summary>
		
		private string source_;
		
		///<summary>
		/// 结算模式 1-供货价 2-扣点
		///</summary>
		
		private byte? settlementMode_;
		
		///<summary>
		/// 扣点
		///</summary>
		
		private double? deduction_;
		
		///<summary>
		/// 买手组编码
		///</summary>
		
		private string buyerGroupCode_;
		
		///<summary>
		/// 买手组名称
		///</summary>
		
		private string buyerGroupName_;
		
		///<summary>
		/// RFID打印模板
		///</summary>
		
		private byte? rfidTemplateFlag_;
		
		///<summary>
		/// 供应商引进部门
		///</summary>
		
		private string vendorIntroduceDept_;
		
		///<summary>
		/// 未分发商品信息的URL
		///</summary>
		
		private string notDistributedProdInfoUrl_;
		
		///<summary>
		/// 采购商品金额(人民币)
		///</summary>
		
		private double? totalAmountCny_;
		
		///<summary>
		/// 货品渠道
		///</summary>
		
		private string goodsChannel_;
		
		///<summary>
		/// 退供单号
		///</summary>
		
		private string refundNo_;
		
		///<summary>
		/// 实际金额
		///</summary>
		
		private double? totalReceivedAmount_;
		
		///<summary>
		/// 允许转买断残次等级
		///</summary>
		
		private List<string> allDisabilityLevel_;
		
		///<summary>
		/// 建单人名称
		///</summary>
		
		private string creatorName_;
		
		///<summary>
		/// 商品属性
		///</summary>
		
		private byte? goodsProps_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(string value){
			this.batchNo_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public byte? GetApprovalStatus(){
			return this.approvalStatus_;
		}
		
		public void SetApprovalStatus(byte? value){
			this.approvalStatus_ = value;
		}
		public byte? GetDeliveryStatus(){
			return this.deliveryStatus_;
		}
		
		public void SetDeliveryStatus(byte? value){
			this.deliveryStatus_ = value;
		}
		public string GetBuyerId(){
			return this.buyerId_;
		}
		
		public void SetBuyerId(string value){
			this.buyerId_ = value;
		}
		public byte? GetStockProps(){
			return this.stockProps_;
		}
		
		public void SetStockProps(byte? value){
			this.stockProps_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public string GetDisabilityLevel(){
			return this.disabilityLevel_;
		}
		
		public void SetDisabilityLevel(string value){
			this.disabilityLevel_ = value;
		}
		public int? GetPurchaseQuantity(){
			return this.purchaseQuantity_;
		}
		
		public void SetPurchaseQuantity(int? value){
			this.purchaseQuantity_ = value;
		}
		public double? GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(double? value){
			this.totalAmount_ = value;
		}
		public int? GetHoldQuantity(){
			return this.holdQuantity_;
		}
		
		public void SetHoldQuantity(int? value){
			this.holdQuantity_ = value;
		}
		public int? GetDeliveredQuantity(){
			return this.deliveredQuantity_;
		}
		
		public void SetDeliveredQuantity(int? value){
			this.deliveredQuantity_ = value;
		}
		public int? GetReceivedQuantity(){
			return this.receivedQuantity_;
		}
		
		public void SetReceivedQuantity(int? value){
			this.receivedQuantity_ = value;
		}
		public string GetDeliveryAddrId(){
			return this.deliveryAddrId_;
		}
		
		public void SetDeliveryAddrId(string value){
			this.deliveryAddrId_ = value;
		}
		public string GetDeptId(){
			return this.deptId_;
		}
		
		public void SetDeptId(string value){
			this.deptId_ = value;
		}
		public string GetSourceFileUrl(){
			return this.sourceFileUrl_;
		}
		
		public void SetSourceFileUrl(string value){
			this.sourceFileUrl_ = value;
		}
		public string GetResultFileUrl(){
			return this.resultFileUrl_;
		}
		
		public void SetResultFileUrl(string value){
			this.resultFileUrl_ = value;
		}
		public byte? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(byte? value){
			this.isDeleted_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public System.DateTime? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(System.DateTime? value){
			this.updateTime_ = value;
		}
		public string GetBuyerName(){
			return this.buyerName_;
		}
		
		public void SetBuyerName(string value){
			this.buyerName_ = value;
		}
		public byte? GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(byte? value){
			this.purchaseType_ = value;
		}
		public string GetDeptName(){
			return this.deptName_;
		}
		
		public void SetDeptName(string value){
			this.deptName_ = value;
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
		public string GetApprovalTime(){
			return this.approvalTime_;
		}
		
		public void SetApprovalTime(string value){
			this.approvalTime_ = value;
		}
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public string GetReturnAddrId(){
			return this.returnAddrId_;
		}
		
		public void SetReturnAddrId(string value){
			this.returnAddrId_ = value;
		}
		public string GetBizLinkerId(){
			return this.bizLinkerId_;
		}
		
		public void SetBizLinkerId(string value){
			this.bizLinkerId_ = value;
		}
		public string GetBizLinkerName(){
			return this.bizLinkerName_;
		}
		
		public void SetBizLinkerName(string value){
			this.bizLinkerName_ = value;
		}
		public string GetBizLinkerDeptId(){
			return this.bizLinkerDeptId_;
		}
		
		public void SetBizLinkerDeptId(string value){
			this.bizLinkerDeptId_ = value;
		}
		public string GetBizLinkerDeptName(){
			return this.bizLinkerDeptName_;
		}
		
		public void SetBizLinkerDeptName(string value){
			this.bizLinkerDeptName_ = value;
		}
		public string GetApprovalRole(){
			return this.approvalRole_;
		}
		
		public void SetApprovalRole(string value){
			this.approvalRole_ = value;
		}
		public string GetApprovalRoleName(){
			return this.approvalRoleName_;
		}
		
		public void SetApprovalRoleName(string value){
			this.approvalRoleName_ = value;
		}
		public byte? GetSkipFlag(){
			return this.skipFlag_;
		}
		
		public void SetSkipFlag(byte? value){
			this.skipFlag_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public byte? GetIsQuota(){
			return this.isQuota_;
		}
		
		public void SetIsQuota(byte? value){
			this.isQuota_ = value;
		}
		public byte? GetCooperationMode(){
			return this.cooperationMode_;
		}
		
		public void SetCooperationMode(byte? value){
			this.cooperationMode_ = value;
		}
		public System.DateTime? GetEstimateArrivalTime(){
			return this.estimateArrivalTime_;
		}
		
		public void SetEstimateArrivalTime(System.DateTime? value){
			this.estimateArrivalTime_ = value;
		}
		public byte? GetIsSupplement(){
			return this.isSupplement_;
		}
		
		public void SetIsSupplement(byte? value){
			this.isSupplement_ = value;
		}
		public byte? GetGoodsType(){
			return this.goodsType_;
		}
		
		public void SetGoodsType(byte? value){
			this.goodsType_ = value;
		}
		public System.DateTime? GetDistributableGoodsTime(){
			return this.distributableGoodsTime_;
		}
		
		public void SetDistributableGoodsTime(System.DateTime? value){
			this.distributableGoodsTime_ = value;
		}
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public byte? GetSettlementMode(){
			return this.settlementMode_;
		}
		
		public void SetSettlementMode(byte? value){
			this.settlementMode_ = value;
		}
		public double? GetDeduction(){
			return this.deduction_;
		}
		
		public void SetDeduction(double? value){
			this.deduction_ = value;
		}
		public string GetBuyerGroupCode(){
			return this.buyerGroupCode_;
		}
		
		public void SetBuyerGroupCode(string value){
			this.buyerGroupCode_ = value;
		}
		public string GetBuyerGroupName(){
			return this.buyerGroupName_;
		}
		
		public void SetBuyerGroupName(string value){
			this.buyerGroupName_ = value;
		}
		public byte? GetRfidTemplateFlag(){
			return this.rfidTemplateFlag_;
		}
		
		public void SetRfidTemplateFlag(byte? value){
			this.rfidTemplateFlag_ = value;
		}
		public string GetVendorIntroduceDept(){
			return this.vendorIntroduceDept_;
		}
		
		public void SetVendorIntroduceDept(string value){
			this.vendorIntroduceDept_ = value;
		}
		public string GetNotDistributedProdInfoUrl(){
			return this.notDistributedProdInfoUrl_;
		}
		
		public void SetNotDistributedProdInfoUrl(string value){
			this.notDistributedProdInfoUrl_ = value;
		}
		public double? GetTotalAmountCny(){
			return this.totalAmountCny_;
		}
		
		public void SetTotalAmountCny(double? value){
			this.totalAmountCny_ = value;
		}
		public string GetGoodsChannel(){
			return this.goodsChannel_;
		}
		
		public void SetGoodsChannel(string value){
			this.goodsChannel_ = value;
		}
		public string GetRefundNo(){
			return this.refundNo_;
		}
		
		public void SetRefundNo(string value){
			this.refundNo_ = value;
		}
		public double? GetTotalReceivedAmount(){
			return this.totalReceivedAmount_;
		}
		
		public void SetTotalReceivedAmount(double? value){
			this.totalReceivedAmount_ = value;
		}
		public List<string> GetAllDisabilityLevel(){
			return this.allDisabilityLevel_;
		}
		
		public void SetAllDisabilityLevel(List<string> value){
			this.allDisabilityLevel_ = value;
		}
		public string GetCreatorName(){
			return this.creatorName_;
		}
		
		public void SetCreatorName(string value){
			this.creatorName_ = value;
		}
		public byte? GetGoodsProps(){
			return this.goodsProps_;
		}
		
		public void SetGoodsProps(byte? value){
			this.goodsProps_ = value;
		}
		
	}
	
}