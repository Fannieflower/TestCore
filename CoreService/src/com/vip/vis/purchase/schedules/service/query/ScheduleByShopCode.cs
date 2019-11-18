using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ScheduleByShopCode {
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 采购协议编码
		///</summary>
		
		private long? shopCode_;
		
		///<summary>
		/// 合作主题名称
		///</summary>
		
		private string shopName_;
		
		///<summary>
		/// 采购协议名称
		///</summary>
		
		private string sellingAction_;
		
		///<summary>
		/// 档期
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.ApplySchedules> schedulesList_;
		
		///<summary>
		/// 采购协议有效开始时间
		///</summary>
		
		private System.DateTime? sellTimeFrom_;
		
		///<summary>
		/// 采购协议有效结束时间
		///</summary>
		
		private System.DateTime? sellTimeTo_;
		
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
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private byte? sellingMode_;
		
		///<summary>
		/// 合作模式说明
		///</summary>
		
		private string sellingModeReadable_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private int? b2cModeId_;
		
		///<summary>
		/// 结算模式
		///</summary>
		
		private byte? cooperationType_;
		
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
		/// 品牌
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> brandList_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		///<summary>
		/// 合同币种
		///</summary>
		
		private string contractCurrency_;
		
		///<summary>
		/// 是否海淘
		///</summary>
		
		private byte? isHt_;
		
		///<summary>
		/// 是否门店导购
		///</summary>
		
		private byte? isStoreSale_;
		
		///<summary>
		/// 是否运营专场
		///</summary>
		
		private byte? specialOperationsFlag_;
		
		///<summary>
		/// 采购渠道
		///</summary>
		
		private List<string> purchaseChannel_;
		
		///<summary>
		/// 毛利率阶梯列表（结算模式为：毛利率阶梯时，有值）
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> grossProfitRateLadderList_;
		
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
		public long? GetShopCode(){
			return this.shopCode_;
		}
		
		public void SetShopCode(long? value){
			this.shopCode_ = value;
		}
		public string GetShopName(){
			return this.shopName_;
		}
		
		public void SetShopName(string value){
			this.shopName_ = value;
		}
		public string GetSellingAction(){
			return this.sellingAction_;
		}
		
		public void SetSellingAction(string value){
			this.sellingAction_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.ApplySchedules> GetSchedulesList(){
			return this.schedulesList_;
		}
		
		public void SetSchedulesList(List<com.vip.vis.purchase.schedules.service.query.ApplySchedules> value){
			this.schedulesList_ = value;
		}
		public System.DateTime? GetSellTimeFrom(){
			return this.sellTimeFrom_;
		}
		
		public void SetSellTimeFrom(System.DateTime? value){
			this.sellTimeFrom_ = value;
		}
		public System.DateTime? GetSellTimeTo(){
			return this.sellTimeTo_;
		}
		
		public void SetSellTimeTo(System.DateTime? value){
			this.sellTimeTo_ = value;
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
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public byte? GetSellingMode(){
			return this.sellingMode_;
		}
		
		public void SetSellingMode(byte? value){
			this.sellingMode_ = value;
		}
		public string GetSellingModeReadable(){
			return this.sellingModeReadable_;
		}
		
		public void SetSellingModeReadable(string value){
			this.sellingModeReadable_ = value;
		}
		public int? GetB2cModeId(){
			return this.b2cModeId_;
		}
		
		public void SetB2cModeId(int? value){
			this.b2cModeId_ = value;
		}
		public byte? GetCooperationType(){
			return this.cooperationType_;
		}
		
		public void SetCooperationType(byte? value){
			this.cooperationType_ = value;
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
		public List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> GetBrandList(){
			return this.brandList_;
		}
		
		public void SetBrandList(List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> value){
			this.brandList_ = value;
		}
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		public string GetContractCurrency(){
			return this.contractCurrency_;
		}
		
		public void SetContractCurrency(string value){
			this.contractCurrency_ = value;
		}
		public byte? GetIsHt(){
			return this.isHt_;
		}
		
		public void SetIsHt(byte? value){
			this.isHt_ = value;
		}
		public byte? GetIsStoreSale(){
			return this.isStoreSale_;
		}
		
		public void SetIsStoreSale(byte? value){
			this.isStoreSale_ = value;
		}
		public byte? GetSpecialOperationsFlag(){
			return this.specialOperationsFlag_;
		}
		
		public void SetSpecialOperationsFlag(byte? value){
			this.specialOperationsFlag_ = value;
		}
		public List<string> GetPurchaseChannel(){
			return this.purchaseChannel_;
		}
		
		public void SetPurchaseChannel(List<string> value){
			this.purchaseChannel_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> GetGrossProfitRateLadderList(){
			return this.grossProfitRateLadderList_;
		}
		
		public void SetGrossProfitRateLadderList(List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> value){
			this.grossProfitRateLadderList_ = value;
		}
		
	}
	
}