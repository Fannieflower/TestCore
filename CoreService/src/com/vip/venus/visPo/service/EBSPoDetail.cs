using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class EBSPoDetail {
		
		///<summary>
		/// 数据来源：PO
		///</summary>
		
		private string sourceCode_;
		
		///<summary>
		/// 供应商code
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 采购员工号
		///</summary>
		
		private string buyerBy_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private string purchaseType_;
		
		///<summary>
		/// po行号
		///</summary>
		
		private string lineNum_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// 商品描述
		///</summary>
		
		private string itemDesc_;
		
		///<summary>
		/// 单位
		///</summary>
		
		private string uomCode_;
		
		///<summary>
		/// 采购数量
		///</summary>
		
		private string poQty_;
		
		///<summary>
		/// 收货数量
		///</summary>
		
		private string packingQty_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private string poMarketPrice_;
		
		///<summary>
		/// 采购单价、不含税价
		///</summary>
		
		private string poUnitPrice_;
		
		///<summary>
		/// 需求日期、预计大货到货日期 
		///</summary>
		
		private string needByDate_;
		
		///<summary>
		/// 销售区域
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// 结算方式
		///</summary>
		
		private string settlement_;
		
		///<summary>
		/// 购买模式
		///</summary>
		
		private string purchaseModel_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 汇率日期 格式举例：2015-04-30
		///</summary>
		
		private string rateDate_;
		
		///<summary>
		/// PO贸易方式，
		///</summary>
		
		private string tradeModel_;
		
		///<summary>
		/// 因为是人工创建PO，PO号不能为空
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 创建人工号
		///</summary>
		
		private string createdBy_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private string creationDate_;
		
		///<summary>
		/// 更新人工号
		///</summary>
		
		private string lastUpdatedBy_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private string lastUpdateDate_;
		
		///<summary>
		/// 平台服务费固定比例
		///</summary>
		
		private string servfeeRate_;
		
		///<summary>
		/// 递延结算天数（Dn）
		///</summary>
		
		private string delayDays_;
		
		///<summary>
		/// 吊牌价
		///</summary>
		
		private string tagPrice_;
		
		///<summary>
		/// 采购区域
		///</summary>
		
		private string purchaseArea_;
		
		///<summary>
		/// 采购办
		///</summary>
		
		private string purchaseOffice_;
		
		///<summary>
		/// 含税采购价
		///</summary>
		
		private string taxPurchasePrice_;
		
		///<summary>
		/// 尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 品牌中文名
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌英文名
		///</summary>
		
		private string brandNameEn_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string itemSn_;
		
		///<summary>
		/// 采购员姓名
		///</summary>
		
		private string buyerName_;
		
		///<summary>
		/// 税率
		///</summary>
		
		private string taxRate_;
		
		///<summary>
		/// 核算一级部门编码
		///</summary>
		
		private string purchaseOffice1_;
		
		///<summary>
		/// 特殊校核天数
		///</summary>
		
		private string kpiDays_;
		
		///<summary>
		/// 特殊校核毛利率
		///</summary>
		
		private string kpiGrossMargin_;
		
		///<summary>
		/// 销售网站
		///</summary>
		
		private string salesSite_;
		
		///<summary>
		/// 是否一般贸易
		///</summary>
		
		private string generalTrade_;
		
		///<summary>
		/// pdc商品资料供应商编码
		///</summary>
		
		private string pdcVendorCode_;
		
		///<summary>
		/// 发票类型
		///</summary>
		
		private string taxType_;
		
		///<summary>
		/// 发票类型所传入的值
		///</summary>
		
		private string taxTypeRate_;
		
		///<summary>
		/// 采购子公司
		///</summary>
		
		private string purchaseCompany_;
		
		///<summary>
		/// 采购子公司编码
		///</summary>
		
		private string purchaseCompanyCode_;
		
		///<summary>
		/// 原始po
		///</summary>
		
		private string originalPo_;
		
		///<summary>
		/// 国家
		///</summary>
		
		private string partyCountry_;
		
		///<summary>
		/// 是否虚拟仓收货 0:否，1：是
		///</summary>
		
		private int? isVWarehouse_;
		
		///<summary>
		/// 实物最早生产日期
		///</summary>
		
		private string productionDate_;
		
		///<summary>
		/// 实物最早过期日期
		///</summary>
		
		private string expireDate_;
		
		///<summary>
		/// 结算属性
		///</summary>
		
		private string SETTLE_SEGMENT1_;
		
		///<summary>
		/// 商品原条码
		///</summary>
		
		private string oldItemNo_;
		
		public string GetSourceCode(){
			return this.sourceCode_;
		}
		
		public void SetSourceCode(string value){
			this.sourceCode_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetBuyerBy(){
			return this.buyerBy_;
		}
		
		public void SetBuyerBy(string value){
			this.buyerBy_ = value;
		}
		public string GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(string value){
			this.purchaseType_ = value;
		}
		public string GetLineNum(){
			return this.lineNum_;
		}
		
		public void SetLineNum(string value){
			this.lineNum_ = value;
		}
		public string GetItemNo(){
			return this.itemNo_;
		}
		
		public void SetItemNo(string value){
			this.itemNo_ = value;
		}
		public string GetItemDesc(){
			return this.itemDesc_;
		}
		
		public void SetItemDesc(string value){
			this.itemDesc_ = value;
		}
		public string GetUomCode(){
			return this.uomCode_;
		}
		
		public void SetUomCode(string value){
			this.uomCode_ = value;
		}
		public string GetPoQty(){
			return this.poQty_;
		}
		
		public void SetPoQty(string value){
			this.poQty_ = value;
		}
		public string GetPackingQty(){
			return this.packingQty_;
		}
		
		public void SetPackingQty(string value){
			this.packingQty_ = value;
		}
		public string GetPoMarketPrice(){
			return this.poMarketPrice_;
		}
		
		public void SetPoMarketPrice(string value){
			this.poMarketPrice_ = value;
		}
		public string GetPoUnitPrice(){
			return this.poUnitPrice_;
		}
		
		public void SetPoUnitPrice(string value){
			this.poUnitPrice_ = value;
		}
		public string GetNeedByDate(){
			return this.needByDate_;
		}
		
		public void SetNeedByDate(string value){
			this.needByDate_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public string GetSettlement(){
			return this.settlement_;
		}
		
		public void SetSettlement(string value){
			this.settlement_ = value;
		}
		public string GetPurchaseModel(){
			return this.purchaseModel_;
		}
		
		public void SetPurchaseModel(string value){
			this.purchaseModel_ = value;
		}
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public string GetRateDate(){
			return this.rateDate_;
		}
		
		public void SetRateDate(string value){
			this.rateDate_ = value;
		}
		public string GetTradeModel(){
			return this.tradeModel_;
		}
		
		public void SetTradeModel(string value){
			this.tradeModel_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetCreatedBy(){
			return this.createdBy_;
		}
		
		public void SetCreatedBy(string value){
			this.createdBy_ = value;
		}
		public string GetCreationDate(){
			return this.creationDate_;
		}
		
		public void SetCreationDate(string value){
			this.creationDate_ = value;
		}
		public string GetLastUpdatedBy(){
			return this.lastUpdatedBy_;
		}
		
		public void SetLastUpdatedBy(string value){
			this.lastUpdatedBy_ = value;
		}
		public string GetLastUpdateDate(){
			return this.lastUpdateDate_;
		}
		
		public void SetLastUpdateDate(string value){
			this.lastUpdateDate_ = value;
		}
		public string GetServfeeRate(){
			return this.servfeeRate_;
		}
		
		public void SetServfeeRate(string value){
			this.servfeeRate_ = value;
		}
		public string GetDelayDays(){
			return this.delayDays_;
		}
		
		public void SetDelayDays(string value){
			this.delayDays_ = value;
		}
		public string GetTagPrice(){
			return this.tagPrice_;
		}
		
		public void SetTagPrice(string value){
			this.tagPrice_ = value;
		}
		public string GetPurchaseArea(){
			return this.purchaseArea_;
		}
		
		public void SetPurchaseArea(string value){
			this.purchaseArea_ = value;
		}
		public string GetPurchaseOffice(){
			return this.purchaseOffice_;
		}
		
		public void SetPurchaseOffice(string value){
			this.purchaseOffice_ = value;
		}
		public string GetTaxPurchasePrice(){
			return this.taxPurchasePrice_;
		}
		
		public void SetTaxPurchasePrice(string value){
			this.taxPurchasePrice_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandNameEn(){
			return this.brandNameEn_;
		}
		
		public void SetBrandNameEn(string value){
			this.brandNameEn_ = value;
		}
		public string GetItemSn(){
			return this.itemSn_;
		}
		
		public void SetItemSn(string value){
			this.itemSn_ = value;
		}
		public string GetBuyerName(){
			return this.buyerName_;
		}
		
		public void SetBuyerName(string value){
			this.buyerName_ = value;
		}
		public string GetTaxRate(){
			return this.taxRate_;
		}
		
		public void SetTaxRate(string value){
			this.taxRate_ = value;
		}
		public string GetPurchaseOffice1(){
			return this.purchaseOffice1_;
		}
		
		public void SetPurchaseOffice1(string value){
			this.purchaseOffice1_ = value;
		}
		public string GetKpiDays(){
			return this.kpiDays_;
		}
		
		public void SetKpiDays(string value){
			this.kpiDays_ = value;
		}
		public string GetKpiGrossMargin(){
			return this.kpiGrossMargin_;
		}
		
		public void SetKpiGrossMargin(string value){
			this.kpiGrossMargin_ = value;
		}
		public string GetSalesSite(){
			return this.salesSite_;
		}
		
		public void SetSalesSite(string value){
			this.salesSite_ = value;
		}
		public string GetGeneralTrade(){
			return this.generalTrade_;
		}
		
		public void SetGeneralTrade(string value){
			this.generalTrade_ = value;
		}
		public string GetPdcVendorCode(){
			return this.pdcVendorCode_;
		}
		
		public void SetPdcVendorCode(string value){
			this.pdcVendorCode_ = value;
		}
		public string GetTaxType(){
			return this.taxType_;
		}
		
		public void SetTaxType(string value){
			this.taxType_ = value;
		}
		public string GetTaxTypeRate(){
			return this.taxTypeRate_;
		}
		
		public void SetTaxTypeRate(string value){
			this.taxTypeRate_ = value;
		}
		public string GetPurchaseCompany(){
			return this.purchaseCompany_;
		}
		
		public void SetPurchaseCompany(string value){
			this.purchaseCompany_ = value;
		}
		public string GetPurchaseCompanyCode(){
			return this.purchaseCompanyCode_;
		}
		
		public void SetPurchaseCompanyCode(string value){
			this.purchaseCompanyCode_ = value;
		}
		public string GetOriginalPo(){
			return this.originalPo_;
		}
		
		public void SetOriginalPo(string value){
			this.originalPo_ = value;
		}
		public string GetPartyCountry(){
			return this.partyCountry_;
		}
		
		public void SetPartyCountry(string value){
			this.partyCountry_ = value;
		}
		public int? GetIsVWarehouse(){
			return this.isVWarehouse_;
		}
		
		public void SetIsVWarehouse(int? value){
			this.isVWarehouse_ = value;
		}
		public string GetProductionDate(){
			return this.productionDate_;
		}
		
		public void SetProductionDate(string value){
			this.productionDate_ = value;
		}
		public string GetExpireDate(){
			return this.expireDate_;
		}
		
		public void SetExpireDate(string value){
			this.expireDate_ = value;
		}
		public string GetSETTLE_SEGMENT1(){
			return this.SETTLE_SEGMENT1_;
		}
		
		public void SetSETTLE_SEGMENT1(string value){
			this.SETTLE_SEGMENT1_ = value;
		}
		public string GetOldItemNo(){
			return this.oldItemNo_;
		}
		
		public void SetOldItemNo(string value){
			this.oldItemNo_ = value;
		}
		
	}
	
}