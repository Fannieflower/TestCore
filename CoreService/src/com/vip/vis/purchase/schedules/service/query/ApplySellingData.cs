using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ApplySellingData {
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 采购协议编码
		///</summary>
		
		private long? shopCode_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 一级权限id
		///</summary>
		
		private int? dataAreaId_;
		
		///<summary>
		/// 一级权限名称
		///</summary>
		
		private string dataAreaName_;
		
		///<summary>
		/// 二级权限id
		///</summary>
		
		private int? dataAreaDivide_;
		
		///<summary>
		/// 二级权限名称
		///</summary>
		
		private string dataAreaDivideName_;
		
		///<summary>
		/// 部类第一级
		///</summary>
		
		private int? areaId_;
		
		///<summary>
		/// 部类第三级
		///</summary>
		
		private int? departmentId_;
		
		///<summary>
		/// 部类第三级名称
		///</summary>
		
		private string departmentIdName_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		///<summary>
		/// 创建人用户ID
		///</summary>
		
		private int? createByUid_;
		
		///<summary>
		/// 负责人
		///</summary>
		
		private string brandAdminName_;
		
		///<summary>
		/// 负责人用户ID
		///</summary>
		
		private int? brandAdminUserId_;
		
		///<summary>
		/// 负责人用户工号
		///</summary>
		
		private string brandAdminUserJobnumber_;
		
		///<summary>
		/// 创建人所在部门
		///</summary>
		
		private string brandAdminDepName_;
		
		///<summary>
		/// 采购协议名称
		///</summary>
		
		private string sellingAction_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private byte? sellingMode_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private int? b2cModeId_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// 分销站点
		///</summary>
		
		private string distributionSites_;
		
		///<summary>
		/// 采购协议有效开始时间
		///</summary>
		
		private string sellTimeFromStr_;
		
		///<summary>
		/// 采购协议有效结束时间
		///</summary>
		
		private string sellTimeToStr_;
		
		///<summary>
		/// 是否是常态档期
		///</summary>
		
		private int? isNormalization_;
		
		///<summary>
		/// 是否接入价格系统
		///</summary>
		
		private byte? accessPrice_;
		
		///<summary>
		/// 是否对接POS
		///</summary>
		
		private byte? isPos_;
		
		///<summary>
		/// 是否快速生成专场
		///</summary>
		
		private byte? exclusiveOrShare_;
		
		///<summary>
		/// 是否运营专场
		///</summary>
		
		private byte? specialOperationsFlag_;
		
		///<summary>
		/// 品牌
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> brandList_;
		
		///<summary>
		/// 档期标签
		///</summary>
		
		private List<string> labelList_;
		
		///<summary>
		/// 预留字段
		///</summary>
		
		private Dictionary<string, string> flagMap_;
		
		///<summary>
		/// 部类第二级
		///</summary>
		
		private int? department_;
		
		///<summary>
		/// 部类第二级名称
		///</summary>
		
		private string departmentName_;
		
		///<summary>
		/// 创建人中文名
		///</summary>
		
		private string createByName_;
		
		///<summary>
		/// 售卖平台
		///</summary>
		
		private string salePlatform_;
		
		///<summary>
		/// 残次属性
		///</summary>
		
		private byte? defectAttr_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private string createTimeStr_;
		
		///<summary>
		/// 合作模式说明
		///</summary>
		
		private string sellingModeReadable_;
		
		///<summary>
		/// 是否mp
		///</summary>
		
		private byte? isMarketPlace_;
		
		///<summary>
		/// 店铺ID
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 分区售卖标示
		///</summary>
		
		private byte? isAreaSales_;
		
		///<summary>
		/// 合同币种
		///</summary>
		
		private string contractCurrency_;
		
		///<summary>
		/// 到货类型
		///</summary>
		
		private byte? arrivalType_;
		
		///<summary>
		/// 海淘JIT结算方式
		///</summary>
		
		private byte? paymentType_;
		
		///<summary>
		/// 是否门店导购
		///</summary>
		
		private byte? isStoreSale_;
		
		///<summary>
		/// PO复制周期
		///</summary>
		
		private int? poCopyIntervalDay_;
		
		///<summary>
		/// 是否好批发
		///</summary>
		
		private int? isHaopifa_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private int? defectAttrLevel_;
		
		///<summary>
		/// 结算模式
		///</summary>
		
		private byte? cooperationType_;
		
		///<summary>
		/// 是否海淘
		///</summary>
		
		private byte? isHt_;
		
		///<summary>
		/// 采购渠道
		///</summary>
		
		private List<string> purchaseChannel_;
		
		///<summary>
		/// 毛利率
		///</summary>
		
		private double? grossProfitRate_;
		
		///<summary>
		/// 毛利率结束值
		///</summary>
		
		private double? grossProfitRateEnd_;
		
		///<summary>
		/// 毛利率固定值
		///</summary>
		
		private double? grossProfitRateFixedValue_;
		
		///<summary>
		/// 毛利率阶梯列表（结算模式为：毛利率阶梯时，有值）
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> grossProfitRateLadderList_;
		
		///<summary>
		/// 是否预售
		///</summary>
		
		private int? isPreSell_;
		
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public long? GetShopCode(){
			return this.shopCode_;
		}
		
		public void SetShopCode(long? value){
			this.shopCode_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public int? GetDataAreaId(){
			return this.dataAreaId_;
		}
		
		public void SetDataAreaId(int? value){
			this.dataAreaId_ = value;
		}
		public string GetDataAreaName(){
			return this.dataAreaName_;
		}
		
		public void SetDataAreaName(string value){
			this.dataAreaName_ = value;
		}
		public int? GetDataAreaDivide(){
			return this.dataAreaDivide_;
		}
		
		public void SetDataAreaDivide(int? value){
			this.dataAreaDivide_ = value;
		}
		public string GetDataAreaDivideName(){
			return this.dataAreaDivideName_;
		}
		
		public void SetDataAreaDivideName(string value){
			this.dataAreaDivideName_ = value;
		}
		public int? GetAreaId(){
			return this.areaId_;
		}
		
		public void SetAreaId(int? value){
			this.areaId_ = value;
		}
		public int? GetDepartmentId(){
			return this.departmentId_;
		}
		
		public void SetDepartmentId(int? value){
			this.departmentId_ = value;
		}
		public string GetDepartmentIdName(){
			return this.departmentIdName_;
		}
		
		public void SetDepartmentIdName(string value){
			this.departmentIdName_ = value;
		}
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		public int? GetCreateByUid(){
			return this.createByUid_;
		}
		
		public void SetCreateByUid(int? value){
			this.createByUid_ = value;
		}
		public string GetBrandAdminName(){
			return this.brandAdminName_;
		}
		
		public void SetBrandAdminName(string value){
			this.brandAdminName_ = value;
		}
		public int? GetBrandAdminUserId(){
			return this.brandAdminUserId_;
		}
		
		public void SetBrandAdminUserId(int? value){
			this.brandAdminUserId_ = value;
		}
		public string GetBrandAdminUserJobnumber(){
			return this.brandAdminUserJobnumber_;
		}
		
		public void SetBrandAdminUserJobnumber(string value){
			this.brandAdminUserJobnumber_ = value;
		}
		public string GetBrandAdminDepName(){
			return this.brandAdminDepName_;
		}
		
		public void SetBrandAdminDepName(string value){
			this.brandAdminDepName_ = value;
		}
		public string GetSellingAction(){
			return this.sellingAction_;
		}
		
		public void SetSellingAction(string value){
			this.sellingAction_ = value;
		}
		public byte? GetSellingMode(){
			return this.sellingMode_;
		}
		
		public void SetSellingMode(byte? value){
			this.sellingMode_ = value;
		}
		public int? GetB2cModeId(){
			return this.b2cModeId_;
		}
		
		public void SetB2cModeId(int? value){
			this.b2cModeId_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public string GetDistributionSites(){
			return this.distributionSites_;
		}
		
		public void SetDistributionSites(string value){
			this.distributionSites_ = value;
		}
		public string GetSellTimeFromStr(){
			return this.sellTimeFromStr_;
		}
		
		public void SetSellTimeFromStr(string value){
			this.sellTimeFromStr_ = value;
		}
		public string GetSellTimeToStr(){
			return this.sellTimeToStr_;
		}
		
		public void SetSellTimeToStr(string value){
			this.sellTimeToStr_ = value;
		}
		public int? GetIsNormalization(){
			return this.isNormalization_;
		}
		
		public void SetIsNormalization(int? value){
			this.isNormalization_ = value;
		}
		public byte? GetAccessPrice(){
			return this.accessPrice_;
		}
		
		public void SetAccessPrice(byte? value){
			this.accessPrice_ = value;
		}
		public byte? GetIsPos(){
			return this.isPos_;
		}
		
		public void SetIsPos(byte? value){
			this.isPos_ = value;
		}
		public byte? GetExclusiveOrShare(){
			return this.exclusiveOrShare_;
		}
		
		public void SetExclusiveOrShare(byte? value){
			this.exclusiveOrShare_ = value;
		}
		public byte? GetSpecialOperationsFlag(){
			return this.specialOperationsFlag_;
		}
		
		public void SetSpecialOperationsFlag(byte? value){
			this.specialOperationsFlag_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> GetBrandList(){
			return this.brandList_;
		}
		
		public void SetBrandList(List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> value){
			this.brandList_ = value;
		}
		public List<string> GetLabelList(){
			return this.labelList_;
		}
		
		public void SetLabelList(List<string> value){
			this.labelList_ = value;
		}
		public Dictionary<string, string> GetFlagMap(){
			return this.flagMap_;
		}
		
		public void SetFlagMap(Dictionary<string, string> value){
			this.flagMap_ = value;
		}
		public int? GetDepartment(){
			return this.department_;
		}
		
		public void SetDepartment(int? value){
			this.department_ = value;
		}
		public string GetDepartmentName(){
			return this.departmentName_;
		}
		
		public void SetDepartmentName(string value){
			this.departmentName_ = value;
		}
		public string GetCreateByName(){
			return this.createByName_;
		}
		
		public void SetCreateByName(string value){
			this.createByName_ = value;
		}
		public string GetSalePlatform(){
			return this.salePlatform_;
		}
		
		public void SetSalePlatform(string value){
			this.salePlatform_ = value;
		}
		public byte? GetDefectAttr(){
			return this.defectAttr_;
		}
		
		public void SetDefectAttr(byte? value){
			this.defectAttr_ = value;
		}
		public string GetCreateTimeStr(){
			return this.createTimeStr_;
		}
		
		public void SetCreateTimeStr(string value){
			this.createTimeStr_ = value;
		}
		public string GetSellingModeReadable(){
			return this.sellingModeReadable_;
		}
		
		public void SetSellingModeReadable(string value){
			this.sellingModeReadable_ = value;
		}
		public byte? GetIsMarketPlace(){
			return this.isMarketPlace_;
		}
		
		public void SetIsMarketPlace(byte? value){
			this.isMarketPlace_ = value;
		}
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public byte? GetIsAreaSales(){
			return this.isAreaSales_;
		}
		
		public void SetIsAreaSales(byte? value){
			this.isAreaSales_ = value;
		}
		public string GetContractCurrency(){
			return this.contractCurrency_;
		}
		
		public void SetContractCurrency(string value){
			this.contractCurrency_ = value;
		}
		public byte? GetArrivalType(){
			return this.arrivalType_;
		}
		
		public void SetArrivalType(byte? value){
			this.arrivalType_ = value;
		}
		public byte? GetPaymentType(){
			return this.paymentType_;
		}
		
		public void SetPaymentType(byte? value){
			this.paymentType_ = value;
		}
		public byte? GetIsStoreSale(){
			return this.isStoreSale_;
		}
		
		public void SetIsStoreSale(byte? value){
			this.isStoreSale_ = value;
		}
		public int? GetPoCopyIntervalDay(){
			return this.poCopyIntervalDay_;
		}
		
		public void SetPoCopyIntervalDay(int? value){
			this.poCopyIntervalDay_ = value;
		}
		public int? GetIsHaopifa(){
			return this.isHaopifa_;
		}
		
		public void SetIsHaopifa(int? value){
			this.isHaopifa_ = value;
		}
		public int? GetDefectAttrLevel(){
			return this.defectAttrLevel_;
		}
		
		public void SetDefectAttrLevel(int? value){
			this.defectAttrLevel_ = value;
		}
		public byte? GetCooperationType(){
			return this.cooperationType_;
		}
		
		public void SetCooperationType(byte? value){
			this.cooperationType_ = value;
		}
		public byte? GetIsHt(){
			return this.isHt_;
		}
		
		public void SetIsHt(byte? value){
			this.isHt_ = value;
		}
		public List<string> GetPurchaseChannel(){
			return this.purchaseChannel_;
		}
		
		public void SetPurchaseChannel(List<string> value){
			this.purchaseChannel_ = value;
		}
		public double? GetGrossProfitRate(){
			return this.grossProfitRate_;
		}
		
		public void SetGrossProfitRate(double? value){
			this.grossProfitRate_ = value;
		}
		public double? GetGrossProfitRateEnd(){
			return this.grossProfitRateEnd_;
		}
		
		public void SetGrossProfitRateEnd(double? value){
			this.grossProfitRateEnd_ = value;
		}
		public double? GetGrossProfitRateFixedValue(){
			return this.grossProfitRateFixedValue_;
		}
		
		public void SetGrossProfitRateFixedValue(double? value){
			this.grossProfitRateFixedValue_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> GetGrossProfitRateLadderList(){
			return this.grossProfitRateLadderList_;
		}
		
		public void SetGrossProfitRateLadderList(List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> value){
			this.grossProfitRateLadderList_ = value;
		}
		public int? GetIsPreSell(){
			return this.isPreSell_;
		}
		
		public void SetIsPreSell(int? value){
			this.isPreSell_ = value;
		}
		
	}
	
}